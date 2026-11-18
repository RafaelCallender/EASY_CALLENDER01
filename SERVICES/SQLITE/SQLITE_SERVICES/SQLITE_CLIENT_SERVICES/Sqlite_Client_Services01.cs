using EASYPROJECT01.EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_CLIENT_MODEL.SQLITE_CLIENT_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_CLIENTS_MANAGER;
using SQLite;
using System.Xml;



namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CLIENT_SERVICES
{
    public class Sqlite_Client_Services01
    {
        private static string[] data01 = new string[100];
        public bool delete_client_using_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                        .FirstOrDefault(i => i.client_phonenumber == input);

            if (res != null)
            {
                Sqlite_Client_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }

        public bool delete_client_using_phonenumber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                    .FirstOrDefault(i => i.client_phonenumber == input);

            if (res != null)
            {
                Sqlite_Client_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }
        public bool delete_client_using_email(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                    .FirstOrDefault(i => i.client_emailaddress == input);

            if (res != null)
            {
                Sqlite_Client_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }

        public bool find_client_api_key_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                      .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_zellaappdata01_by_zellaappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                      .Where(i => i.client_zelleappdata01 == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_zelleappdata01.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_api_key_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_logo_by_logo(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_logo == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_logo.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_api_key_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_apikey_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_apikey_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_apikey_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_apikey_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_cashappdata01_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_colors_using_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_colors_using_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_colors_using_phonenumber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_data_using_email(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                          .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output =
        $"{res.client_name.ToString()}" +
        $"{res.client_emailaddress.ToString()}" +
        $"{res.client_phonenumber.ToString()}" +
        $"{res.client_api_key.ToString()}" +
        $"{res.client_cashappdata01.ToString()}" +
        $"{res.client_zelleappdata01.ToString()}" +
        $"{res.client_venmoappdata01.ToString()}" +
        $"{res.client_paypalappdata01.ToString()}" +
        $"{res.client_logo.ToString()}" +
        $"{res.client_latitude.ToString()}" +
        $"{res.client_longitude.ToString()}" +
        $"{res.client_primary_color.ToString()}" +
        $"{res.client_secondary_color.ToString()}" +
        $"{res.client_tertiary_color.ToString()}" +
        $"{res.client_social_media.ToString()}" +
        $"{res.client_type.ToString()}" +
        $"{res.client_date_created.ToString()}";

                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_data_using_latitude_and_longitude(string input, string input01, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                          .Where(i => i.client_api_key == input).FirstOrDefault();
            var res01 = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
            .Where(i => i.client_api_key == input01).FirstOrDefault();

            if (res != null)
            {
                if (res01 != null)
                {
                    output =
            $"{res.client_name.ToString()}" +
            $"{res.client_emailaddress.ToString()}" +
            $"{res.client_phonenumber.ToString()}" +
            $"{res.client_api_key.ToString()}" +
            $"{res.client_cashappdata01.ToString()}" +
            $"{res.client_zelleappdata01.ToString()}" +
            $"{res.client_venmoappdata01.ToString()}" +
            $"{res.client_paypalappdata01.ToString()}" +
            $"{res.client_logo.ToString()}" +
            $"{res.client_latitude.ToString()}" +
            $"{res.client_longitude.ToString()}" +
            $"{res.client_primary_color.ToString()}" +
            $"{res.client_secondary_color.ToString()}" +
            $"{res.client_tertiary_color.ToString()}" +
            $"{res.client_social_media.ToString()}" +
            $"{res.client_type.ToString()}" +
            $"{res.client_date_created.ToString()}";

                    return true;
                }
                else
                {
                    output = $"Data Not Found";
                    return false;
                }

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_data_using_logo(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                      .Where(i => i.client_api_key == input).FirstOrDefault();


            if (res != null)
            {

                output =
            $"{res.client_name.ToString()}" +
            $"{res.client_emailaddress.ToString()}" +
            $"{res.client_phonenumber.ToString()}" +
            $"{res.client_api_key.ToString()}" +
            $"{res.client_cashappdata01.ToString()}" +
            $"{res.client_zelleappdata01.ToString()}" +
            $"{res.client_venmoappdata01.ToString()}" +
            $"{res.client_paypalappdata01.ToString()}" +
            $"{res.client_logo.ToString()}" +
            $"{res.client_latitude.ToString()}" +
            $"{res.client_longitude.ToString()}" +
            $"{res.client_primary_color.ToString()}" +
            $"{res.client_secondary_color.ToString()}" +
            $"{res.client_tertiary_color.ToString()}" +
            $"{res.client_social_media.ToString()}" +
            $"{res.client_type.ToString()}" +
            $"{res.client_date_created.ToString()}";

                return true;
            }


            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_data_using_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();


            if (res != null)
            {

                output =
            $"{res.client_name.ToString()}" +
            $"{res.client_emailaddress.ToString()}" +
            $"{res.client_phonenumber.ToString()}" +
            $"{res.client_api_key.ToString()}" +
            $"{res.client_cashappdata01.ToString()}" +
            $"{res.client_zelleappdata01.ToString()}" +
            $"{res.client_venmoappdata01.ToString()}" +
            $"{res.client_paypalappdata01.ToString()}" +
            $"{res.client_logo.ToString()}" +
            $"{res.client_latitude.ToString()}" +
            $"{res.client_longitude.ToString()}" +
            $"{res.client_primary_color.ToString()}" +
            $"{res.client_secondary_color.ToString()}" +
            $"{res.client_tertiary_color.ToString()}" +
            $"{res.client_social_media.ToString()}" +
            $"{res.client_type.ToString()}" +
            $"{res.client_date_created.ToString()}";

                return true;
            }


            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_data_using_number(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();


            if (res != null)
            {

                output =
            $"{res.client_name.ToString()}" +
            $"{res.client_emailaddress.ToString()}" +
            $"{res.client_phonenumber.ToString()}" +
            $"{res.client_api_key.ToString()}" +
            $"{res.client_cashappdata01.ToString()}" +
            $"{res.client_zelleappdata01.ToString()}" +
            $"{res.client_venmoappdata01.ToString()}" +
            $"{res.client_paypalappdata01.ToString()}" +
            $"{res.client_logo.ToString()}" +
            $"{res.client_latitude.ToString()}" +
            $"{res.client_longitude.ToString()}" +
            $"{res.client_primary_color.ToString()}" +
            $"{res.client_secondary_color.ToString()}" +
            $"{res.client_tertiary_color.ToString()}" +
            $"{res.client_social_media.ToString()}" +
            $"{res.client_type.ToString()}" +
            $"{res.client_date_created.ToString()}";

                return true;
            }


            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_emailaddress_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_emailaddress_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_emailaddress_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_emailaddress_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_emailaddress_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_emailaddress_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }

        public bool find_client_emailaddress_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_location_using_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                 .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_latitude.ToString()}\n" +
                         $"{res.client_longitude.ToString()}\n";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_location_using_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                 .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_latitude.ToString()}\n" +
                         $"{res.client_longitude.ToString()}\n";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_location_using_phonenumber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                     .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_latitude.ToString()}\n" +
                         $"{res.client_longitude.ToString()}\n";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_logo_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_logo_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_logo_by_phonenumber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_name_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_paypalappdata01_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_phonenumber_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_venmoappdata01_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_venmoappdata01_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                             .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_client_venmoappdata01_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_venmoappdata01_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_venmoappdata01_by_paypalappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_venmoappdata01_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_venmoappdata01_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zellaappdata01_by_apikey(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zelleappdata01_by_cashappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zelleappdata01_by_emailaddress(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zelleappdata01_by_name(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zelleappdata01_by_phonnumeber(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_client_zelleappdata01_by_venmoappdata01(string input, out string output)
        {
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .Where(i => i.client_api_key == input).FirstOrDefault();
            if (res != null)
            {
                output = $"{res.client_emailaddress.ToString()}";
                return true;
            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool insert_client_data(string input01, string input02, string input03,
                                                        string input04, string input05, string input06,
                                                        string input07, string input08, string input09,
                                                        string input10, string input11, string input12,
                                                        string input13, string input14, out string output)
        {

            if (Sqlite_Client_Manager01.data01.Insert(
                new Sqlite_Client_Get_Model01
                {

                    client_name = input01,
                    client_emailaddress = input02,
                    client_phonenumber = input03,
                    client_api_key = input04,
                    client_cashappdata01 = input05,
                    client_zelleappdata01 = input06,
                    client_venmoappdata01 = input07,
                    client_paypalappdata01 = input08,
                    client_logo = input09,
                    client_latitude = Location_Manager01.get_latitude,
                    client_longitude = Location_Manager01.get_longitude,
                    client_primary_color = input10,
                    client_secondary_color = input11,
                    client_tertiary_color = input12,
                    client_social_media = input13,
                    client_type = input14,
                    client_date_created = Security_Services01.today_date

                }) > 0)
            {



                output = "Data Inserted Successfully";
                return true;


            }
            else
            {
                output = "Data Insertion Failed";
                return false;


            }
        }

        public bool update_clients_apikey_using_apikey(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_cashappdata01_using_cashappdata01(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_email_using_email(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                      .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_logo_using_logo(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                       .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_name_using_name(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                     .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_paypalappdata01_using_paypalappdata01(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                        .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_phnenumber_using_phonenumber(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                        .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_venmoappdata01_using_venmoappdata01(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                        .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_clients_zelleappdata01_using_zellappdata01(string input, string input01, out string output)
        {
            var client = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>()
                         .FirstOrDefault(i => i.client_api_key == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.client_api_key = input01;
            Sqlite_Client_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool view_all_client_data(out string output)
        {
            output = string.Empty;
            var res = Sqlite_Client_Manager01.data01.Table<Sqlite_Client_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output +=
    $"{a.client_name.ToString()}" +
    $"{a.client_emailaddress.ToString()}" +
    $"{a.client_phonenumber.ToString()}" +
    $"{a.client_api_key.ToString()}" +
    $"{a.client_cashappdata01.ToString()}" +
    $"{a.client_zelleappdata01.ToString()}" +
    $"{a.client_venmoappdata01.ToString()}" +
    $"{a.client_paypalappdata01.ToString()}" +
    $"{a.client_logo.ToString()}" +
    $"{a.client_latitude.ToString()}" +
    $"{a.client_longitude.ToString()}" +
    $"{a.client_primary_color.ToString()}" +
    $"{a.client_secondary_color.ToString()}" +
    $"{a.client_tertiary_color.ToString()}" +
    $"{a.client_social_media.ToString()}" +
    $"{a.client_type.ToString()}" +
    $"{a.client_date_created.ToString()}";
            }
            return true;
        }
        public bool view_client_database_storedprocedures(out string output)
        {

            output = $"delete_client_using_email\n" +
            $"delete_client_using_name\n" +
            $"delete_client_using_phonenumber\n" +
            $"find_client_api_key_by_emailaddress\n" +
            $"find_client_api_key_by_name\n" +
            $"find_client_api_key_by_phonnumeber\n" +
            $"find_client_apikey_by_apikey\n" +
            $"find_client_apikey_by_cashappdata01\n" +
            $"find_client_apikey_by_paypalappdata01\n" +
            $"find_client_apikey_by_venmoappdata01\n" +
            $"find_client_cashappdata01_by_apikey\n" +
            $"find_client_cashappdata01_by_cashappdata01\n" +
            $"find_client_cashappdata01_by_emailaddress\n" +
            $"find_client_cashappdata01_by_name\n" +
            $"find_client_cashappdata01_by_paypalappdata01\n" +
            $"find_client_cashappdata01_by_phonnumeber\n" +
            $"find_client_cashappdata01_by_venmoappdata01\n" +
            $"find_client_colors_using_emailaddress\n" +
            $"find_client_colors_using_name\n" +
            $"find_client_colors_using_phonenumber\n" +
            $"find_client_data_using_email\n" +
            $"find_client_data_using_latitude_and_longitude\n" +
            $"find_client_data_using_logo\n" +
            $"find_client_data_using_name\n" +
            $"find_client_data_using_number\n" +
            $"find_client_emailaddress_by_apikey\n" +
            $"find_client_emailaddress_by_cashappdata01\n" +
            $"find_client_emailaddress_by_emailaddress\n" +
            $"find_client_emailaddress_by_name\n" +
            $"find_client_emailaddress_by_paypalappdata01\n" +
            $"find_client_emailaddress_by_phonnumeber\n" +
            $"find_client_emailaddress_by_venmoappdata01\n" +
            $"find_client_location_using_emailaddress\n" +
            $"find_client_location_using_name\n" +
            $"find_client_location_using_phonenumber\n" +
            $"find_client_logo_by_emailaddress\n" +
            $"find_client_logo_by_name\n" +
            $"find_client_logo_by_phonenumber\n" +
            $"find_client_name_by_cashappdata01\n" +
            $"find_client_name_by_emailaddress\n" +
            $"find_client_name_by_name\n" +
            $"find_client_name_by_paypalappdata01\n" +
            $"find_client_name_by_phonnumeber\n" +
            $"find_client_name_by_venmoappdata01\n" +
            $"find_client_paypalappdata01_by_apikey\n" +
            $"find_client_paypalappdata01_by_cashappdata01\n" +
            $"find_client_paypalappdata01_by_emailaddress\n" +
            $"find_client_paypalappdata01_by_name\n" +
            $"find_client_paypalappdata01_by_paypalappdata01\n" +
            $"find_client_paypalappdata01_by_phonnumeber\n" +
            $"find_client_paypalappdata01_by_venmoappdata01\n" +
            $"find_client_phonenumber_by_apikey\n" +
            $"find_client_phonenumber_by_cashappdata01\n" +
            $"find_client_phonenumber_by_emailaddress\n" +
            $"find_client_phonenumber_by_name\n" +
            $"find_client_phonenumber_by_paypalappdata01\n" +
            $"find_client_phonenumber_by_phonnumeber\n" +
            $"find_client_phonenumber_by_venmoappdata01\n" +
            $"find_client_venmoappdata01_by_apikey\n" +
            $"find_client_venmoappdata01_by_cashappdata01\n" +
            $"find_client_venmoappdata01_by_emailaddress\n" +
            $"find_client_venmoappdata01_by_name\n" +
            $"find_client_venmoappdata01_by_paypalappdata01\n" +
            $"find_client_venmoappdata01_by_phonnumeber\n" +
            $"find_client_venmoappdata01_by_venmoappdata01\n" +
            $"find_client_zellaappdata01_by_apikey\n" +
            $"find_client_zelleappdata01_by_cashappdata01\n" +
            $"find_client_zelleappdata01_by_emailaddress\n" +
            $"find_client_zelleappdata01_by_name\n" +
            $"find_client_zelleappdata01_by_phonnumeber\n" +
            $"find_client_zelleappdata01_by_venmoappdata01\n" +
            $"insert_client_data\n" +
            $"update_clients_apikey_using_apikey\n" +
            $"update_clients_cashappdata01_using_cashappdata01\n" +
            $"update_clients_email_using_email\n" +
            $"update_clients_logo_using_logo\n" +
            $"update_clients_name_using_name\n" +
            $"update_clients_paypalappdata01_using_paypalappdata01\n" +
            $"update_clients_phnenumber_using_phonenumbe\n" +
            $"update_clients_venmoappdata01_using_venmoappdata01\n" +
            $"update_clients_zelleappdata01_using_zellappdata01\n" +
            $"view_all_client_data\n";
            return true;
        }

    }
}
