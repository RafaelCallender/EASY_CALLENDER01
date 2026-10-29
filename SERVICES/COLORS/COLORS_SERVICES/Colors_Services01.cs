using EASYPROJECT01.EASY_CALLENDER01.SERVICES.COLORS.COLORS_HELPER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.COLORS.COLORS_SERVICES
{
    public class Colors_Services01
    {
        private static Colors_Helper01 Colors_H01 = new Colors_Helper01();
        private static Random rnd = new Random();
        public string random_color_Name => Colors_H01.color_Name[rnd.Next(Colors_H01.color_Name.Count)];
        public string random_color_hex => Colors_H01.color_hex[rnd.Next(Colors_H01.color_hex.Count)];
        public string random_color_color_R => Colors_H01.color_color_R[rnd.Next(Colors_H01.color_color_R.Count)];
        public string random_color_G => Colors_H01.color_G[rnd.Next(Colors_H01.color_G.Count)];
        public string random_color_B => Colors_H01.color_B[rnd.Next(Colors_H01.color_B.Count)];
        public string all_color_name_string => string.Join("\n", Colors_H01.color_Name);
        public string all_color_hex_string => string.Join("\n", Colors_H01.color_hex);
    }
}
