using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;


namespace EASY_CALLENDER01.SERVICES.AUDIO_SERVICES
{
    public class Audio_Services02
    {


        public string record_voice()
        {
          
            string filePath = Path.Combine(File_Helper01.save_files[1], "recordedAudio.wav");
            // 1. Create a WaveInEvent for capturing audio
            using (var waveIn = new WaveInEvent())
            {
                waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1 kHz, mono

                // 2. Create a file writer to save the recorded audio
                using (var writer = new WaveFileWriter(filePath, waveIn.WaveFormat))
                {
                    // 3. Handle DataAvailable event to write audio bytes
                    waveIn.DataAvailable += (s, e) =>
                    {
                        writer.Write(e.Buffer, 0, e.BytesRecorded);
                    };

                    // 4. Start recording
                    waveIn.StartRecording();

                    // Wait for user to stop recording
                    Console.ReadLine();

                    // 5. Stop recording
                    waveIn.StopRecording();
                }
            }
            return $"Recording saved to: {filePath}\n" ;
  
        }








    }
}
