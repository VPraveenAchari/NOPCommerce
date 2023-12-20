
using System.Configuration;
using NOPCommerceProject.PageObjects;
using NOPCommerceProject.Utilities;

namespace NOPCommerceProject.Tests
{
    public class HomePageTest:BaseClass
    {
        IndexPage indexPage;
        LoginPage loginPage;
        HomePage homePage;
        string uname = ConfigurationManager.AppSettings["username"];
        string pass = ConfigurationManager.AppSettings["password"];
        [Test]
        public void wishListTest()
        {
            indexPage = new IndexPage(getDriver());
            loginPage = indexPage.ClickOnSignIn();
            homePage  = loginPage.validLogin(uname, pass);
            bool result=homePage.validateWishList();
            Assert.IsTrue(result);
        }
    }
}
