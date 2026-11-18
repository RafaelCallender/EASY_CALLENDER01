using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using NAudio.Wave;
using System.Collections.Generic;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Whisper.net;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES
{
    public class Audio_Services03
    {

        private readonly string modelPath;
        private readonly string outputDirectory;
        public Audio_Services03(
         string whisperModelPath,
         string transcriptDirectory)
        {
            modelPath = whisperModelPath;
            outputDirectory = transcriptDirectory;

            Directory.CreateDirectory(outputDirectory);
        }

        // MAIN METHOD
        public async Task<string> transcribe_youtube_video01(
            string youtubeUrl,
            string format = "txt",
            CancellationToken cancellationToken = default)
        {
            string workDirectory = Path.Combine(
                Path.GetTempPath(),
                "EASY_YOUTUBE_" + Guid.NewGuid().ToString("N"));

            Directory.CreateDirectory(workDirectory);

            try
            {
                if (!File.Exists(modelPath))
                    throw new FileNotFoundException(
                        "Whisper model was not found.", modelPath);

                if (format != "txt" && format != "srt")
                    throw new ArgumentException(
                        "Format must be txt or srt.");

                if (!Uri.TryCreate(
                    youtubeUrl,
                    UriKind.Absolute,
                    out Uri? uri) ||
                    (uri.Scheme != Uri.UriSchemeHttp &&
                     uri.Scheme != Uri.UriSchemeHttps) ||
                    (uri.Host != "youtube.com" &&
                     !uri.Host.EndsWith(".youtube.com",
                         StringComparison.OrdinalIgnoreCase) &&
                     uri.Host != "youtu.be" &&
                     !uri.Host.EndsWith(".youtu.be",
                         StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException(
                        "Please provide a valid YouTube URL.");
                }

                // STEP 1: DOWNLOAD AND EXTRACT AUDIO

                string audioOutput = Path.Combine(
                    workDirectory, "audio.%(ext)s");

                await run_process01(
                    "yt-dlp",
                    new[]
                    {
                        "--no-playlist",
                        "--no-progress",
                        "--extract-audio",
                        "--audio-format", "wav",
                        "--output", audioOutput,
                        youtubeUrl
                    },
                    cancellationToken);

                string audioFile = Path.Combine(
                    workDirectory, "audio.wav");

                if (!File.Exists(audioFile))
                    throw new Exception(
                        "Audio extraction failed.");

                // STEP 2: TRANSCRIBE AUDIO

                StringBuilder transcript = new();
                StringBuilder subtitles = new();

                using var whisperFactory =
                    WhisperFactory.FromPath(modelPath);

                using var processor =
                    whisperFactory.CreateBuilder()
                        .WithLanguage("auto")
                        .Build();

                using var audioStream =
                    File.OpenRead(audioFile);

                int segmentNumber = 1;

                await foreach (var segment in
                    processor.ProcessAsync(
                        audioStream, cancellationToken))
                {
                    string text = segment.Text.Trim();

                    if (string.IsNullOrWhiteSpace(text))
                        continue;

                    transcript.AppendLine(text);

                    subtitles.AppendLine(
                        segmentNumber.ToString());

                    subtitles.AppendLine(
                        $"{format_srt_time01(segment.Start)} --> " +
                        $"{format_srt_time01(segment.End)}");

                    subtitles.AppendLine(text);
                    subtitles.AppendLine();

                    segmentNumber++;
                }

                // STEP 3: SAVE TRANSCRIPT

                string fileName =
                    "YouTube_Transcript_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmmss");

                string extension =
                    format == "srt" ? ".srt" : ".txt";

                string transcriptPath = Path.Combine(
                    outputDirectory,
                    fileName + extension);

                string content =
                    format == "srt"
                    ? subtitles.ToString()
                    : transcript.ToString();

                await File.WriteAllTextAsync(
                    transcriptPath,
                    content,
                    Encoding.UTF8,
                    cancellationToken);

                return transcriptPath;
            }
            finally
            {
                // STEP 4: CLEAN UP TEMPORARY FILES

                if (Directory.Exists(workDirectory))
                {
                    try
                    {
                        Directory.Delete(workDirectory, true);
                    }
                    catch
                    {
                        // Temporary cleanup can be retried later.
                    }
                }
            }
        }

        // FORMAT SRT TIMESTAMPS

        private static string format_srt_time01(
            TimeSpan time)
        {
            if (time < TimeSpan.Zero)
                time = TimeSpan.Zero;

            return time.ToString(
                @"hh\:mm\:ss\,fff");
        }

        // RUN LINUX TERMINAL COMMANDS SAFELY

        private static async Task run_process01(
            string command,
            string[] arguments,
            CancellationToken cancellationToken)
        {
            using Process process = new();

            process.StartInfo = new ProcessStartInfo
            {
                FileName = command,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            foreach (string argument in arguments)
                process.StartInfo.ArgumentList.Add(argument);

            process.Start();

            Task<string> outputTask =
                process.StandardOutput.ReadToEndAsync();

            Task<string> errorTask =
                process.StandardError.ReadToEndAsync();

            try
            {
                await process.WaitForExitAsync(
                    cancellationToken);
            }
            catch (OperationCanceledException)
            {
                if (!process.HasExited)
                    process.Kill(true);

                throw;
            }

            string error = await errorTask;
            await outputTask;

            if (process.ExitCode != 0)
            {
                throw new Exception(
                    $"{command} failed: {error}");
            }
        }
    }
}