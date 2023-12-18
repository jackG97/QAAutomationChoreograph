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
    public class SearchResultsPOM
    { 
        private IWebDriver driver;
        By SearchResultMessage = By.XPath("//span[contains(., 'Search results for:')]");
        By ClothingItem1 = By.XPath("//img[contains(@class,'product-image-photo')]");
        string SearchResultUrl = "/catalogsearch/result/?q=Jackets";


        public SearchResultsPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void VerifySearchResultUrl()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            String SearchResultsUrl = driver.Url;
            driver.Url.Contains(SearchResultUrl);
            IWebElement SRMessage = wait.Until(ExpectedConditions.ElementExists(SearchResultMessage));
            SRMessage.IsVisible();
        }

        public void SelectClothingIwant()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Clothing1 = wait.Until(ExpectedConditions.ElementExists(ClothingItem1));
            Clothing1.Click();
        }


    }
}
