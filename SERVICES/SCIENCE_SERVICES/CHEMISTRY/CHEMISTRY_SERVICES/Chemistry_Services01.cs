using EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;

namespace EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES
{

  
    public class Chemistry_Services01
    {
    private static Chemistry_Helper01 Chemistry_H01=new Chemistry_Helper01();     
       public bool insert_element_using_textfiles()
        {


return false;

        }




public string find_element_using_textfile(string input)
        {

            int index = Chemistry_H01.element_name.IndexOf(input.ToLower());
            int index01 = Chemistry_H01.element_symboles.IndexOf(input.ToLower());
            if (index != -1)
            {
                return $"{Chemistry_H01.atomic_number[index]}\n" +
                           $"{Chemistry_H01.element_name[index]}\n" +
                           $"{Chemistry_H01.element_symboles[index]}\n" +
                           $"{Chemistry_H01.atomic_mass[index]}\n" +
                           $"{Chemistry_H01.electons[index]}\n" +
                           $"{Chemistry_H01.protons[index]}\n" +
                           $"{Chemistry_H01.neutrons[index]}\n";


                var collection_set = new Chemistry_Get_Model01
                {

                    atomic_number = Chemistry_H01.atomic_number[index],
                    element_name = Chemistry_H01.element_name[index],
                    element_symboles = Chemistry_H01.element_symboles[index],
                    atomic_mass = Chemistry_H01.atomic_mass[index],
                    electons = Chemistry_H01.electons[index],
                    protons = Chemistry_H01.protons[index],
                    neutrons = Chemistry_H01.neutrons[index],
                };

 

            }
            else if (index01 != -1)
            {
                return $"{Chemistry_H01.atomic_number[index01]}\n" +
                           $"{Chemistry_H01.element_name[index01]}\n" +
                           $"{Chemistry_H01.element_symboles[index01]}\n" +
                           $"{Chemistry_H01.atomic_mass[index01]}\n" +
                           $"{Chemistry_H01.electons[index01]}\n" +
                           $"{Chemistry_H01.protons[index01]}\n" +
                           $"{Chemistry_H01.neutrons[index01]}\n";


                var collection_set = new Chemistry_Get_Model01
                {

                    atomic_number = Chemistry_H01.atomic_number[index01],
                    element_name = Chemistry_H01.element_name[index01],
                    element_symboles = Chemistry_H01.element_symboles[index01],
                    atomic_mass = Chemistry_H01.atomic_mass[index01],
                    electons = Chemistry_H01.electons[index01],
                    protons = Chemistry_H01.protons[index01],
                    neutrons = Chemistry_H01.neutrons[index01],
                };

  

            }
            else if (int.TryParse(input, out int number))
            {
                index = Chemistry_H01.atomic_number.IndexOf(number);
                if (index >= 0 && index < Chemistry_H01.atomic_number.Count)
                {
                    return $"{Chemistry_H01.atomic_number[index]}\n" +
                                $"{Chemistry_H01.element_name[index]}\n" +
                                $"{Chemistry_H01.element_symboles[index]}\n" +
                                $"{Chemistry_H01.atomic_mass[index]}\n" +
                                $"{Chemistry_H01.electons[index]}\n" +
                                $"{Chemistry_H01.protons[index]}\n" +
                                $"{Chemistry_H01.neutrons[index]}\n";
                    var collection_set = new Chemistry_Get_Model01
                    {

                        atomic_number = Chemistry_H01.atomic_number[index],
                        element_name = Chemistry_H01.element_name[index],
                        element_symboles = Chemistry_H01.element_symboles[index],
                        atomic_mass = Chemistry_H01.atomic_mass[index],
                        electons = Chemistry_H01.electons[index],
                        protons = Chemistry_H01.protons[index],
                        neutrons = Chemistry_H01.neutrons[index],
                    };

                }
                else
                {
                      return "failed"; 
                }
            }
            else
            {
                return "failed";

            }

        }


        public string find_category_elements_using_textfile(int input)

        {



string res="";

            if (input == 0)

            {

                for (int i = 0; i < Chemistry_H01.Alkali_Metals.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Alkali_Metals[i],



                    };


                }



                foreach (var a in Chemistry_H01.Alkali_Metals)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }



            }

            else if (input == 1)

            {

                for (int i = 0; i < Chemistry_H01.Alkaline_Earth_Metals.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Alkaline_Earth_Metals[i],

                    };

           





                }

                foreach (var a in Chemistry_H01.Alkaline_Earth_Metals)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }





            else if (input == 2)

            {

                for (int i = 0; i < Chemistry_H01.Transition_Metals.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Transition_Metals[i],

                    };



           



                }

                foreach (var a in Chemistry_H01.Transition_Metals)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }

            else if (input == 3)

            {

                for (int i = 0; i < Chemistry_H01.Lanthanides_Rare_Earth_Metals.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Lanthanides_Rare_Earth_Metals[i],

                    };



     



                }

                foreach (var a in Chemistry_H01.Lanthanides_Rare_Earth_Metals)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }

            else if (input == 4)

            {

                for (int i = 0; i < Chemistry_H01.Noble_Gases.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Noble_Gases[i],

                    };





                }

                foreach (var a in Chemistry_H01.Noble_Gases)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }

            else if (input == 5)

            {

                for (int i = 0; i <Chemistry_H01.Actinides.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Actinides[i],

                    };





                }

                foreach (var a in Chemistry_H01.Actinides)

                {

                res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }

            else if (input == 6)

            {

                for (int i = 0; i < Chemistry_H01.Nonmetal_Gases_at_Room_Temperature.Count; i++)

                {

                    var collection_set = new Chemistry_Get_Model01

                    {

                        element_name = Chemistry_H01.Nonmetal_Gases_at_Room_Temperature[i],

                    };





                }

                foreach (var a in Chemistry_H01.Nonmetal_Gases_at_Room_Temperature)

                {



                    res += $"{a.Split('(')[0].Trim().ToLower()}\n";



                }

            }

            else

            {

            res = "IDK";

            }





            return res;

        }




     public string view_all_elements_using_textfile()
        {
string res="";     
            for (int i = 0; i < Chemistry_H01.atomic_number.Count; i++)
            {
                res += $"{Chemistry_H01.atomic_number[i]}\n" +
                             $"{Chemistry_H01.element_name[i]}\n" +
                             $"{Chemistry_H01.element_symboles[i]}\n" +
                             $"{Chemistry_H01.atomic_mass[i]}\n" +
                             $"{Chemistry_H01.electons[i]}\n" +
                            $"{Chemistry_H01.protons[i]}\n" +
                           $"{Chemistry_H01.neutrons[i]}\n";
                var collection_set = new Chemistry_Get_Model01
                {

                    atomic_number = Chemistry_H01.atomic_number[i],
                    element_name = Chemistry_H01.element_name[i],
                    element_symboles = Chemistry_H01.element_symboles[i],
                    atomic_mass = Chemistry_H01.atomic_mass[i],
                    electons = Chemistry_H01.electons[i],
                    protons = Chemistry_H01.protons[i],
                    neutrons = Chemistry_H01.neutrons[i],
                };

            }

            return res;
        }




     
    }
}