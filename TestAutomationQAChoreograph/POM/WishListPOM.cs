using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationQAChoreograph.POM
{
    public class WishListPOM
    {
        private IWebDriver driver;
        By MyWishListTitle = By.XPath("//span[contains(.,'My Wish List')]");
        By ClothingItem1 = By.XPath("//img[contains(@class,'product-image-photo')]");


        public WishListPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void VerifyWishListItemIsThere()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(MyWishListTitle));
            IWebElement Clothing1 = wait.Until(ExpectedConditions.ElementExists(ClothingItem1));
            if (Clothing1.IsVisible())
            {
                Console.WriteLine("Item displayed in Wishlist");
            }
            else
            {
                Console.WriteLine("Item is not displayed in Wishlist");
            }
        }
        
    }
}
