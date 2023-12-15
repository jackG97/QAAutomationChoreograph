using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationQAChoreograph.POM
{
    public class LoginPOM
    {

        private IWebDriver driver;
        By EmailAddressField = By.XPath("//input[contains(@id, 'email')]");
        By PasswordField = By.XPath("//input[contains(@type, 'password')]");
        By SignInSubmit = By.XPath("//span[contains(.,'Sign In')]");
        private string email = "jackgallaher36@gmail.com";
        private string password = "Test4me@home";
        By FirstNameField = By.XPath("//input[contains(@id, 'firstname')]");
        By LastNameField = By.XPath("//input[contains(@id, 'lastname')]");
        By ConfirmationPasswordField = By.XPath("//input[contains(@name, 'password_confirmation')]");
        By CreateAnAccountButton = By.XPath("//a[contains(.,'Create an Account')]");
        private string firstname = "Jack";
        private string lastname = "Gallaher";
        By NewAccountTitle = By.XPath("//span[contains(.,'Create New Customer Account')]");

        public LoginPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void EnterEmailAndPassword()
        {
            driver.FindElement(EmailAddressField).SendKeys(email);
            driver.FindElement(PasswordField).SendKeys(password);
        }

        public void EnterSignInInformationAndPersonalInformation()
        {
            driver.FindElement(FirstNameField).SendKeys(firstname);
            driver.FindElement(LastNameField).SendKeys(lastname);
            driver.FindElement(EmailAddressField).SendKeys(email);
            driver.FindElement(PasswordField).SendKeys(password);
            driver.FindElement(ConfirmationPasswordField).SendKeys(password);
        }

        public void Login()
        {
            driver.FindElement(SignInSubmit).Click();
        }

        public void CreateAccount()
        {
            driver.FindElement(CreateAnAccountButton).Click();
        }

        public void UserStillSeesCreateNewAccountPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement AccountErrorMessage = wait.Until(ExpectedConditions.ElementExists(NewAccountTitle));
        }

        
    }
}
