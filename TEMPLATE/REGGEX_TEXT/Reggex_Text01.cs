namespace EASY_CALLENDER01.TEMPLATE.REGGEX_TEXT
{
    public class Reggex_Text01
    {
        private static string[] Regex01_ = { @"[^a-zA-Z0-9]",//special character regex
                                             @"^[^@\s]+@[^@\s]+\.[^@\s]+$",//email regex
                                             @"^\+?\d{1,3}?[\s.-]?\(?\d{1,4}\)?([\s.-]?\d{1,4}){2,3}$"//phone number regex
        
        };

        public static string[] Regex01
        {
            get { return Regex01_; }
            set { Regex01_ = value; }
        }
        public static string SpecialCharacterRegex()
        {
            return Regex01_[0];
        }       
    }
}
