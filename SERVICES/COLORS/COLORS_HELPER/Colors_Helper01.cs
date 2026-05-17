using System.Drawing;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;

namespace EASY_CALLENDER01.SERVICES.COLORS.COLORS_HELPER
{
    public class Colors_Helper01
    {
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static string[] data01 = new string[100];
        public List<string> color_Name = new List<string>();
        public List<string> color_hex = new List<string>();
        public List<string> color_color_R = new List<string>();
        public List<string> color_G = new List<string>();
        public List<string> color_B = new List<string>();


        public Colors_Helper01()
        {
            get_Colors();

        }

        private void get_Colors()
        {

            foreach (System.Drawing.KnownColor knownColor in
                       Enum.GetValues(typeof(System.Drawing.KnownColor)))
            {
                System.Drawing.Color color =
                    System.Drawing.Color.FromKnownColor(knownColor);
                string hex = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

                color_Name.Add(color.Name);
                color_hex.Add(hex);
                color_color_R.Add(color.R.ToString());
                color_G.Add(color.G.ToString());
                color_B.Add(color.B.ToString());
            }
        }

    }
}