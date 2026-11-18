using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.BROWSER.BROWSER_MANGER;

namespace EASYPROJECT01.EASY_CALLENDER01.SERVICES.BROWSER.BROWSER_SERVICE
{
    public class Browser_Service
    {

        private static Browser_Manager Browser_M01 = new Browser_Manager();
        private static string[] data01 = new string[100];
        public bool google_search_selenium01(out string output)
        {
            try
            {
                // Open Google
                Browser_Manager.driver01.Navigate().GoToUrl(Browser_Manager.driver_string01);
                // Find Google's search input
                IWebElement searchBox = Browser_Manager.driver01.FindElement(By.Name("q"));
                // Type the search term

                // Press Enter
                searchBox.SendKeys(Keys.Enter);
                output = Browser_Manager.driver_string01;
                return true;
            }
            catch (Exception ex)
            {
                output = ex.Message;
                return true;
            }
        }
        public void google_search_selenium02(string searchText)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();

                using IWebDriver driver = new ChromeDriver(options);

                // Set maximum page load time
                driver.Manage().Timeouts().PageLoad =
                    TimeSpan.FromSeconds(30);

                // Open Google
                driver.Navigate().GoToUrl("https://www.google.com");

                // Wait for Google's search box to become available
                WebDriverWait wait = new WebDriverWait(
                    driver, TimeSpan.FromSeconds(15));

                IWebElement searchBox = wait.Until(d =>
                {
                    IWebElement element = d.FindElement(By.Name("q"));

                    return element.Displayed && element.Enabled
                        ? element
                        : null;
                });

                // Type search text
                searchBox.SendKeys(searchText);

                // Press Enter
                searchBox.SendKeys(Keys.Enter);

                // Wait for Google search results to load
                wait.Until(d =>
                    d.FindElements(By.Id("search")).Count > 0
                );

                Console.WriteLine("Google search completed.");
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Page loading timed out: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void click_button02()
        {
            ChromeOptions options = new ChromeOptions();

            using IWebDriver driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("https://example.com");

            WebDriverWait wait = new WebDriverWait(
                driver, TimeSpan.FromSeconds(10));

            IWebElement button = wait.Until(d =>
            {
                IWebElement element = d.FindElement(By.Id("submitButton"));

                return element.Displayed && element.Enabled
                    ? element
                    : null;
            });

            button.Click();
        }
        public void copy_url()
        {
            ChromeOptions options = new ChromeOptions();

            using IWebDriver driver = new ChromeDriver(options);
            // Navigate to Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Search for dogs
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            searchBox.SendKeys("dogs");
            searchBox.SendKeys(Keys.Enter);

            // Wait for search results
            WebDriverWait wait = new WebDriverWait(
                driver, TimeSpan.FromSeconds(15));

            wait.Until(d => d.FindElements(By.Id("search")).Count > 0);

            // Get current page URL
            string currentUrl = driver.Url;

            Console.WriteLine(currentUrl);
        }
        public Task copy_url01()
        {
            ChromeOptions options = new ChromeOptions();

            using IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("dogs");
            searchBox.SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(
                driver, TimeSpan.FromSeconds(15));

            wait.Until(d => d.FindElements(By.Id("search")).Count > 0);

            string currentUrl = driver.Url;
            IWebElement firstResult = wait.Until(d =>
                d.FindElement(By.CssSelector("#search a")));

            firstResult.Click();

            wait.Until(d => d.Url != currentUrl);

            string nextPageUrl = driver.Url;

            Console.WriteLine(nextPageUrl);
            return Task.CompletedTask;
        }

    }

}
