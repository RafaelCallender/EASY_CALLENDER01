using EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;




namespace EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES
{
    public class Chemistry_Services02
    {
        private static Sql_Chemistry_Services02 Sql_Serv02 = new Sql_Chemistry_Services02();
        private static Sql_Chemistry_Services01 Sql_Serv01 = new Sql_Chemistry_Services01();
        private static Chemistry_Get_Model01 Chemistry_Get_M01 = new Chemistry_Get_Model01();
       private static Chemistry_Helper01 Chemistry_H01 = new Chemistry_Helper01();
        public string insert_element_using_sqlexpress()
        {
            string sqlExpressResult = "";
    
            for (int i = 0; i < Chemistry_H01.atomic_number.Count; i++)
            {

                bool result  = Sql_Serv02.insert_element(
               Chemistry_H01.atomic_number[i],
                Chemistry_H01.element_name[i],
                Chemistry_H01.element_symboles[i],
                Chemistry_H01.atomic_mass[i],
                Chemistry_H01.protons[i],
                Chemistry_H01.electons[i],
                Chemistry_H01.neutrons[i],
                    out sqlExpressResult
                );
            }
            Chemistry_Get_M01.SqlExpressOutString = sqlExpressResult;

            return sqlExpressResult;


        }
        public string insert_category_elements_using_sqlexpress()
        {
            string sqlExpressResult = "";
            string finalResult = "";

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
                 bool result = Sql_Serv01.insert_element_category(
                         Chemistry_H01.Alkali_Metals[b],
                         Chemistry_H01.Alkaline_Earth_Metals[b],
                         Chemistry_H01.Transition_Metals[b],
                         Chemistry_H01.Lanthanides_Rare_Earth_Metals[b],
                         Chemistry_H01.Actinides[b],
                         Chemistry_H01.Noble_Gases[b],
                         Chemistry_H01.Nonmetal_Gases_at_Room_Temperature[b],
                         out sqlExpressResult

     );

   finalResult += sqlExpressResult + "\n";
            }
            Chemistry_Get_M01.SqlExpressOutString = finalResult;

            return finalResult;


        }

        public string find_element_using_sqlexpress(string input)
        {
            string atomic_number = "";
            string symbol = "";
            string name = "";
            string input_trimmed = input.Trim().ToLower();

            bool[] resuatls_array = { Sql_Serv02.find_element_using_atomic_number(input_trimmed, out atomic_number),
                                      Sql_Serv02.find_element_using_symbol(input_trimmed,out symbol),
                                      Sql_Serv02.find_element_using_name(input_trimmed,out name)
            };
            if (resuatls_array[0] == true)
            {
                return atomic_number;
            }
            else if (resuatls_array[1] == true)
            {
                return symbol;
            }
            else if (resuatls_array[2] == true)
            {
                return name;
            }
            else
            {
                return "failed";
            }

        }




        public async Task<string> find_category_elements_using_sqlexpress(int input)
        {

            if (input == 0)

            {

                return await Sql_Serv01.find_Alkali_Metals();

            }

            else if (input == 1)

            {

                return await Sql_Serv01.Find_Actinides();

            }

            else if (input == 2)

            {

                return await Sql_Serv01.find_Alkaline_Earth_Metals();

            }

            else if (input == 3)

            {

                return await Sql_Serv01.find_Lanthanides_Rare_Earth_Metals();

            }

            else if (input == 4)

            {

                return await Sql_Serv01.find_Noble_Gases();

            }

            else if (input == 5)

            {

                return await Sql_Serv01.find_Nonmetal_Gases_at_Room_Temperature();

            }

            else if (input == 6)

            {

                return await Sql_Serv01.find_Transition_Metals();

            }

            else

            {

                return "IDK";

            }



        }

        public async Task<string> view_all_elements_using_sqlexpress()

        {

            return "still working";

        }


    }
}