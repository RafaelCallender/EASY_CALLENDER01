using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER;
using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES
{
    public class Linux_Services02
    {
        private static Linux_Manager02 Linux_M02 = new Linux_Manager02();
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        private static string res = string.Empty;
        private static string[] data01 = new string[100];
        public string github_upload_EASYWEBB()
        {
            if (Linux_Manager02.github_webb_upload == true)
            {
                res = $"{Linux_Manager02.output}";
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }
            return res;
        }
        public string github_upload_EASYCONSOLE()
        {
            if (Linux_Manager02.github_console_upload == true)
            {
                res = $"{Linux_Manager02.output}";
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }
            return res;
        }
        public string github_upload_EASY_MOBILE()
        {
            if (Linux_Manager02.github_mobile_upload == true)
            {
                res = $"{Linux_Manager02.output}";
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }
            return res;
        }

        public string github_upload_EASY_CALLENDER01()
        {
            if (Linux_Manager02.github_easycallender01_upload == true)
            {
                res = $"{Linux_Manager02.output}";
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }
            return res;
        }
        public string github_upload_EASY_DATABASE()
        {
            if (Linux_Manager02.github_database_upload == true)
            {
                res = $"{Linux_Manager02.output}";
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }
            return res;
        }



        public string github_upload_all_projects()
        {

            if (Linux_Manager02.github_webb_upload == true)
            {
                res += $"{Linux_Manager02.output}";
                if (Linux_Manager02.github_mobile_upload == true)
                {
                    res += $"{Linux_Manager02.output}";
                    if (Linux_Manager02.github_console_upload == true)
                    {
                        res += $"{Linux_Manager02.output}";
                        if (Linux_Manager02.github_easycallender01_upload == true)
                        {
                            res += $"{Linux_Manager02.output}";
                            if (Linux_Manager02.github_database_upload == true)
                            {
                                res += $"{Linux_Manager02.output}";
                            }
                            else
                            {
                                res = $"{Linux_Manager02.error}";
                            }

                        }
                        else
                        {
                            res = $"{Linux_Manager02.error}";
                        }



                    }
                    else
                    {
                        res = $"{Linux_Manager02.error}";
                    }
                }
                else
                {
                    res = $"{Linux_Manager02.error}";
                }
            }
            else
            {
                res = $"{Linux_Manager02.error}";
            }

            return res;
        }
        public string github_create_repository(string input)
        {

            if (Linux_H01.RunCommand(Linux_H01.CreateRepositoryCommand(input), out data01[70], out data01[72]) == true)
            {
                res = $"{data01[70]}";
            }
            else
            {
                res = $"{data01[72]}";
            }
            return res;
        }
        public string github_delete_repository(string input)
        {

            if (Linux_H01.RunCommand(Linux_H01.DeleteRepositoryCommand(input), out data01[70], out data01[72]) == true)
            {
                res = $"{data01[70]}";
            }
            else
            {
                res = $"{data01[72]}";
            }
            return res;
        }
        public string github_list_repository(string input)
        {
            if (Linux_H01.RunCommand(Linux_H01.ListRepositoryCommand(input), out data01[70], out data01[72]) == true)
            {
                res = $"{data01[70]}";
            }
            else
            {
                res = $"{data01[72]}";
            }
            return res;
        }
    }
}