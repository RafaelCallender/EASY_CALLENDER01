using EASY_CALLENDER01.MODEL.SCIENCE_MODEL.CHEMISTRY_MODEL.CHEMISTRY_GET_MODEL;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_CHEMISTRY_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using System.Threading.Tasks;
using EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES;


namespace EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER
{
    public class Chemistry_Helper01
    {
        
        public List<int> atomic_number = new List<int>();
        public List<string> element_name = new List<string>();
        public List<string> element_symboles = new List<string>();
        public List<double> atomic_mass = new List<double>();
        public List<string> Alkali_Metals = new List<string>();
        public List<string> Alkaline_Earth_Metals = new List<string>();
        public List<string> Transition_Metals = new List<string>();
        public List<string> Lanthanides_Rare_Earth_Metals = new List<string>();
        public List<string> Noble_Gases = new List<string>();
        public List<string> Actinides = new List<string>();
        public List<string> Nonmetal_Gases_at_Room_Temperature = new List<string>();
        public List<int> protons = new List<int>();
        public List<int> electons = new List<int>();
        public List<int> neutrons = new List<int>();      
        public static Read_Textfiles READ = new Read_Textfiles();
                public string[] data_array = {"Alkali Metals",//0
                                      "Alkaline Earth Metals",//1
                                      "Transition Metals",//2
                                      "Lanthanides Rare Earth Metals",//3
                                      "Noble Gases",//4
                                      "Actinides",//5
                                      "Nonmetal Gases at Room Temperature"//6
                                 }; 
 
public Chemistry_Helper01()
        {
                


var cleanedElements = READ.Chemistry
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim())
                .ToList();
            int count = 0;

            for (int i = 0; i < cleanedElements.Count; i++)
            {
                if (i % 3 == 0)
                {
                    count++;

                    atomic_number.Add(count);
                    protons.Add(count);
                    electons.Add(count);
                    element_name.Add(cleanedElements[i].ToLower());
                }
                else if (i % 3 == 1)
                {
                    element_symboles.Add(cleanedElements[i].ToLower());
                }
                else if (i % 3 == 2)
                {
                    string massString = cleanedElements[i]
                        .Replace("[", "")
                        .Replace("]", "")
                        .Replace(",", ".")
                        .Trim();
                    atomic_mass.Add(double.Parse(massString));
                    if (double.TryParse(massString, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double mass))
                    {
                        int roundedMass = (int)Math.Round(mass);
                        int neutronCount = Math.Max(0, roundedMass - count);
                        neutrons.Add(neutronCount);
                    }
                        else
                    {

                        neutrons.Add(0);
                    }
                }
            }
        }

    }
}
    