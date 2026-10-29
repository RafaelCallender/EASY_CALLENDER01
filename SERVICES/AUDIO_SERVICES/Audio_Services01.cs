using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Runtime.Versioning;
using System.Security;
using System.Speech;
using System.Speech.Synthesis;
using Whisper.net;
using System.Diagnostics;
using Microsoft.Maui.Media;
using CommunityToolkit.Maui.Media;
using System.Globalization;
using System.Diagnostics;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES
{
    public class Audio_Services01
    {
        private string[] data01 = new string[100];
        private static List<SegmentData> segments = new List<SegmentData>();
        private static MemoryStream memoryStream = new MemoryStream();

     private static  string modelPath =
            "/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_CALLENDER01/FILES/BIN/ggml-base.en.bin";
        public async Task<string> read_audio_file01()
        {
          
            using var whisperFactory = WhisperFactory.FromPath(modelPath);
            using var model = whisperFactory.CreateBuilder()
                                            .WithLanguage("en")
                                            .Build();

            using var audio16k = ConvertTo16kHz();
            var segments = new List<Whisper.net.SegmentData>();
            await foreach (var segment in model.ProcessAsync(audio16k))
            {
                segments.Add(segment);
            }
            string recognizedText = string.Join(" ",segments.Select(s => s.Text));
            return $"{segments.Count}\n{recognizedText}";
        }

        private MemoryStream ConvertTo16kHz()
        {
            using var reader = new AudioFileReader(modelPath);
            var resampler = new WdlResamplingSampleProvider(reader, 16000);
            var waveProvider = resampler.ToWaveProvider16();
            var outputStream = new MemoryStream();
            WaveFileWriter.WriteWavFileToStream(outputStream, waveProvider);
            outputStream.Position = 0;
            return outputStream;
        }


        [SupportedOSPlatform("windows")]
        public async Task text_to_speech_windows(string input)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = 0;     // speed (-10 to 10)
            synthesizer.Volume = 100; // 0–100
            synthesizer.SpeakAsync(input);
            await Task.CompletedTask;

        }

        public async Task text_to_speech_linux01(string text)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "espeak-ng",
                UseShellExecute = false,
                CreateNoWindow = true
            };
            startInfo.ArgumentList.Add(text);
            using Process? process = Process.Start(startInfo);
        }
    }
}
