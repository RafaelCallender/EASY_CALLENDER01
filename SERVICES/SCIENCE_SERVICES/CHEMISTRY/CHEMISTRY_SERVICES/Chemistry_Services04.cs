using EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;
using EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES;

namespace EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES
{
    public class Chemistry_Services04
    {
private static  Chemistry_Get_Model01 Chemistry_Get_M01=new Chemistry_Get_Model01();  
private static Chemistry_Helper01 Chemistry_H01=new Chemistry_Helper01();

private static MySql_Chemistry_Services02 MySql_Chemistry_S02=new MySql_Chemistry_Services02();     

private static MySql_Chemistry_Services01 MySql_Chemistry_S01=new MySql_Chemistry_Services01();                

              public bool insert_element_using_mysql()
        {
           string MysqlResult="";
bool result = false;     


      for (int i = 0; i < Chemistry_H01.atomic_number.Count; i++)
                        {
                                

 result = MySql_Chemistry_S02.insert_element(
                        Chemistry_H01.atomic_number[i],
                        Chemistry_H01.element_name[i],
                        Chemistry_H01.element_symboles[i],
                        Chemistry_H01.atomic_mass[i],
                        Chemistry_H01.protons[i],
                        Chemistry_H01.electons[i],
                        Chemistry_H01.neutrons[i],
                        out MysqlResult);

                        }

 Chemistry_Get_M01.MySqlOutString=MysqlResult;
return          result;                      

        }

public bool insert_category_elements_using_mysql()
        {
                   string MysqlResult="";
bool result = false;     
            int minCount = new[]
      { Chemistry_H01.Alkali_Metals.Count,
                      Chemistry_H01.Alkaline_Earth_Metals.Count,
                        Chemistry_H01.Transition_Metals.Count,
                        Chemistry_H01.Lanthanides_Rare_Earth_Metals.Count,
                        Chemistry_H01.Actinides.Count,
                        Chemistry_H01.Noble_Gases.Count,
                        Chemistry_H01.Nonmetal_Gases_at_Room_Temperature.Count
                }.Min();
            for (int b = 0; b < minCount; b++)
            {
             result =  MySql_Chemistry_S01.insert_element_category(
                    Chemistry_H01.Alkaline_Earth_Metals[b],
                    Chemistry_H01.Alkaline_Earth_Metals[b],
                    Chemistry_H01.Transition_Metals[b],
                    Chemistry_H01.Lanthanides_Rare_Earth_Metals[b],
                    Chemistry_H01.Actinides[b],
                    Chemistry_H01.Noble_Gases[b],
                    Chemistry_H01.Nonmetal_Gases_at_Room_Temperature[b],
                        out MysqlResult);

                        }

 Chemistry_Get_M01.MySqlOutString=MysqlResult;
return          result;                      

        }



        public string find_element_using_mysql(string input)
        {
            
return "working on it";

        }




        public async Task<string> find_category_elements_using_mysql(int input)
        {
            
return "working on it";


        }

 public async Task<string> view_all_elements_using_mysql()

 {



return "working on it";


    
 }

     
    }
}