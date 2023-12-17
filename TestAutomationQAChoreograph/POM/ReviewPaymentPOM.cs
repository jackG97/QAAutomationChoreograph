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
    public class ReviewPaymentPOM
    {
        private IWebDriver driver;
        By PlaceOrderButton = By.XPath("//span[contains(., 'Place Order')]");
        By PaymentConfirmationMessage = By.XPath("//span[contains(., 'Thank you for your purchase!')]");

        public ReviewPaymentPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PlaceOrder()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(PlaceOrderButton)).Click();
        }

        public void VerifyPaymentConfirmation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(PaymentConfirmationMessage));
        }
    }
}
