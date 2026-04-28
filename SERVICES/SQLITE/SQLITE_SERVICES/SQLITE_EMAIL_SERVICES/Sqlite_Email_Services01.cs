using EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_EMAIL_MODEL;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_EMAIL_MANAGER;



namespace EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_EMAIL_SERVICES
{
    public class Sqlite_Email_Services01
    {

        private static string[] data01 = new string[100];

       
        public bool insert_email(string input01, string input02, string input03,
                                               string input04, out string output)
        {

            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");

            if (Sqlite_Email_Manager01.data01.Insert(
               new Sqlite_Email_Model01
               {
                   full_name = input01,
                   email = input03,
                   email_creation_date = data01,
                   phone_number = input04

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
        public bool find_email_using_name(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.email}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_email_using_phonenumber(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.phone_number == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.email}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_full_name_using_phonenumber(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.phone_number == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.full_name}\n";
                return true;

            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_full_name_using_email(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.full_name}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_full_name_using_full_name(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {

                output = $"{sqlcomm.full_name}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_phonenumber_using_phonenumber(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.phone_number == input).FirstOrDefault();
            if (sqlcomm != null)
            {

                output = $"{sqlcomm.phone_number}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_email_using_email(string input, out string output)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.email}\n";
                return true;

            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_phonenumber_using_email(string input, out string output)

        {



            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()

                .Where(i => i.email == input).FirstOrDefault();

            if (sqlcomm != null)

            {

                output = $"{sqlcomm.phone_number}\n";

                return true;



            }

            else

            {

                output = "Data not found";

                return false;

            }

        }
        public bool find_phonenumber_using_fullname(string input, out string output)

        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.phone_number}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }



        }


    }
}
