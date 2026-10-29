using EASYPROJECT01.EASY_CALLENDER01.TEMPLATE.REGGEX_TEXT;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using Microsoft.Maui.Networking;
using System.Net.Http;
using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Media;
using Microsoft.Maui.Storage;
using System;
using System.Xml;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES
{
    public class Security_Services01
    {
        private static string[] data01 = new string[100];
        private int encryptionkey = 1;
        private string key = "MySecretKey123";
        private string key2 = "UltraKey";
        private static DateTime dateTime = DateTime.Now;
        public static string today_date = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        private static string[] dateformate01 = { "yyyy-MM-dd",
    "yyyy/MM/dd",
    "yyyyMMdd",
    "dd-MM-yyyy",
    "dd/MM/yyyy",
    "dd.MM.yyyy",
    "MM-dd-yyyy",
    "MM/dd/yyyy",
    "MM.dd.yyyy",
    "yyyy-MM-dd HH:mm:ss",
    "yyyy/MM/dd HH:mm:ss",
    "yyyy-MM-ddTHH:mm:ss",
    "yyyy-MM-ddTHH:mm:ssZ",
    "dd-MM-yyyy HH:mm:ss",
    "dd/MM/yyyy HH:mm:ss",
    "MM-dd-yyyy HH:mm:ss",
    "MM/dd/yyyy HH:mm:ss",
    "yyyy-MM-dd HH:mm:ss.fff",
    "yyyy-MM-ddTHH:mm:ss.fff",
    "dd MMM yyyy",
    "MMM dd, yyyy",
    "dddd, dd MMMM yyyy" };







        public bool empty_string(string input, out string output)
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
        private bool string_has_special_character(string input, out string output)
        {

            if (Regex.IsMatch(input, Reggex_Text01.Regex01[(int)Reggex_Text01.reggex_index.special_character_regex]))
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
        private bool string_has_uppercase_character(string input, out string output)
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
            if (string_has_special_character(input, out output) == true &&
                string_has_uppercase_character(input, out output) == true &&
                string_has_digit_character(input, out output) == true &&
                string_has_length(input, out output) == true)
            {
                output = string.Empty;
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool year_check(string input, out string output)
        {

            if (int.Parse(input) > 1955 && int.Parse(input) < 2026)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "input is out of scope";
                return false;
            }
        }
        public bool nba_team_check(string input, out string output)
        {

            if (int.Parse(input) > 30 &&
            int.Parse(input) < 1 == true)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "there are only up to 30 teams";
                return false;
            }


        }

        public bool age_check(string input, out string output)
        {
            DateTime dateTime = DateTime.Now;
            string current_year = dateTime.Year.ToString();
            string birth_year = DateTime.Parse(input.Trim()).Year.ToString();
            int age = int.Parse(current_year.Trim()) - int.Parse(birth_year.Trim());
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
            if (Regex.IsMatch(input, Reggex_Text01.Regex01[(int)Reggex_Text01.reggex_index.email_regex]) == true)
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
            if (Regex.IsMatch(input, Reggex_Text01.Regex01[(int)Reggex_Text01.reggex_index.phonenumber_regex]) == true)
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
            DateTime temp;
            bool isValid = false;
            string the_date = string.Join(" ", dateformate01);
            for (int i = 0; i < dateformate01.Length; i++)
            {
                isValid = DateTime.TryParseExact(
                       input,
                       dateformate01[i],
                       System.Globalization.CultureInfo.InvariantCulture,
                       System.Globalization.DateTimeStyles.None,
                       out temp
                   );

            }

            if (isValid == true)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = $"Date is not in correct format {the_date}. Please try again.";
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
        public bool isphoto(string input, out string output)
        {
            if (File.Exists(input))
            {
                string extension = Path.GetExtension(input).ToLower();
                if (File_Helper01.imageExtensions01.Contains(extension))
                {
                    output = string.Empty;
                    return true;
                }
                else
                {
                    output = "not an image file";
                    return false;
                }
            }
            else
            {
                output = "file does not exist";
                return false;
            }
        }
        public string[] generate_years()
        {
            string years = "";
            for (int i = 1955; i < 2026; i++)
            {
                years += $"{i}\n";

            }
            return years.Split('\n');
        }
        public bool isPicker_selected(Picker picker, out string output)
        {
            if (picker.SelectedIndex != -1)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "please select an item";
                return false;
            }
        }
        public bool isPicker_selected_web(string input, out string output)
        {
            if (input != null)
            {
                output = string.Empty;
                return true;
            }
            else
            {
                output = "please select an item";
                return false;

            }
        }

        public bool isPicker_selected_web(string? SelectedProject, string[] menu_array01, out string selectedMenu)
        {
            if (!int.TryParse(SelectedProject, out int selectedProjectIndex))
            {
                selectedMenu = "please select an item";
                return false;
            }

            selectedMenu = string.Empty;
            int menuIndex = selectedProjectIndex - 1;
            if (menuIndex < 0 || menuIndex >= menu_array01.Length)
            {
                selectedMenu = "please select an item";
                return false;
            }
            else
            {
                selectedMenu = menu_array01[menuIndex].Trim();
                return true;
            }


        }
        public bool is_connected_to_netwrok_windows(out string output)
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {

                output = string.Empty;
                return true;
            }
            else
            {
                output = "not connected to the internet";
                return false;
            }
        }
        public bool is_connected_to_netwrok_andriod(out string output)
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {

                output = string.Empty;
                return true;
            }
            else
            {
                output = "not connected to the internet";
                return false;
            }
        }

        public async Task<(bool success, string output)> is_connected_to_netwrok_linux()
        {
            try
            {
                using HttpClient client = new HttpClient();

                //    client.Timeout = TimeSpan.FromSeconds(3);

                using HttpResponseMessage response =
                    await client.GetAsync("https://www.google.com");
                //  response.IsSuccessStatusCode
                return (true, $" ");
            }
            catch
            {
                return (false, $"not connected to network:");
            }
        }
        public async Task<(bool success, string output)> andriod_take_photo()
        {
            if (!MediaPicker.Default.IsCaptureSupported)
            {
                return (false, "Camera capture is not supported");
            }

            try
            {
                PermissionStatus permissionStatus = await Permissions.RequestAsync<Permissions.Camera>();
                if (permissionStatus != PermissionStatus.Granted)
                {
                    return (false, "Camera permission is required to take a photo");
                }

                FileResult? photo = await MediaPicker.Default.CapturePhotoAsync();
                if (photo == null)
                {
                    return (false, "Photo capture was canceled");
                }

                return (true, await save_photo_to_cache(photo));
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }

        public async Task<(bool success, string output)> andriod_choose_photo()
        {
            try
            {
                FileResult? photo = await MediaPicker.Default.PickPhotoAsync();
                if (photo == null)
                {
                    return (false, "Photo selection was canceled");
                }

                return (true, await save_photo_to_cache(photo));
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }

        private static async Task<string> save_photo_to_cache(FileResult photo)
        {
            string extension = Path.GetExtension(photo.FileName);
            if (string.IsNullOrWhiteSpace(extension))
            {
                extension = ".jpg";
            }

            string filePath = Path.Combine(FileSystem.CacheDirectory, $"{Guid.NewGuid():N}{extension}");
            await using Stream source = await photo.OpenReadAsync();
            await using FileStream destination = File.Create(filePath);
            await source.CopyToAsync(destination);
            return filePath;
        }

    }
}