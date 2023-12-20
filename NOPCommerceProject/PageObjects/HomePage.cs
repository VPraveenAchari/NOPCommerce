using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class HomePage:BaseClass
    {
        public HomePage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public string getCurrentUrl()
        {
            string homepageurl=driver.Url;
            return homepageurl;
        }
        public bool validateWishList()
        {
            bool wishlist = driver.FindElement(By.XPath("//span[@class='wishlist-label']")).Displayed;
            return wishlist;
        }
    }
}
