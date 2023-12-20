

using NOPCommerceProject.PageObjects;
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;

namespace NOPCommerceProject.Tests
{
    public class IndexPageTest:BaseClass
    {
        IndexPage indexPage;
        //IndexPage indexPage = new IndexPage(getDriver());
        [Test]
        public void verifyLogo()
        {
            indexPage = new IndexPage(getDriver());
            bool result = indexPage.validateLogo(); ;
            Assert.IsTrue(result);
        }
        [Test]
        public void verifyTitle()
        {
            indexPage = new IndexPage(getDriver());
            string actualtitle=indexPage.GetTitle();
            TestContext.Progress.WriteLine(actualtitle);
            string expectedtitle= "nopCommerce demo store";
            Assert.AreEqual(actualtitle, expectedtitle);
        }
    }
}
