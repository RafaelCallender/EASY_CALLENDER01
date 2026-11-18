using EASYPROJECT01.EASY_CALLENDER01.SERVICES.COLORS.COLORS_HELPER;
namespace EASYPROJECT01.EASY_CALLENDER01.SERVICE.COLORS.COLORS_MANAGER
{
    public class Colors_Manager01
    {
        private static Colors_Helper01 Colors_H01 = new Colors_Helper01();
        public string all_color_name_string => string.Join("\n", Colors_H01.color_Name);
        public string all_color_hex_string => string.Join("\n", Colors_H01.color_hex);
        public string all_color_color_R => string.Join("\n", Colors_H01.color_color_R);
        public string all_color_G => string.Join("\n", Colors_H01.color_G);
        public string all_color_B => string.Join("\n", Colors_H01.color_B);


    }
}
