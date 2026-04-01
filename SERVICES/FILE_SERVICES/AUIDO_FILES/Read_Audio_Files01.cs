using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;

namespace EASY_CALLENDER01.SERVICES.FILE_SERVICES.AUIDO_FILES
{
    public class Read_Audio_Files01
    {
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] file_helper = File_H01.all_embedded_audio_files().Split();
        public string[] audio_files01 => file_helper;
    }
}

