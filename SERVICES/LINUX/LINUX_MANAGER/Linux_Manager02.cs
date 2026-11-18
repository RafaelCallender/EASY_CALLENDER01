using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER
{

    public class Linux_Manager02
    {
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        public static string[] output = new string[100];
        public static string[] error = new string[100];
        private static bool github_webb_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_WEBB], out output[0], out error[0]);
        private static bool github_mobile_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_MOBILE], out output[1], out error[1]);
        private static bool github_console_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_EASYCONSOLE], out output[2], out error[2]);
        private static bool github_easycallender01_upload_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_CALLENDER01], out output[3], out error[3]);
        private static bool github_database_upload_bool_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.upload_EASY_DATABASE], out output[4], out error[4]);
        private static bool github_create_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.create_repository], out output[5], out error[5]);
        private static bool github_list_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.list_repository], out output[6], out error[6]);
        private static bool github_downnload_all_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.download_all_repository], out output[7], out error[7]);
        private static bool update_EASY_WEBB_repository_ = Linux_H01.RunCommand(Linux_Helper01.linux_github_array01[(int)Linux_Helper01.linux_github01_index.update_EASY_WEBB_repository], out output[8], out error[8]);
        public static bool github_webb_upload_bool = github_webb_upload_;
        public static bool github_mobile_upload_bool = github_mobile_upload_;
        public static bool github_console_upload_bool = github_console_upload_;
        public static bool github_easycallender01_upload_bool = github_easycallender01_upload_;
        public static bool github_database_upload_bool = github_database_upload_bool_;
        public static bool github_create_repository_bool = github_create_repository_;
        public static bool github_list_repository_bool = github_list_repository_;
        public static bool github_downnload_all_repository_bool = github_downnload_all_repository_;
        public static bool update_EASY_WEBB_repository_bool = update_EASY_WEBB_repository_;
        public static string github_webb_upload_output = output[0];
        public static string github_mobile_upload_output = output[1];
        public static string github_console_upload_output = output[2];
        public static string github_easycallender01_upload_output = output[3];
        public static string github_database_upload_output = output[4];
        public static string github_create_repository_output = output[4];
        public static string github_list_repository_output = output[5];
        public static string github_outputbase_upload_output = output[6];
        public static string github_downnload_all_repository_output = output[7];
        public static string update_EASY_WEBB_repository_output = output[8];
        public static string github_webb_upload_error = error[0];
        public static string github_mobile_upload_error = error[1];
        public static string github_console_upload_error = error[2];
        public static string github_easycallender01_upload_error = error[3];
        public static string github_database_upload_error = output[4];
        public static string github_create_repository_error = error[5];
        public static string github_list_repository_error = error[6];
        public static string github_downnload_all_repository_error = error[7];
        public static string update_EASY_WEBB_repository_error = error[8];


    }
}