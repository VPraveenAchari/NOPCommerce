
using NOPCommerceProject.PageObjects;
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;

namespace NOPCommerceProject.Tests
{
    public class AccountCreationPageTest:BaseClass
    {
        IndexPage indexPage;
        LoginPage loginPage;
        HomePage homePage;
        AccountCreationPage accountCreationPage;
        [Test]
        public void VerifyCreateAccountPage()
        {
            indexPage = new IndexPage(getDriver());
            loginPage = indexPage.ClickOnRegister();
            Thread.Sleep(3000);
            accountCreationPage=loginPage.createNewAccount("ravi","krishna","ravikrishna@gmail.com","ravi12345","ravi12345");
            Thread.Sleep(3000);
            bool result=accountCreationPage.validateAccountCreatePage();
            Assert.IsTrue(result);
        }
    }
}
