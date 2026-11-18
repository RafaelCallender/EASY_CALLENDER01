using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_MANAGER;
using System.Diagnostics;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES
{
    public class Linux_Services02
    {
        private static Linux_Manager02 Linux_M02 = new Linux_Manager02();
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        private static string[] data01 = new string[100];
        public string github_upload_EASYWEBB()
        {
            if (Linux_Manager02.github_webb_upload_bool == true)
            {
                return $"{Linux_Manager02.github_webb_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_webb_upload_error}";
            }

        }
        public string github_upload_EASYCONSOLE()
        {
            if (Linux_Manager02.github_console_upload_bool == true)
            {
                return $"{Linux_Manager02.github_console_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_console_upload_error}";
            }

        }
        public string github_upload_EASY_MOBILE()
        {
            if (Linux_Manager02.github_mobile_upload_bool == true)
            {
                return $"{Linux_Manager02.github_mobile_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_mobile_upload_error}";
            }

        }

        public string github_upload_EASY_CALLENDER01()
        {
            if (Linux_Manager02.github_easycallender01_upload_bool == true)
            {
                return $"{Linux_Manager02.github_easycallender01_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_easycallender01_upload_error}";
            }

        }
        public string github_upload_EASY_DATABASE()
        {
            if (Linux_Manager02.github_database_upload_bool == true)
            {
                return $"{Linux_Manager02.github_database_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_database_upload_error}";
            }

        }
        public string github_downnload_all_repository()
        {
            if (Linux_Manager02.github_downnload_all_repository_bool == true)
            {
                return $"{Linux_Manager02.github_downnload_all_repository_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_downnload_all_repository_error}";
            }

        }
        public string github_upload_all_projects()
        {

            if (Linux_Manager02.github_webb_upload_bool == true)
            {

                if (Linux_Manager02.github_mobile_upload_bool == true)
                {

                    if (Linux_Manager02.github_console_upload_bool == true)
                    {
                        if (Linux_Manager02.github_easycallender01_upload_bool == true)
                        {

                            if (Linux_Manager02.github_database_upload_bool == true)
                            {
                                      return $"{Linux_Manager02.github_database_upload_output}\n" +
                                             $"{Linux_Manager02.github_mobile_upload_output}\n" +
                                             $"{Linux_Manager02.github_console_upload_output}\n" +
                                             $"{Linux_Manager02.github_easycallender01_upload_output}\n" +
                                             $"{Linux_Manager02.github_database_upload_output}\n"



                                ;
                            }
                            else
                            {
                                return $"{Linux_Manager02.github_database_upload_error}";
                            }

                        }
                        else
                        {
                            return $"{Linux_Manager02.github_easycallender01_upload_error}";
                        }
                    }
                    else
                    {
                        return $"{Linux_Manager02.github_console_upload_error}";
                    }
                }
                else
                {
                    return $"{Linux_Manager02.github_mobile_upload_error}";
                }
            }
            else
            {
                return $"{Linux_Manager02.github_webb_upload_error}";
            }


        }
        public string github_create_repository(string input)
        {

            if (Linux_H01.RunCommand(Linux_H01.CreateRepositoryCommand(input), out data01[70], out data01[72]) == true)
            {
                data01[0] = $"{data01[70]}";
            }
            else
            {
                data01[0] = $"{data01[72]}";
            }
            return data01[0];
        }
        public string github_delete_repository(string input)
        {

            if (Linux_H01.RunCommand(Linux_H01.DeleteRepositoryCommand(input), out data01[70], out data01[72]) == true)
            {
                return $"{data01[70]}";
            }
            else
            {
                return $"{data01[72]}";
            }

        }
        public string github_list_repository(string input)
        {
            if (Linux_Manager02.github_list_repository_bool == true)
            {
                return $"{Linux_Manager02.github_list_repository_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_list_repository_error}";
            }

        }
        public string github_download_all_repository()
        {
            if (Linux_Manager02.github_downnload_all_repository_bool == true)
            {
                return $"{Linux_Manager02.github_downnload_all_repository_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_downnload_all_repository_error}";
            }

        }

        public string update_EASY_WEBB_repository()
        {
            if (Linux_Manager02.update_EASY_WEBB_repository_bool == true)
            {
                return $"{Linux_Manager02.github_webb_upload_output}";
            }
            else
            {
                return $"{Linux_Manager02.github_webb_upload_error}";
            }

        }


    }
}