using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER
{
    public class Linux_Manager01
    {
  
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        public static string output = string.Empty;
        public static string error = string.Empty;

        private static bool DeleteRemoteFolderbool_ = Linux_H01.RunCommand(Linux_Helper01.linux_OneDrive_array[(int)Linux_Helper01.linux_OneDrive01_index.DeleteRemoteFolder], out output, out error);
        private static bool MakeRemoteFolderbool_ = Linux_H01.RunCommand(Linux_Helper01.linux_OneDrive_array[(int)Linux_Helper01.linux_OneDrive01_index.MakeRemoteFolder], out output, out error);
        private static bool UploadToOneDrivebool_ = Linux_H01.RunCommand(Linux_Helper01.linux_OneDrive_array[(int)Linux_Helper01.linux_OneDrive01_index.UploadToOneDrive], out output, out error);
        public static bool DeleteRemoteFolderbool => DeleteRemoteFolderbool_;
        public static bool MakeRemoteFolderbool => MakeRemoteFolderbool_;
        public static bool UploadToOneDrivebool => UploadToOneDrivebool_;

    }
}