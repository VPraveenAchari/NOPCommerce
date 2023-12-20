using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class IndexPage:BaseClass
    {
        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        /*  public IndexPage()
          {
              PageFactory.InitElements(driver, this);
          }*/
        [FindsBy(How = How.LinkText,Using ="Log in")]
        private IWebElement login;
       
        [FindsBy(How = How.XPath,Using = "//div[@class='buttons']/button[@type='submit']")]
        private IWebElement loginButton;
        [FindsBy(How = How.XPath,Using = "//div[@class='header-logo']/a/img")]
        private IWebElement nopCommerce;
        [FindsBy(How = How.XPath,Using = "//input[@name='q']")]
        private IWebElement searchBox;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;

        public IWebElement GetLogin() { return login; } 
        public IWebElement GetLoginButton() { return loginButton; } 
        public IWebElement GetSearchBox() { return searchBox; } 
        public IWebElement GetSearchButton() { return searchButton; } 

        public LoginPage ClickOnSignIn()
        {
            driver.FindElement(By.LinkText("Log in")).Click();
            return new LoginPage(getDriver());
        }
        public LoginPage ClickOnRegister()
        {
            driver.FindElement(By.LinkText("Register")).Click();
            return new LoginPage(getDriver());
        }
        public bool validateLogo()
        {
            bool logo = driver.FindElement(By.XPath("//div[@class='header-logo']/a/img")).Displayed;
            return logo;
        }
        public string GetTitle()
        {
           string nopCommerceTitle=driver.Title;
           return nopCommerceTitle;
        }
        //public SearchResultPage searchProduct(String productName)
        public SearchResultPage SearchProduct(string productName)
        {
            //searchBox.SendKeys("Nokia Lumia 1020");
            searchBox.SendKeys(productName);
            searchButton.Click();
            return new SearchResultPage(getDriver());
        }
       
    }
}
