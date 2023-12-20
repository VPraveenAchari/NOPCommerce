using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class AccountCreationPage:BaseClass
    {
        
        public AccountCreationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='page-title']/h1")]
        public IWebElement formTitle;
        [FindsBy(How = How.XPath, Using = "//div[@id='gender']/span[1]/input")]
        public IWebElement gender;//male
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement firstname;
        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement lastname;
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email;
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement password;
        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement confirmPassword;
        [FindsBy(How = How.Id, Using = "register-button")]
        public IWebElement registerButton;
        public bool validateAccountCreatePage()
        {
            bool result = driver.FindElement(By.XPath("//div[@class='page-title']/h1")).Displayed;
            return result;
        }
    }
}
