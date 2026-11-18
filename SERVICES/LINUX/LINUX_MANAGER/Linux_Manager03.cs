using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER
{

    public class Linux_Manager03
    {

        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        public static string[] output = new string[100];
        public static string[] error = new string[100];
        private static bool pc_clean_up_bool_ = Linux_H01.RunCommand(Linux_Helper01.linux_terminal_array01[(int)Linux_Helper01.linux_terminal01_index.pc_clean_up], out output[0], out error[0]);
        public static bool pc_clean_up_bool = pc_clean_up_bool_;
        public static string pc_clean_up_output = output[0]; 
        public static string pc_clean_up_error = error[0];
    }
}