
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class AddtoCartPage:BaseClass
    {
        public AddtoCartPage()
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='add-to-cart-panel']/input")]
        public IWebElement quantity; 
        [FindsBy(How = How.XPath, Using = "//div[@class='page-title']/h1")]
        public IWebElement size;
        [FindsBy(How = How.XPath, Using = "//button[@id='add-to-cart-button-31']")]
        public IWebElement addtoCartButton; 
        [FindsBy(How = How.XPath, Using = "product_attribute_13")]
        public IWebElement dropdown;  
        [FindsBy(How = How.XPath, Using = "//p[@class='content']")]
        public IWebElement addToCartMessage;
        [FindsBy(How = How.XPath, Using = "//span[contins(text(),'Shopping cart']")]
        public IWebElement shoppingCart; 

       // public void enterQuantity(string quantity1)
        public void enterQuantity()
        {
            //driver.FindElement(By.XPath("//div[@class='add-to-cart-panel']/input")).SendKeys(quantity1);
            driver.FindElement(By.XPath("//div[@class='add-to-cart-panel']/input")).SendKeys("1");
        }
        public void selectSize(string size)
        {
            SelectElement element = new SelectElement(dropdown);
            element.SelectByText("Medium");
        }
        public void clickOnAddToCart()
        {
            driver.FindElement(By.XPath("//button[@id='add-to-cart-button-31']")).Click();
        }
        public bool validateAddToCart()
        {
            bool result = driver.FindElement(By.XPath("//p[@class='content")).Displayed;
            return result;
        }
        public void clickOnShoppingCart()
        {
            driver.FindElement(By.XPath("//span[contins(text(),'Shopping cart']")).Click();
        }
    }
}
