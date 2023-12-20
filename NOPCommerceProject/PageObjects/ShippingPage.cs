
using NOPCommerceProject.Utilities;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class ShippingPage:BaseClass
    {
        public ShippingPage() 
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
