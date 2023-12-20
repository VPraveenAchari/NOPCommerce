
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class SearchResultPage:BaseClass
    {
        //div[@class='picture']/a/img
        public SearchResultPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='picture']/a/img")]
        public IWebElement productResult;
        public bool IsProductAvailable()
        {
            bool result = driver.FindElement(By.XPath("//div[@class='picture']/a/img")).Displayed;
            return result;
        }
        public AddtoCartPage ClickOnProduct()
        {
            driver.FindElement(By.XPath("//div[@class='picture']/a/img")).Click();
            return new AddtoCartPage();
        }
    }
}
