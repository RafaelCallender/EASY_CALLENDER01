using EASYPROJECT01.EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES;
using System.Threading.Tasks;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES
{
    public class Chemistry_Services02
    {
        private static string[] data01 = new string[100];
        private static Sql_Chemistry_Services01 Sql_Serv01 = new Sql_Chemistry_Services01();
        private static Chemistry_Get_Model01 Chemistry_Get_M01 = new Chemistry_Get_Model01();
        private static Chemistry_Helper01 Chemistry_H01 = new Chemistry_Helper01();
        public bool insert_element_using_sqlexpress(out string output)
        {
            string sqlExpressResult = " ";
            if (Chemistry_H01.atomic_number.Count != 0)
            {


                for (int i = 0; i < Chemistry_H01.atomic_number.Count; i++)
                {

                    bool result = Sql_Serv01.insert_element(
                   Chemistry_H01.atomic_number[i],
                    Chemistry_H01.element_name[i],
                    Chemistry_H01.element_symboles[i],
                    Chemistry_H01.atomic_mass[i],
                    Chemistry_H01.protons[i],
                    Chemistry_H01.electons[i],
                    Chemistry_H01.neutrons[i],
                        out sqlExpressResult
                    );
                    if (result == true)
                    {
                        output = sqlExpressResult;
                        return true;
                    }
                    else
                    {
                        output = sqlExpressResult;
                        return false;
                    }
                }
                Chemistry_Get_M01.SqlExpressOutString = sqlExpressResult;
            }
            else
            {
                output = "fail";
                return false;
            }

            output = " ";
            return true;

        }
        public bool insert_category_elements_using_sqlexpress(out string output)
        {
            string sqlExpressResult = "";
            string finalResult = "";

            int minCount = new[]
      {
                       Chemistry_H01.Alkali_Metals.Count,
                       Chemistry_H01.Alkaline_Earth_Metals.Count,
                        Chemistry_H01.Transition_Metals.Count,
                        Chemistry_H01.Lanthanides_Rare_Earth_Metals.Count,
                        Chemistry_H01.Actinides.Count,
                        Chemistry_H01.Noble_Gases.Count,
                        Chemistry_H01.Nonmetal_Gases_at_Room_Temperature.Count
                }.Min();



            if (minCount != 0)
            {
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
                            out sqlExpressResult);

                    if (result == true)
                    {
                        output = sqlExpressResult;
                        return true;
                    }
                    else
                    {
                        output = sqlExpressResult;
                        return false;
                    }

                }
                Chemistry_Get_M01.SqlExpressOutString = finalResult;
            }
            else
            {
                output = "fail";
                return false;
            }
            output = "success";
            return true;
        }

        public string find_element_using_sqlexpress(string input)
        {
            string atomic_number = "";
            string symbol = "";
            string name = "";
            string input_trimmed = input.Trim().ToLower();

            bool[] resuatls_array = { Sql_Serv01.find_element_using_atomic_number(input_trimmed, out atomic_number),
                                      Sql_Serv01.find_element_using_symbol(input_trimmed,out symbol),
                                      Sql_Serv01.find_element_using_name(input_trimmed,out name)
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
                if (Sql_Serv01.find_Alkali_Metals(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }


            }

            else if (input == 1)

            {
                if (Sql_Serv01.Find_Actinides(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }



            }

            else if (input == 2)

            {
                if (Sql_Serv01.find_Alkaline_Earth_Metals(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }


            }

            else if (input == 3)

            {
                if (Sql_Serv01.find_Lanthanides_Rare_Earth_Metals(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }


            }

            else if (input == 4)

            {

                if (Sql_Serv01.find_Noble_Gases(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }



            }

            else if (input == 5)

            {

                if (Sql_Serv01.find_Nonmetal_Gases_at_Room_Temperature(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }


            }

            else if (input == 6)

            {

                if (Sql_Serv01.find_Transition_Metals(out data01[50]) == true)
                {
                    return data01[50];
                }
                else
                {
                    return data01[50];
                }

            }

            else

            {

                return "IDK";

            }



        }

        public string view_all_elements_using_sqlexpress()
        {

            if (Sql_Serv01.view_all_elements(out data01[50]) == true)
            {
                return data01[50];
            }
            else
            {
                return data01[50];
            }
        }
    }
}