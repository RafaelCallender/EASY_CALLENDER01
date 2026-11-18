using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_USER_MANAGER;
using SQLite;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_USER_SERVICES
{
    public class Sqlite_User_Services01
    {
        private static string[] data01 = new string[100];
        public bool delete_user_using_phonenumber(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.phonenumber == input);

            if (res != null)
            {
                Sqlite_User_Manager01.data01[0].Delete(res);
                output = "Client deleted successfully.";
                return true;

            }
            else
            {
                output = "Email address not found.";
                return true;

            }
        }

        public bool delete_user_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.username == input);

            if (res != null)
            {
                Sqlite_User_Manager01.data01[0].Delete(res);
                output = "Client deleted successfully.";
                return true;

            }
            else
            {
                output = "Email address not found.";
                return true;

            }
        }

        public bool find_email_using_email(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.email.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_email_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.email.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_password_using_email(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.password.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_password_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.password.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_phonenumber_using_email(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.phonenumber.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_phonenumber_using_phonenumber(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.phonenumber == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.phonenumber.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_phonenumber_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.phonenumber.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_user_location_using_email(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.latitude.ToString()}\n" +
                         $"{res.longitude.ToString()}\n";

                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_user_location_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                         .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.latitude.ToString()}\n" +
                         $"{res.longitude.ToString()}\n";

                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }

        }
        public bool find_username_password(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.password == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.username.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_username_using_email(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.username.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        
        public bool find_username_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.username.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool find_usernmae_using_username(string input, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (data01 != null)
            {
                output = $"{res.username.ToString()}";
                return true;

            }
            else
            {
                output = $"Data Not Found";
                return false;

            }
        }
        public bool insert_text_file_using_username(string input,string input01, out string output)
        {

            if (Sqlite_User_Manager01.data01[0].Insert(
                new Sqlite_User_Get_Model01
                {
                    text_file = input01,



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

        public bool insert_user(string input01, string input02, string input03,
                                          string input04, string input05, string input06,
                                          string input07, out string output)
        {
            if (Sqlite_User_Manager01.data01[0].Insert(
                          new Sqlite_User_Get_Model01
                          {

                              username = input01,
                              firstname = input02,
                              lastname = input03,
                              birthdate = input04,
                              email = input05,
                              phonenumber = input06,
                              password = input07,
                              longitude = Location_Manager01.get_longitude,
                              latitude = Location_Manager01.get_latitude,
                              creation_date = Security_Services01.today_date,
                              text_file = "",
                              audio_file = "",
                              image_file = "",
                              video_file = "",
                              text_file_creation_date = Security_Services01.today_date,
                              audio_file_creation_date = Security_Services01.today_date,
                              image_file_creation_date = Security_Services01.today_date,
                              video_file_creation_date = Security_Services01.today_date,











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
        public bool insert_user_audio_file_using_username(string input,string input01, out string output)
        {

            if (Sqlite_User_Manager01.data01[0].Insert(
                new Sqlite_User_Get_Model01
                {
                    audio_file = input01,



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
        public bool insert_user_text_file_using_username(string input,string input01, out string output)
        {

            if (Sqlite_User_Manager01.data01[0].Insert(
                new Sqlite_User_Get_Model01
                {
                    text_file = input01,



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
        public bool update_email_using_email(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }
         



        public bool update_email_using_username(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_password_using_email(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_password_using_phonenumber(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_password_using_username(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_phonenumber_using_email(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_phonenumber_using_username(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_user_location_using_email(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_user_location_using_name(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_user_location_using_phonenumber(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_user_location_using_username(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_username_using_email(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_username_using_phonenumber(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool update_username_using_username(string input, string input01, out string output)
        {
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.email == input);

            if (res == null)
            {

                output = "Client not found.";
                return false;
            }

            res.email = input01;

            Sqlite_User_Manager01.data01[0].Update(res);
            output = "API key updated successfully.";
            return true;
        }

        public bool user_login(string input, string input01, out string output)
        {
            int count = 0;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
                .FirstOrDefault(i => i.username == input);
            var res01 = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>()
            .FirstOrDefault(i => i.password == input01);
            if (res != null)
            {
                output = "corrct username";
                count++;

            }
            else
            {
                output = "incorrect username";
                count--;
            }
            if (res != null)
            {

                output = "correct password";
                count--;
            }
            else
            {
                output = "failed";
                count--;
            }
            if (count == 2)
            {
                output = "success";
                return true;
            }
            else
            {
                output = "please check errors";
                return false;
            }


        }
        public bool view_all_email(out string output)
        {
            output = string.Empty;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output += $"{a.email}\n";
            }
            return true;
        }
        public bool view_all_passwords(out string output)
        {
            output = string.Empty;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output += $"{a.password}\n";
            }
            return true;
        }
        public bool view_all_phonenumber(out string output)
        {
            output = string.Empty;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output += $"{a.phonenumber}\n";
            }
            return true;
        }
        public bool view_all_username(out string output)
        {
            output = string.Empty;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output += $"{a.username}\n";
            }
            return true;
        }
        public bool view_user_table(out string output)
        {
            output = string.Empty;
            var res = Sqlite_User_Manager01.data01[0].Table<Sqlite_User_Get_Model01>().ToList();
            foreach (var a in res)
            {
                output +=
         $"{a.username}\n" +
         $"{a.firstname}\n" +
         $"{a.lastname}\n" +
         $"{a.birthdate}\n" +
         $"{a.email}\n" +
         $"{a.phonenumber}\n" +
         $"{a.password}\n" +
         $"{a.longitude}\n" +
         $"{a.latitude}\n" +
         $"{a.creation_date}\n" +
         $"{a.text_file}\n" +
         $"{a.audio_file}\n" +
         $"{a.image_file}\n" +
         $"{a.video_file}\n" +
         $"{a.text_file_creation_date}\n" +
         $"{a.audio_file_creation_date}\n" +
         $"{a.image_file_creation_date}\n" +
         $"{a.video_file_creation_date}\n";

            }

            return true;

        }
        public bool view_user_database_storedprocedures(out string output)
        {
            output = $"delete_user_using_phonenumber\n" +
 $"delete_user_using_username\n" +
 $"find_email_using_email\n" +
 $"find_email_using_username\n" +
 $"find_password_using_email\n" +
 $"find_password_using_username\n" +
 $"find_phonenumber_using_email\n" +
 $"find_phonenumber_using_phonenumber\n" +
 $"find_phonenumber_using_username\n" +
 $"find_user_location_using_email\n" +
 $"find_user_location_using_username\n" +
 $"find_username_password\n" +
 $"find_username_using_email\n" +
 $"find_username_using_username\n" +
 $"find_usernmae_using_username\n" +
 $"insert_text_file_using_username\n" +
 $"insert_user\n" +
 $"insert_user_audio_file_using_username\n" +
 $"insert_user_text_file_using_username\n" +
 $"update_email_using_email\n" +
 $"update_email_using_username\n" +
 $"update_password_using_email\n" +
 $"update_password_using_phonenumber\n" +
 $"update_password_using_username\n" +
 $"update_phonenumber_using_email\n" +
 $"update_phonenumber_using_username\n" +
 $"update_user_location_using_email\n" +
 $"update_user_location_using_name\n" +
 $"update_user_location_using_phonenumber\n" +
 $"update_user_location_using_username\n" +
 $"update_username_using_email\n" +
 $"update_username_using_phonenumber\n" +
 $"update_username_using_username\n" +
 $"user_login\n" +
 $"view_all_emails\n" +
 $"view_all_passwords\n" +
 $"view_all_phonenumber\n" +
 $"view_all_username\n" +
 $"view_user_table\n"+
 $"auto insert user01\n";

            return true;
        }
    }
}