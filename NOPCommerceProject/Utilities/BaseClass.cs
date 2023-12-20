using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NOPCommerceProject.Utilities
{
    public class BaseClass
    {
        public IWebDriver driver;
        String browserName, username, password;
        [SetUp]
        public void StartBrowser()
        {
            browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Url = ConfigurationManager.AppSettings["url"];
            
        }
       
        public IWebDriver getDriver()
        {
            return driver;
        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }
        [TearDown]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
