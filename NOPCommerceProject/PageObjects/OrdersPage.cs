using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOPCommerceProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace NOPCommerceProject.PageObjects
{
    public class OrdersPage:BaseClass
    {
        public OrdersPage() 
        {
            PageFactory.InitElements(driver, this);
        }
       [FindsBy(How = How.XPath, Using = "//span[@class='product-unit-price']")]
       public IWebElement unitPrice;
        [FindsBy(How = How.XPath, Using = "//td[@class='subtotal']/span")]
        public IWebElement totalPrice;
        [FindsBy(How = How.XPath, Using = "//button[@id='checkout']")]
        public IWebElement proceedToCheckout;
       
        public double getUnitPrice()
        {
            string unitPrice1 = unitPrice.Text;
            string unit=unitPrice1.Replace('$', ' ');
            double finalUnitPrice = double.Parse(unit);
            return finalUnitPrice/100;
        }
        public double getTotalPrice()
        {
            string totalPrice1 = unitPrice.Text;
            string tot = totalPrice1.Replace('$', ' ');
            double finalTotalPrice = double.Parse(tot);
            return finalTotalPrice / 100;
        }
        public LoginPage clickOnCheckout()
        {
            driver.FindElement(By.XPath("//button[@id='checkout']")).Click();
            return new LoginPage(getDriver());
        }
    }
}
