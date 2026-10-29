using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_UPLOAD_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_UPLOAD_MODEL;
using SQLite;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_UPLOAD_SERVICES
{
    public class Sqlite_Upload_Services01
    {

        private static string[] data01 = new string[100];


        public bool insert_data(string input01, string input02, string input03,
                                               string input04, string input05, string input06,
                                                out string output)
        {

            DateTime DateTimeNow = DateTime.Now;
            string data01 = DateTimeNow.ToString("yyyy-MM-dd HH:mm:ss");

            if (Sqlite_Upload_Manager01.data01.Insert(
               new Sqlite_Upload_Model01
               {

                   Username = input01,
                   OriginalName = input02,
                   StoredName = input03,
                   FilePath = input04,
                   ContentType = input05,
                   FileSize = input06,
                   UploadDate = data01,

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
        public bool find_username_using_username(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.Username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.Username}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }

        public bool delete_FilePath_using_FilePath(string input, out string output)
        {
            var res = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                        .FirstOrDefault(i => i.FilePath == input);

            if (res != null)
            {
                Sqlite_Upload_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }
        public bool delete_OriginalName_using_OriginalName(string input, out string output)
        {
            var res = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                        .FirstOrDefault(i => i.OriginalName == input);

            if (res != null)
            {
                Sqlite_Upload_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }
        public bool delete_StoredName_using_StoredName(string input, out string output)
        {
            var res = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                        .FirstOrDefault(i => i.StoredName == input);

            if (res != null)
            {
                Sqlite_Upload_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }
        public bool delete_Username_using_Username(string input, out string output)
        {
            var res = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                        .FirstOrDefault(i => i.Username == input);

            if (res != null)
            {
                Sqlite_Upload_Manager01.data01.Delete(res);
                output = "Client deleted successfully.";
                return true;
            }
            else
            {
                output = "Email address not found.";
                return false;

            }
        }
        public bool find_OriginalName_using_FilePath(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.FilePath == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.OriginalName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_OriginalName_using_OriginalName(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.OriginalName == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.OriginalName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_OriginalName_using_StoredName(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.StoredName == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.OriginalName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_OriginalName_using_Username(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.Username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.OriginalName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_StoredName_using_StoredName(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.StoredName == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.StoredName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_StoredName_using_Username(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.Username == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.StoredName}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_username_using_FilePath(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.FilePath == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.Username}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_username_using_OriginalName(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.OriginalName == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.Username}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }
        public bool find_username_using_StoredName(string input, out string output)
        {

            var sqlcomm = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                .Where(i => i.StoredName == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                output = $"{sqlcomm.Username}\n";
                return true;
            }
            else
            {
                output = "Data not found";
                return false;
            }
        }

        public bool update_OriginalName_using_OriginalName(string input, string input01, out string output)
        {
            var client = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                         .FirstOrDefault(i => i.OriginalName == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.OriginalName = input01;
            Sqlite_Upload_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_StoredName_using_StoredName(string input, string input01, out string output)
        {
            var client = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                         .FirstOrDefault(i => i.StoredName == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.StoredName = input01;
            Sqlite_Upload_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }
        public bool update_username_using_username(string input, string input01, out string output)
        {
            var client = Sqlite_Upload_Manager01.data01.Table<Sqlite_Upload_Model01>()
                         .FirstOrDefault(i => i.Username == input);

            if (client == null)
            {
                output = "Client not found.";
                return true;

            }

            client.Username = input01;
            Sqlite_Upload_Manager01.data01.Update(client);
            output = "API key updated successfully.";
            return true;
        }

        public bool view_database_storedprocedures(out string output)
        {
            output = $"insert_data\n" +
     $"delete_FilePath_using_FilePath\n" +
$"delete_OriginalName_using_OriginalName\n" +
$"delete_StoredName_using_StoredName\n" +
$"delete_Username_using_Username\n" +
$"find_OriginalName_using_FilePath\n" +
$"find_OriginalName_using_OriginalName\n" +
$"find_OriginalName_using_StoredName\n" +
$"find_OriginalName_using_Username\n" +
$"find_StoredName_using_StoredName\n" +
$"find_StoredName_using_Username\n" +
$"find_username_using_FilePath\n" +
$"find_username_using_OriginalName\n" +
$"find_username_using_StoredName\n" +
$"find_username_using_username\n" +
$"update_OriginalName_using_OriginalName\n" +
$"update_StoredName_using_StoredName\n" +
$"update_username_using_username\n";
            return true;
        }
    }
}