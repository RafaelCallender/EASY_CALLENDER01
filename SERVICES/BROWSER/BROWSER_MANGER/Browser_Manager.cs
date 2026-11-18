using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.BROWSER.BROWSER_HELPER;


namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.BROWSER.BROWSER_MANGER
{
    public class Browser_Manager
    {
        private static Browser_Helper Browser_H01 = new Browser_Helper();
        private static ChromeOptions options01 = new ChromeOptions();
        public static IWebDriver driver01 = new ChromeDriver(options01);
        public static string driver_string01=Browser_Helper.browser_url_array[(int)Browser_Helper.browser_url_index.turboscribe];



    }
}