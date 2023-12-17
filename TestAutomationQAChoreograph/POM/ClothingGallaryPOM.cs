using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationQAChoreograph.POM
{
    public class ClothingGallaryPOM
    {
        private IWebDriver driver;
        By ClothingItem1 = By.XPath("//img[contains(@class,'product-image-photo')]");
        By HoodiesJacketsTitle = By.XPath("//span[contains(., 'Hoodies & Sweatshirts')]");


        public ClothingGallaryPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectItemFromGallery()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(HoodiesJacketsTitle));
            IWebElement Clothing1 = wait.Until(ExpectedConditions.ElementExists(ClothingItem1));
            Clothing1.Click();
        }
    }
}
