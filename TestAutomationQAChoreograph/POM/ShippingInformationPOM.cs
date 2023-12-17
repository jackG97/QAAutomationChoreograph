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
    public class ShippingInformationPOM
    {
        private IWebDriver driver;
        By StreetAddressField = By.XPath("//input[contains(@name, 'street[1]')]");
        string address = "123 High Road, Dublin 6, Ireland";
        By CityField = By.XPath("//input[contains(@name, 'city')]");
        string city = "Dublin";
        By State = By.XPath("//select[contains(@name, 'region_id')]");
        By ZIPFIELD = By.XPath("//input[contains(@name, 'postcode')]");
        string postcode = "4587";
        By Country = By.XPath("//select[contains(@name, 'country_id')]");
        By PhoneNumberField = By.XPath("//input[contains(@name, 'telephone')]");
        string phonenumber = "015645657";
        By ShippingMethod = By.XPath("//input[contains(@value, 'tablerate_bestway')]");
        By NextButton = By.XPath("//span[contains(., 'Next')]");
        public ShippingInformationPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PopulateShippingInformation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(StreetAddressField)).SendKeys(address);
            wait.Until(ExpectedConditions.ElementExists(CityField)).SendKeys(city);
            SelectElement CityValue = new(wait.Until(ExpectedConditions.ElementExists(State)));
            CityValue.SelectByIndex(0);
            wait.Until(ExpectedConditions.ElementExists(ZIPFIELD)).SendKeys(postcode);
            SelectElement CountryValue = new(wait.Until(ExpectedConditions.ElementExists(Country)));
            CountryValue.SelectByIndex(0);
            wait.Until(ExpectedConditions.ElementExists(PhoneNumberField)).SendKeys(phonenumber);
            wait.Until(ExpectedConditions.ElementExists(ShippingMethod)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(NextButton)).Click();
        }

    }
}
