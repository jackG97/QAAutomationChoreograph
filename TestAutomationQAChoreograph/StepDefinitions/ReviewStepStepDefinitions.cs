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
    public class ReviewStepStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am signed into my account")]
        public void GivenIAmSignedIntoMyAccount()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }

        [When(@"I proceed to select a clothing item")]
        public void WhenIProceedToSelectAClothingItem()
        {
            HomePOM homepom = new HomePOM(driver);
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            ClothingGallaryPOM clothinggallerypom = new ClothingGallaryPOM(driver);
            homepom.SelectWhatsNew();
            whatsnewpom.HoodiesAndJacketsMen();
            clothinggallerypom.SelectItemFromGallery();
        }

        [When(@"I select Review option on the item display page")]
        public void WhenISelectReviewOptionOnTheItemDisplayPage()
        {
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            itemdisplaypom.ReviewOptionMenu();
        }

        [When(@"I submit a review via the review form")]
        public void WhenISubmitAReviewViaTheReviewForm()
        {
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            itemdisplaypom.FillOutReviewForm();
        }

        [Then(@"I recevie a success message stating I have submited a review")]
        public void ThenIRecevieASuccessMessageStatingIHaveSubmitedAReview()
        {
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            itemdisplaypom.VerifyReviewMessageIsSuccessful();

        }
    }
}
