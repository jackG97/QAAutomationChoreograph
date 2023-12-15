using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestAutomationQAChoreograph.POM;

namespace TestAutomationQAChoreograph.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given("I am on the Home page")]
        public void IAmOnTheHomePage()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
        }

        [When("I select the Sign In button at the top of the screen")]
        public void ISelectTheSignInButtonAtTheTopOfTheScreen()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SelectSignIn();
        }

        [When("I enter in my email address and password")]
        public void IEnterInMyEmailAddressAndPassword()
        {
            LoginPOM loginpom = new LoginPOM(driver);
            loginpom.EnterEmailAndPassword();
        }

        [When("I select Sign In button at the bottm of the screen")]
        public void ISelectTheSignInButtonAtTheBottomOfTheScreen()
        {
            LoginPOM loginpom = new LoginPOM(driver);
            loginpom.Login();
        }


        [Then("I see my account page")]
        public void ISeeMyAccountPage()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.VerifyUserSeeAccountPage();
        }


        [When(@"I select the Create an Account button at the top of the screen")]
        public void WhenISelectTheCreateAnAccountButtonAtTheTopOfTheScreen()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SelectCreateAccountButton();
        }

        [When(@"I enter my sign information and personal information")]
        public void WhenIEnterMySignInformationAndPersonalInformation()
        {
            LoginPOM loginpom = new LoginPOM(driver);
            loginpom.EnterSignInInformationAndPersonalInformation();
        }

        [When(@"I select Create an Account button at the bottm of the screen")]
        public void WhenISelectCreateAnAccountButtonAtTheBottmOfTheScreen()
        {
            LoginPOM loginpom = new LoginPOM(driver);
            loginpom.CreateAccount();
        }

        [Then(@"I see an error message stating I already have an account")]
        public void ThenISeeAnErrorMessageStatingIAlreadyHaveAnAccount()
        {
            LoginPOM loginpom = new LoginPOM(driver);
            loginpom.UserStillSeesCreateNewAccountPage();
        }


    }
}
