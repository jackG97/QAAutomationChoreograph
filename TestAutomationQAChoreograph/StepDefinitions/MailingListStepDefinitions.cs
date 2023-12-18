using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationQAChoreograph.POM;

namespace TestAutomationQAChoreograph.StepDefinitions
{
    [Binding]
    public class MailingListStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am logged in with an account")]
        public void GivenIAmLoggedInWithAnAccount()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }

        [When(@"I select '([^']*)' option")]
        public void WhenISelectOption(string p0)
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SelectSubscribeOption();
        }

        [When(@"Im directed to the subscribe form")]
        public void WhenImDirectedToTheSubscribeForm()
        {
            SubscribeMailingListFormPOM subscribemailinglistformpom = new SubscribeMailingListFormPOM(driver);
            subscribemailinglistformpom.VerifySubscribeFormUrl();
        }

        [When(@"I submit my details via the form page")]
        public void WhenISubmitMyDetailsViaTheFormPage()
        {
            SubscribeMailingListFormPOM subscribemailinglistformpom = new SubscribeMailingListFormPOM(driver);
            subscribemailinglistformpom.PopulateSubscribeForm();
        }

        [Then(@"I should be subscribed the mailing list")]
        public void ThenIShouldBeSubscribedTheMailingList()
        {
            SubscribeMailingListFormPOM subscribemailinglistformpom = new SubscribeMailingListFormPOM(driver);
            subscribemailinglistformpom.VerifySubscribeMessage();
        }

    }
}
