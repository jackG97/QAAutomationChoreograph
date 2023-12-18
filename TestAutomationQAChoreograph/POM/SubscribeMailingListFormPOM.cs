using Microsoft.Dynamics365.UIAutomation.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationQAChoreograph.POM
{
    public class SubscribeMailingListFormPOM
    {
        private IWebDriver driver;
        By EmailField = By.XPath("//input[contains(@type, 'email')]");
        private string email = "jackgallaher36@gmail.com";
        By FNameField = By.XPath("//input[contains(@id, 'mce-FNAME')]");
        By LNameField = By.XPath("//input[contains(@id, 'mce-LNAME')]");
        private string fname = "Jack";
        private string lname = "Gallaher";
        By CompanyField = By.XPath("//input[contains(@id, 'mce-COMPANY')]");
        private string company = "T-Company";
        By PositionField = By.XPath("//input[contains(@id, 'mce-POSITION')]");
        private string position = "12";
        By SubscribeButton = By.XPath("//input[contains(@type, 'submit')]");
        By SuccessfulScribeMessage = By.XPath("//div[contains(., 'Almost finished... We need to confirm your email address. To complete the subscription process, please click the link in the email we just sent you.')]");
        
        public SubscribeMailingListFormPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void PopulateSubscribeForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(EmailField)).SendKeys(email);
            wait.Until(ExpectedConditions.ElementExists(FNameField)).SendKeys(fname);
            wait.Until(ExpectedConditions.ElementExists(LNameField)).SendKeys(lname);
            wait.Until(ExpectedConditions.ElementExists(CompanyField)).SendKeys(company);
            wait.Until(ExpectedConditions.ElementExists(PositionField)).SendKeys(position);
            wait.Until(ExpectedConditions.ElementToBeClickable(SubscribeButton)).SendKeys(Keys.Return);
        }

        public void VerifySubscribeMessage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SubscribedMessage = wait.Until(ExpectedConditions.ElementExists(SuccessfulScribeMessage));
            SubscribedMessage.IsVisible();
        }

        public void VerifySubscribeFormUrl()
        {
            String SubsribeUrl = driver.Url;
            driver.Url.Contains("/subscribe/");
        }

    }
}
