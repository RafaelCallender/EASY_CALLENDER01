
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_JOURNAL_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_JOURNAL_MODEL;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_JOURNAL_SERVICES
{
    public class Sqlite_Journal_Services01
    {

        private static string[] data01 = new string[100];


        public bool insert_journal(string input01, string input02, string input03,
                                               string input04,string input05,string input06,
                                                out string output)
        {

            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");

            if (Sqlite_Journal_Manager01.data01.Insert(
               new Sqlite_Journal_Model01
               {
                
                   username = input01,
                   upload = input02,
                   message = input03,
                   status = input04,
                   creation_date = data01,
                   error = input06,

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
        public bool find_message_using_message(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.message == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.message}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_message_using_upload(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.upload == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.message}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_message_using_username(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.username== input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.message}\n";
                return true;

            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_upload_using_message(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.message == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.upload}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_upload_using_upload(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.upload == input).FirstOrDefault();
            if (sqlcomm != null)
            {

                output = $"{sqlcomm.upload}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_upload_using_username(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {

                output = $"{sqlcomm.upload}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_username_using_message(string input, out string output)
        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.message == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.username}\n";
                return true;

            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_username_using_upload(string input, out string output)

        {



            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()

                .Where(i => i.upload == input).FirstOrDefault();

            if (sqlcomm != null)

            {

                output = $"{sqlcomm.username}\n";

                return true;



            }

            else

            {

                output = "Data not found";

                return false;

            }

        }
        public bool find_username_using_username(string input, out string output)

        {

            var sqlcomm = Sqlite_Journal_Manager01.data01.Table<Sqlite_Journal_Model01>()
                .Where(i => i.username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.username}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }



        }
        public bool view_journal_database_storedprocedures(out string output)
        {

            output = 

            $"find_email_using_email\n" +
$"find_message_using_message\n" +
$"find_message_using_upload\n" +
$"find_message_using_username\n" +
$"find_upload_using_message\n" +
$"find_upload_using_upload\n" +
$"find_upload_using_username\n" +
$"find_username_using_message\n" +
$"find_username_using_upload\n" +
$"find_username_using_username\n" +
$"insert_journal\n";
            return true;
        }

    }
}
