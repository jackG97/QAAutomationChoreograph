using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestAutomationQAChoreograph.POM;

namespace TestAutomationQAChoreograph.StepDefinitions
{
    [Binding]
    public class NewClothingStepDefinitions
    {

        IWebDriver driver = new ChromeDriver();

        [Given(@"I am logged into my account")]
        public void GivenIAmLoggedIntoMyAccount()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }

        [When(@"I Select the Whats New option on my main menu")]
        public void WhenISelectTheWhatsNewOptionOnMyMainMenu()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SelectWhatsNew();
        }

        [When(@"Im redirected to the Whats New Page")]
        public void WhenImRedirectedToTheWhatsNewPage()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.VerifyWhatsNewUrl(); ;
        }

        [When(@"I Scroll down towards the bottom of the page")]
        public void WhenIScrollDownTowardsTheBottomOfThePage()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.ScrollDownToNewClothes();
        }

        [Then(@"I see New clothing available")]
        public void ThenISeeNewClothingAvailable()
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.ViewNewClothing();
        }

        [When(@"I proceed to Hoodies and Jackets under '([^']*)'")]
        public void WhenIProceedToHoodiesAndJacketsUnder(string p0)
        {
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            whatsnewpom.HoodiesAndJacketsMen();

        }

        [Then(@"I can select an item I want to add to my wishlist")]
        public void ThenICanSelectAnItemIWantToAddToMyWishlist()
        {
            ClothingGallaryPOM clothinggallerypom = new ClothingGallaryPOM(driver);
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            WishListPOM wishlistpom = new WishListPOM(driver);
            clothinggallerypom.SelectItemFromGallery();
            itemdisplaypom.AddItemToWishList();
            wishlistpom.VerifyWishListItemIsThere();
            
        }

    }
}
