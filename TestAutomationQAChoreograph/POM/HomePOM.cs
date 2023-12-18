using NUnit.Framework;
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
    public class HomePOM
    {

        private IWebDriver driver;
        By SignInButton = By.XPath("//a[contains(.,'Sign In')]");
        By MyAccountTitle = By.XPath("//span[contains(.,'Welcome, Jack Gallaher!')]");
        By CreateAnAccountButton = By.XPath("//a[contains(.,'Create an Account')]");
        By WhatsNewOption = By.XPath("//a[contains(@href,'https://magento.softwaretestingboard.com/what-is-new.html')]");
        By SubscribeToMailingListButton = By.XPath("//a[contains(@href, 'https://softwaretestingboard.com/subscribe/')]");
        By SearchBar = By.XPath("//input[contains(@id,'search')]");
        string searchvalue = "Jackets";
        
        public HomePOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void SelectSignIn()
        {
            driver.FindElement(SignInButton).Click();
        }

        public void SelectCreateAccountButton()
        {
            driver.FindElement(CreateAnAccountButton).Click();
        }


        public void VerifyUserSeeAccountPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement Account = wait.Until(ExpectedConditions.ElementExists(MyAccountTitle));

        }

        public void SelectWhatsNew()
        {
            driver.FindElement(WhatsNewOption).Click();
        }

        public void SelectSubscribeOption()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(SubscribeToMailingListButton)).Click();
        }

        public void SearchForClothing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(SearchBar)).SendKeys(searchvalue);
            
        }

        public void PressEnter()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(SearchBar)).SendKeys(Keys.Return);
        }


        

    }
}
