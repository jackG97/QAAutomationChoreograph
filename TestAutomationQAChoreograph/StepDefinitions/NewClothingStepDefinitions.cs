using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationQAChoreograph.POM;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace TestAutomationQAChoreograph.StepDefinitions
{
    public class NewClothingStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given("I am logged into my account")]
        public void IAmLoggedIntoMyAccount()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }

        [When("When I Select the Whats New option on main menu")]
        public void WhenISelecttheWhatsNewOptiononMainmMenu()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SelectWhatsNew();
        }

        [When("Im redirected to the Whats New Page")]
        public void WhenImRedirectedToTheWhatsNewPage()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.VerifyWhatsNewUrl();
        }

        [When("I Scroll down towards the bottom of the page")]
        public void IScrollDownToeardsTheBottomOfThePage()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.ScrollDownToNewClothes();
        }

        [When("I see New clothing available")]
        public void ISeeNewClothingAvailable()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.ViewNewClothing();
        }
    }
}
