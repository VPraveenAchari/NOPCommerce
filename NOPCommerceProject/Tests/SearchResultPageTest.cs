using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOPCommerceProject.PageObjects;
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.Tests
{
    public class SearchResultPageTest:BaseClass
    {
        IndexPage indexPage;
        SearchResultPage searchResultPage;
        [Test]
        public void productAvailabilityTest()
        {
            indexPage= new IndexPage(getDriver());
            searchResultPage=indexPage.SearchProduct("hat");
            Thread.Sleep(3000);
            bool result = searchResultPage.IsProductAvailable();
            Assert.IsTrue(result);
        }
    }
}
