using EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;

namespace EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES
{

    public class Chemistry_Services03
    {
  private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sqlite_Chemistry_Services01 Sqlite_Serv01 = new Sqlite_Chemistry_Services01();
        private static Sqlite_Chemistry_Services02 Sqlite_Serv02 = new Sqlite_Chemistry_Services02();
private static Chemistry_Helper01 Chemistry_H01=new Chemistry_Helper01();

private static  Chemistry_Get_Model01 Chemistry_Get_M01=new Chemistry_Get_Model01();    

  public string[] data_array = {"Alkali Metals",//0
                                      "Alkaline Earth Metals",//1
                                      "Transition Metals",//2
                                      "Lanthanides Rare Earth Metals",//3
                                      "Noble Gases",//4
                                      "Actinides",//5
                                      "Nonmetal Gases at Room Temperature"//6
                                      };
       public async Task<bool> insert_element_using_sqlite()
{
    (bool sucess, string output) result = (false, string.Empty);

    for (int i = 0; i < Chemistry_H01.atomic_number.Count; i++)
    {
        result = await Sqlite_Serv02.insert_element(
            Chemistry_H01.atomic_number[i],
            Chemistry_H01.element_name[i],
            Chemistry_H01.element_symboles[i],
            Chemistry_H01.atomic_mass[i],
            Chemistry_H01.protons[i],
            Chemistry_H01.electons[i],
            Chemistry_H01.neutrons[i]);

        Chemistry_Get_M01.SqliteOutString = result.output;
    }

    return result.sucess;
}


        public async Task<string> find_element_using_sqlite(string input)

        {

         string res="";

            if (Security_Serv01.string_only_digit(input,out res) == true)

            {

         

                int atomic_number = int.Parse(input);

                var atomic_number_result = await Sqlite_Serv02.find_element_using_atomic_number(atomic_number);

                if (atomic_number_result.sucess == true)

                {

                    return atomic_number_result.output;

                }

                else

                {

                     return atomic_number_result.output;

                }



            }

            else

            {

                string input_trimmed = input.Trim().ToLower();

                var symbol_result = await Sqlite_Serv02.find_element_using_symbol(input_trimmed);

                var name_result = await Sqlite_Serv02.find_element_using_name(input_trimmed);

                if (symbol_result.sucess == true)

                {

                    return  symbol_result.output;

                }

                else if (name_result.sucess == true)

                {

                    return name_result.output;

                }

                else

                {

                    return "failed";

                }

            }



        }

    

        public async Task<string> find_category_elements_using_sqlite(int input)

        {

            var number01 = await Sqlite_Serv01.find_Alkali_Metals(data_array[input]);

            var number02 = await Sqlite_Serv01.Find_Actinides(data_array[input]);

            var number03 = await Sqlite_Serv01.find_Alkaline_Earth_Metals(data_array[input]);

            var number04 = await Sqlite_Serv01.find_Lanthanides_Rare_Earth_Metals(data_array[input]);

            var number05 = await Sqlite_Serv01.find_Noble_Gases(data_array[input]);

            var number06 = await Sqlite_Serv01.find_Nonmetal_Gases_at_Room_Temperature(data_array[input]);

            var number07 = await Sqlite_Serv01.find_Nonmetal_Gases_at_Room_Temperature(data_array[input]);



            if (number01.sucess == true)

            {

                return number01.output;



            }

            else if (number02.sucess == true)

            {

                return number02.output;

            }

            else if (number03.sucess == true)

            {

                return number03.output;

            }

            else if (number04.sucess == true)

            {

                return number04.output;

            }

            else if (number05.sucess == true)

            {

                return number05.output;

            }

            else if (number06.sucess == true)

            {

                return number06.output;

            }

            else if (number07.sucess == true)

            {

                return number07.output;

            }

            else

            {

                return "IDK";

            }





        }


 public async Task<string> view_all_elements_using_sqlite()

 {


   var all_elements= await Sqlite_Serv02.view_all_elements();

            return all_elements.output;

    
 }

     
    }
}