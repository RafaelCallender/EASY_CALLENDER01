
namespace EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.REGGEX_TEXT
{
    public class Reggex_Text01
    {
        private static string[] Regex01_ = { @"[^a-zA-Z0-9]",//special character regex
                                             @"^[^@\s]+@[^@\s]+\.[^@\s]+$",//email regex
                                             @"^(?:\D*\d){10}\D*$"//phone number regex
        
        };

        public static string[] Regex01
        {
            get { return Regex01_; }
            set { Regex01_ = value; }
        }

        public enum reggex_index
        {
            special_character_regex = 0,
            email_regex = 1,
            phonenumber_regex = 2
        }

    }
}
