using System.Diagnostics;
using System.Globalization;
using System.Runtime.Versioning;
using System.Speech.Synthesis;
using System.Text;
using Microsoft.Maui.ApplicationModel;
using CommunityToolkit.Maui.Media;
using Microsoft.Maui.Media;
using Whisper.net;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES
{
    public class Audio_Services01
    {
        private static readonly string modelPath = Path.Combine(
            AppContext.BaseDirectory,
            "FILES",
            "WHISPER_FILE",
            "ggml-base.en.bin");
        private CancellationTokenSource? speechCancellation;
        private string recognizedText = string.Empty;
        private bool isStarting;
        private bool isListening;
        private bool isStopping;
        private Process? recordingProcess;

        private readonly string audioPath =
            Path.Combine(
                Path.GetTempPath(),
                "easy_speech_recording.wav");

        private readonly ISpeechToText speech = SpeechToText.Default;

        public async Task<string> read_audio_file01(string input)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(input);
            if (!File.Exists(input))
                throw new FileNotFoundException("The audio file was not found.", input);

            EnsureWhisperModelExists();

            using var whisperFactory = WhisperFactory.FromPath(modelPath);
            using var model = whisperFactory.CreateBuilder()
                                            .WithLanguage("en")
                                            .Build();

            using var audio16k = await ConvertTo16kHz(input);
            var segments = new List<Whisper.net.SegmentData>();
            await foreach (var segment in model.ProcessAsync(audio16k))
            {
                segments.Add(segment);
            }
            return string.Join(" ", segments.Select(s => s.Text));
        }
        private async Task<MemoryStream> ConvertTo16kHz(string input)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            startInfo.ArgumentList.Add("-v");
            startInfo.ArgumentList.Add("error");
            startInfo.ArgumentList.Add("-i");
            startInfo.ArgumentList.Add(input);
            startInfo.ArgumentList.Add("-map");
            startInfo.ArgumentList.Add("0:a:0");
            startInfo.ArgumentList.Add("-ac");
            startInfo.ArgumentList.Add("1");
            startInfo.ArgumentList.Add("-ar");
            startInfo.ArgumentList.Add("16000");
            startInfo.ArgumentList.Add("-c:a");
            startInfo.ArgumentList.Add("pcm_s16le");
            startInfo.ArgumentList.Add("-f");
            startInfo.ArgumentList.Add("wav");
            startInfo.ArgumentList.Add("pipe:1");
            using var process = new Process { StartInfo = startInfo };
            process.Start();
            var outputStream = new MemoryStream();
            Task copyAudio = process.StandardOutput.BaseStream.CopyToAsync(outputStream);
            Task<string> readError = process.StandardError.ReadToEndAsync();
            await Task.WhenAll(copyAudio, process.WaitForExitAsync());
            string error = await readError;
            if (process.ExitCode != 0)
                throw new InvalidOperationException(
                    $"FFmpeg could not decode the audio file: {error}");

            outputStream.Position = 0;
            return outputStream;
        }

        private static void EnsureWhisperModelExists()
        {
            if (!File.Exists(modelPath))
                throw new FileNotFoundException(
                    $"Whisper model not found: {modelPath}",
                    modelPath);
        }

        [SupportedOSPlatform("windows")]
        public async Task text_to_speech_windows(string input)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(input);

            using var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = 0;     // speed (-10 to 10)
            synthesizer.Volume = 100; // 0–100
            var completed = new TaskCompletionSource<SpeakCompletedEventArgs>(
                TaskCreationOptions.RunContinuationsAsynchronously);
            void OnSpeakCompleted(object? sender, SpeakCompletedEventArgs args) =>
                completed.TrySetResult(args);

            synthesizer.SpeakCompleted += OnSpeakCompleted;
            try
            {
                synthesizer.SpeakAsync(input);
                SpeakCompletedEventArgs result = await completed.Task;
                if (result.Error is not null)
                    throw result.Error;
                if (result.Cancelled)
                    throw new OperationCanceledException("Speech synthesis was canceled.");
            }
            finally
            {
                synthesizer.SpeakCompleted -= OnSpeakCompleted;
                synthesizer.SpeakAsyncCancelAll();
            }
        }

        public async Task text_to_speech_linux01(string text)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(text);

            var startInfo = new ProcessStartInfo
            {
                FileName = "espeak-ng",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            startInfo.ArgumentList.Add(text);
            using Process process = Process.Start(startInfo)
                ?? throw new InvalidOperationException("Could not start espeak-ng.");
            await process.WaitForExitAsync();
            if (process.ExitCode != 0)
                throw new InvalidOperationException(
                    $"espeak-ng exited with code {process.ExitCode}.");
        }


        public async Task<string> speech_to_text_start_andriod()
        {
            if (isStarting || isListening || isStopping)
                return "Speech recognition is already starting, running, or stopping.";

            isStarting = true;
            isStopping = false;
            CancellationTokenSource? cts = null;
            try
            {
                cts = new CancellationTokenSource();
                speechCancellation = cts;

                PermissionStatus microphonePermission =
                    await Permissions.RequestAsync<Permissions.Microphone>();
                if (microphonePermission != PermissionStatus.Granted)
                    return "Microphone permission denied.";

                bool speechPermission = await speech.RequestPermissions(cts.Token);
                if (!speechPermission)
                    return "Speech recognition permission denied.";

                // Clear previous speech.
                recognizedText = string.Empty;

                // Subscribe to recognition events.
                speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                speech.RecognitionResultUpdated += OnRecognitionUpdated;
                speech.RecognitionResultCompleted += OnRecognitionCompleted;

                await speech.StartListenAsync(
                    new SpeechToTextOptions
                    {
                        Culture = CultureInfo.GetCultureInfo("en-US"),
                        ShouldReportPartialResults = true
                    },
                    cts.Token);

                isListening = true;

                return "Recording started. Speak now.";
            }
            catch (OperationCanceledException)
            {
                return "Speech recognition start was canceled.";
            }
            catch (Exception ex)
            {
                return $"Speech recognition failed: {ex.Message}";
            }
            finally
            {
                isStarting = false;

                if (!isListening)
                {
                    speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                    speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                    if (ReferenceEquals(speechCancellation, cts))
                        speechCancellation = null;

                    cts?.Cancel();
                    cts?.Dispose();
                }
            }
        }

        public async Task<string> speech_to_text_end_andriod()
        {
            if (!isListening || isStopping)
                return "Speech recognition is not running.";

            isStopping = true;
            try
            {
                await speech.StopListenAsync(CancellationToken.None);

                string output = recognizedText;
                return string.IsNullOrWhiteSpace(output)
                    ? "No speech was recognized."
                    : output;
            }
            catch (Exception ex)
            {
                return $"Stop failed: {ex.Message}";
            }
            finally
            {
                isListening = false;
                isStarting = false;
                isStopping = false;

                speech.RecognitionResultUpdated -= OnRecognitionUpdated;
                speech.RecognitionResultCompleted -= OnRecognitionCompleted;

                var oldCts = speechCancellation;
                speechCancellation = null;

                oldCts?.Cancel();
                oldCts?.Dispose();
            }
        }

        private void OnRecognitionUpdated(object? sender, SpeechToTextRecognitionResultUpdatedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.RecognitionResult))
            {
                recognizedText = e.RecognitionResult;
                System.Diagnostics.Debug.WriteLine($"LIVE SPEECH: {recognizedText}");
            }
        }

        private void OnRecognitionCompleted(object? sender, SpeechToTextRecognitionResultCompletedEventArgs e)
        {
            var result = e.RecognitionResult;
            if (result.IsSuccessful && !string.IsNullOrWhiteSpace(result.Text))
            {
                recognizedText = result.Text;
                System.Diagnostics.Debug.WriteLine($"FINAL SPEECH: {recognizedText}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"RECOGNITION ERROR: {result.Exception?.Message}");
            }
        }
        public Task<string> speech_to_text_start_linux()
        {
            try
            {
                if (recordingProcess != null)
                {
                    if (!recordingProcess.HasExited)
                        return Task.FromResult(
                            "Recording is already running.");

                    recordingProcess.Dispose();
                    recordingProcess = null;
                }

                var startInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                };

                startInfo.ArgumentList.Add("-y");
                startInfo.ArgumentList.Add("-hide_banner");
                startInfo.ArgumentList.Add("-loglevel");
                startInfo.ArgumentList.Add("error");
                startInfo.ArgumentList.Add("-f");
                startInfo.ArgumentList.Add("pulse");
                startInfo.ArgumentList.Add("-i");
                startInfo.ArgumentList.Add("default");
                startInfo.ArgumentList.Add("-ac");
                startInfo.ArgumentList.Add("1");
                startInfo.ArgumentList.Add("-ar");
                startInfo.ArgumentList.Add("16000");
                startInfo.ArgumentList.Add("-c:a");
                startInfo.ArgumentList.Add("pcm_s16le");
                startInfo.ArgumentList.Add("-f");
                startInfo.ArgumentList.Add("wav");
                startInfo.ArgumentList.Add(audioPath);

                recordingProcess = new Process
                {
                    StartInfo = startInfo
                };

                recordingProcess.Start();

                // Read errors asynchronously to prevent pipe blocking.
                recordingProcess.BeginErrorReadLine();

                return Task.FromResult(
                    "Recording started. Speak now.");
            }
            catch (Exception ex)
            {
                recordingProcess?.Dispose();
                recordingProcess = null;

                return Task.FromResult(
                    $"Recording failed: {ex.Message}");
            }
        }

        // STOP RECORDING AND RETURN RECOGNIZED TEXT
        public async Task<string> speech_to_text_stop_linux()
        {
            try
            {
                if (recordingProcess == null)
                    return "No recording is running.";

                Process process = recordingProcess;
                recordingProcess = null;

                try
                {
                    if (!process.HasExited)
                    {
                        // Tell FFmpeg to finish the WAV file correctly.
                        await process.StandardInput.WriteLineAsync("q");
                        process.StandardInput.Close();
                        await process.WaitForExitAsync();
                    }

                    if (process.ExitCode != 0)
                        return $"Recording stopped unexpectedly (FFmpeg exit code {process.ExitCode}).";

                    if (!File.Exists(audioPath))
                        return "Audio recording was not created.";

                    if (new FileInfo(audioPath).Length <= 44)
                        return "Recording is empty. Check your microphone.";

                    if (!File.Exists(modelPath))
                        return $"Whisper model not found: {modelPath}";

                    // Load Whisper and transcribe the WAV file.
                    using var factory =
                        WhisperFactory.FromPath(modelPath);

                    using var recognizer = factory
                        .CreateBuilder()
                        .WithLanguage("en")
                        .Build();

                    using var audioStream = File.OpenRead(audioPath);

                    var output = new StringBuilder();

                    await foreach (var segment in
                        recognizer.ProcessAsync(audioStream))
                    {
                        output.Append(segment.Text);
                    }

                    string text = output.ToString().Trim();

                    return string.IsNullOrWhiteSpace(text)
                        ? "No speech was recognized."
                        : text;
                }
                finally
                {
                    process.Dispose();
                }
            }
            catch (Exception ex)
            {
                return $"Speech-to-text failed: {ex.Message}";
            }
        }

        public void Dispose()
        {
            if (recordingProcess != null)
            {
                try
                {
                    if (!recordingProcess.HasExited)
                    {
                        recordingProcess.Kill();
                        recordingProcess.WaitForExit();
                    }
                }
                catch
                {
                    // Ignore cleanup errors.
                }

                recordingProcess.Dispose();
                recordingProcess = null;
            }
        }
    }
}