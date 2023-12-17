using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Dynamics365.UIAutomation.Browser;


namespace TestAutomationQAChoreograph.POM
{
    public class WhatsNewPOM
    {
        private IWebDriver driver;
        By NewClothingOption = By.XPath("//img[contains(@class,'product-image-photo')]");
        By ClothingItem1 = By.XPath("//img[contains(@class,'product-image-photo')]");
        By MensHoodiesAndJackets = By.XPath("//a[contains(@href,'https://magento.softwaretestingboard.com/men/tops-men/hoodies-and-sweatshirts-men.html')]");
        
        

        public WhatsNewPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void VerifyWhatsNewUrl()
        {
            String WhatsNewUrl = driver.Url;
            driver.Url.Contains("what-is-new.html");
        }

        public void ScrollDownToNewClothes()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement NewClothingItem = wait.Until(ExpectedConditions.ElementExists(NewClothingOption));
            ((IJavaScriptExecutor)driver).
                ExecuteScript("arguments[0].scrollIntoView(true);", NewClothingItem);
        }

        public void ViewNewClothing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(ClothingItem1)).Click();
        }


        public void HoodiesAndJacketsMen()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(MensHoodiesAndJackets));
            
        }

        
            

    }
}
