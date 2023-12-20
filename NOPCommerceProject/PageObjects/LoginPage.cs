
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class LoginPage:BaseClass
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       /* public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }*/
        [FindsBy(How = How.LinkText, Using = "Log in")]
        private IWebElement login;
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//div[@class='buttons']/button[@type='submit']")]
        private IWebElement loginButton;
        [FindsBy(How = How.ClassName,Using = "ico-register")]
        private IWebElement registerButton;

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement firstname;
        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement lastname;
        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement email;
        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement createPassword;
        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement confirmPassword;
        [FindsBy(How = How.Id, Using = "register-button")]
        public IWebElement accountCreationButton;
        public IWebElement GetLogIn() { return login; }
        public IWebElement GetUsername() { return username; }
        public IWebElement GetPassword() { return password; }
        public IWebElement GetLoginButton() { return loginButton; }
        public IWebElement GetRegisterButton() { return registerButton; }
        public HomePage validLogin(string user,string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginButton.Click();
            return new HomePage(getDriver());
        }
        public AddressPage validLogin1(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginButton.Click();
            return new AddressPage();
        }
        public AccountCreationPage createNewAccount(string fname,string lname,string newEmail, string CPass, string CFPass)
        {
            firstname.SendKeys(fname);
            lastname.SendKeys(lname);
            username.SendKeys(newEmail);
            password.SendKeys(CPass);
            confirmPassword.SendKeys(CFPass);
            accountCreationButton.Click();
            return new AccountCreationPage(getDriver());
        }
    }
}
