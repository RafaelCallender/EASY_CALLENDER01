
namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.WEB_TEMPLATE
{
    public class Web_Template01
    {
        private static Random rnd = new Random();
        private static string[] file_array =
{
               "~/css/site01.css",
               "~/css/site02.css",
               "~/css/site03.css",
};
        private enum file_index
        {
            site01 = 0,
            site02 = 1,
            site03 = 2,

        }
        private static string[] css01_string =
        {
            file_array[(int)file_index.site01],
            file_array[(int)file_index.site02],
            file_array[(int)file_index.site03],
        };

        public static string ccs01 = css01_string[(int)file_index.site02];
        public static string random_cccs01 = css01_string[rnd.Next(css01_string.Length)];

    }
}
