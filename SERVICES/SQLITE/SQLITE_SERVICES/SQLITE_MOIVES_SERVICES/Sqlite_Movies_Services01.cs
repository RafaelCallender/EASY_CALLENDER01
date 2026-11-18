using EASYPROJECT01.EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_MOVIES_MODEL.SQLITE_MOVIES_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQSLITE_MOVIES_MANAGER;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_MOIVES_SERVICES
{
    public class Sqlite_Movies_Services01
    {
        private static string[] data01 = new string[100];
     

        public async Task<(bool sucess,string output)> insert_movies(string input01, string input02)
        {
            var existing = Sqlite_Movies_Manager01.data01
.Table<Sqlite_Movies_Get_Model01>()
.FirstOrDefault(x => x.file_location == input01);

            if (existing != null)
            {
                return (true, "Data already exists");
            }
            else
            {
                if (Sqlite_Movies_Manager01.data01.Insert(
                    new Sqlite_Movies_Get_Model01
                    {
                        file_location = input01,
                        file_name = input02

                    }) > 0)
                {
                    return (true, "Data Inserted Successfully");
                   
             
                }
                else
                {
         
                    return (false, "Data Insertion Failed");
                }
            }

        }
        public async Task<(bool sucess, string output)> find_location_using_file_name(string input)
        {

            var data02 = Sqlite_Movies_Manager01.data01.Table<Sqlite_Movies_Get_Model01>()
                .Where(i => i.file_location == input).FirstOrDefault();
            if (data02 != null)
            {
          

                return (true, $"{data02.file_location}\n");
            }
            else
            {
                return (true, "Data Not Found");
            }
        }

        public async Task<(bool sucess, string output)> find_name_using_file_loaction(string input)
        {

            var data02 = Sqlite_Movies_Manager01.data01.Table<Sqlite_Movies_Get_Model01>()
                .Where(i => i.file_location == input).FirstOrDefault();
            if (data02 != null)
            {
              

                return (true, $"{data02.file_location}\n");
            }
            else
            {
        
                return (true, "Data Not Found");
            }
        }

        public async Task<string> view_all_movies_using_sql()
        {

            var data05 = Sqlite_Movies_Manager01.data01.Table<Sqlite_Movies_Get_Model01>().ToList();
            foreach (var a in data05)
            {
                data01[3] += $"{a.Id}\n" +
                             $"{a.file_location}\n" +
                             $"{a.file_name}\n";
                     
            }
            return data01[3];
        }

    }
}
