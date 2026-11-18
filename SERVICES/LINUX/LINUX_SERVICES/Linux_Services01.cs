using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES
{
    public class Linux_Services01
    {
        private static Linux_Manager01 Linux_M01 = new Linux_Manager01();
        public string DeleteRemoteFolder01()
        {
            if (Linux_Manager01.DeleteRemoteFolderbool == true)
            {
                return Linux_Manager01.output;
            }
            else
            {
                return Linux_Manager01.error;
            }
        }
        public string MakeRemoteFolder01()
        {
            if (Linux_Manager01.MakeRemoteFolderbool == true)
            {
                return Linux_Manager01.output;
            }
            else
            {
                return Linux_Manager01.error;
            }
        }
        public string UploadRemoteFolder01()
        {
            if (Linux_Manager01.UploadToOneDrivebool == true)
            {
                return Linux_Manager01.output;
            }
            else
            {
                return Linux_Manager01.error;
            }

        }
    }
}