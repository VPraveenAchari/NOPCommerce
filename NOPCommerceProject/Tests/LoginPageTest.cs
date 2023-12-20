
using System.Configuration;
using System.Reflection.Metadata.Ecma335;
using NOPCommerceProject.PageObjects;
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;

namespace NOPCommerceProject.Tests
{
    public class LoginPageTest:BaseClass
    {
        IndexPage indexPage;
        LoginPage loginPage;
        HomePage homePage;
        string uname= ConfigurationManager.AppSettings["username"];
        string pass= ConfigurationManager.AppSettings["password"];
        [Test]
        public void LoginTest()
        {
            indexPage = new IndexPage(getDriver());
            loginPage=indexPage.ClickOnSignIn();
            homePage=loginPage.validLogin(uname, pass);
            string actualUrl=homePage.getCurrentUrl();
            string expectedUrl = "https://demo.nopcommerce.com/";
            Assert.AreEqual(actualUrl, expectedUrl);
            
            
            /* [Test]
            public void Login()
            {
                driver.FindElement(By.LinkText("Log in")).Click();
                driver.FindElement(By.Id("Email")).SendKeys("haribabu@gmail.com");
                driver.FindElement(By.Id("Password")).SendKeys("haribabu5060");
                driver.FindElement(By.XPath("//div[@class='buttons']/button[@type='submit']")).Click();
            }*/
        }

    }
}
