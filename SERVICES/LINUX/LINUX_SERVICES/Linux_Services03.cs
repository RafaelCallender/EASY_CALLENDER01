using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER;
using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES
{
    public class Linux_Services03
    {
        private static Linux_Manager03 Linux_M03 = new Linux_Manager03();
        private static string[] data01 = new string[100];
        public string pc_clean_up()
        {
            if (Linux_Manager03.pc_clean_up_bool == true)
            {
                return $"{Linux_Manager03.pc_clean_up_output}";
            }
            else
            {
                return $"{Linux_Manager03.pc_clean_up_error}";
            }

        }

    }
}