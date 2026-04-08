using EASY_CALLENDER01.TEMPLATE.REGGEX_TEXT;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace EASY_CALLENDER01.SERVICES.SECURITY_SERVICES
{
    public class Security_Services01
    {
        private static string[] data01 = new string[100];
        private int encryptionkey = 1;
        private string key = "MySecretKey123";
        private string key2 = "UltraKey";

        public bool empty_string(string input,out string output)
        {
            if (input != string.Empty &&
                input != " " &&
                !string.IsNullOrEmpty(input) &&
               input != "" &&
               !string.IsNullOrWhiteSpace(input))
            {
                output = string.Empty;          
                return true;
            }
            else
            {
                output = "entry can not be empty";
                return false;
            }
        }
        public bool string_only_digit(string input, out string output)
        {
            if (input.All(char.IsDigit))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "only digits";
                return false;
            }
        }
        private bool string_has_special_character(string input,out string output)
        {

            if (Regex.IsMatch(input, Reggex_Text01.Regex01[0]))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "need special character";
                return false;
            }
        }
        private bool string_has_uppercase_character(string input,out string output)
        {
            if (input.Any(char.IsUpper))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "entry needs a uppcase character";
                return false;
            }
        }
        private bool string_has_digit_character(string input, out string output)
        {
            if (input.Any(char.IsDigit))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "entry needs a digit";
                return false;
            }
        }
        private bool string_has_length(string input, out string output)
        {
            int length = 15;
            if (input.Length >= length)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "entry needs 15 characters";
                return false;
            }
        }
        public bool password_check(string input, out string output)
        {
            if (string_has_special_character(input,out output) == true &&
                string_has_uppercase_character(input, out output) == true &&
                string_has_digit_character(input, out output) == true &&
                string_has_length(input,out output) == true)
            {
                output=string.Empty;        
                return true;
            }
            else
            {
                output = "entry needs attention";
                return false;
            }
        }
        public bool age_check(string input, out string output)
        {
            DateTime dateTime = DateTime.Now;
            int current_year = dateTime.Year;
            int birth_year = int.Parse(input);
            int age = current_year - birth_year;
            if (age >= 18)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "not 18 years or older";
                return false;

            }
        }
        public bool email_check(string input, out string output)
        {
            if (Regex.IsMatch(input, Reggex_Text01.Regex01[1]))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "email not correct format";
                return false;
            }
        }
        public bool phone_check(string input, out string output)
        {
            if (Regex.IsMatch(input, Reggex_Text01.Regex01[2]))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "phonenumber not correct format";
                return false;
            }

        }
        public bool date_check(string input, out string output)
        {
            //any date formate
            DateTime temp;
            if (DateTime.TryParse(input, out temp))
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "date not correct format";
                return false;
            }
        }    
        public string encrypt_text_file(string input)
        {

            char[] shiftedChars = new char[input.Length];

            int index = 0;

            foreach (char c in input)
            {
                shiftedChars[index] = (char)(c + encryptionkey);
                index++;
            }

            return new string(shiftedChars);
        }


        public string decrypt_text_file(string input)
        {


            char[] shiftedChars = new char[input.Length];

            int index = 0;

            foreach (char c in input)
            {
                shiftedChars[index] = (char)(c - encryptionkey);
                index++;
            }

            return new string(shiftedChars);
        } 
       public string Position_Based_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamicKey = encryptionkey + (i % 7); // key changes every char
                result[i] = (char)(input[i] + dynamicKey);
            }

            return new string(result);
        }
        public string Position_Based_Deccryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamicKey = encryptionkey + (i % 7);
                result[i] = (char)(input[i] - dynamicKey);
            }

            return new string(result);
        }
        public string XOR_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] ^ key[i % key.Length]);
            }

            return new string(result);
        }
        public string XOR_Decryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = (char)(input[i] ^ key[i % key.Length]);
            }

            return new string(result);
        }
        public string Shift_XOR_Position_Encryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int dynamic = encryptionkey + (i % 5);
                char shifted = (char)(input[i] + dynamic);
                result[i] = (char)(shifted ^ key2[i % key2.Length]);
            }

            return new string(result);
        }

        public string Shift_XOR_Position_Decryption(string input)
        {
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char unXor = (char)(input[i] ^ key2[i % key2.Length]);
                int dynamic = encryptionkey + (i % 5);
                result[i] = (char)(unXor - dynamic);
            }

            return new string(result);
        }
    }
}