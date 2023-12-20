

using NOPCommerceProject.Utilities;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class OrederConfirmationPage:BaseClass
    {
        public OrederConfirmationPage() 
        {
            PageFactory.InitElements(driver, this);
        }

        /*[FindsBy(How = How.XPath, Using = "//div[@class='add-to-cart-panel']/input")]
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
       public IWebElement shoppingCart; */
    }
}
