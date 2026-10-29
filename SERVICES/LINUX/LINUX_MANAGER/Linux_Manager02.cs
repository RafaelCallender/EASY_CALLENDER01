using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER
{
    public class Linux_Manager02
    {
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        public static string output = string.Empty;
        public static string error = string.Empty;
        private static bool github_webb_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_WEBB], out output, out error);
        private static bool github_mobile_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_MOBILE], out output, out error);
        private static bool github_console_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_EASYCONSOLE], out output, out error);
        private static bool github_easycallender01_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_CALLENDER01], out output, out error);
        private static bool github_create_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.create_repository], out output, out error);
        private static bool github_list_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.list_repository], out output, out error);
        private static bool github_database_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_DATABASE], out output, out error);

        public static bool github_webb_upload => github_webb_upload_;
        public static bool github_mobile_upload => github_mobile_upload_;
        public static bool github_console_upload => github_console_upload_;
        public static bool github_easycallender01_upload => github_easycallender01_upload_;
        public static bool github_create_repository => github_create_repository_;
        public static bool github_list_repository => github_list_repository_;
         public static bool github_database_upload => github_database_upload_;
    }
}