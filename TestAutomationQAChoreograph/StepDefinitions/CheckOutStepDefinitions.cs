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
    public class CheckOutStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am logged into my shopping account")]
        public void GivenIAmLoggedIntoMyShoppingAccount()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }


        [When(@"I want select an item to purchase from Mens Section")]
        public void WhenIWantSelectAnItemToPurchaseFromMensSection()
        {
            HomePOM homepom = new HomePOM(driver);
            WhatsNewPOM whatsnewpom = new WhatsNewPOM(driver);
            ClothingGallaryPOM clothinggallerypom = new ClothingGallaryPOM(driver);
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            homepom.SelectWhatsNew();
            whatsnewpom.HoodiesAndJacketsMen();
            clothinggallerypom.SelectItemFromGallery();
            itemdisplaypom.AddItemToCartAndCheckout();

        }

        [When(@"I add it to my shopping cart")]
        public void WhenIAddItToMyShoppingCart()
        {
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            itemdisplaypom.AddItemToCartAndCheckout();
        }

        [When(@"I enter in my shipping and payment information")]
        public void WhenIEnterInMyShippingAndPaymentInformation()
        {
            ShippingInformationPOM shippinginformationpom = new ShippingInformationPOM(driver);
            ReviewPaymentPOM reviewpaymentpom = new ReviewPaymentPOM(driver);
            shippinginformationpom.PopulateShippingInformation();
            reviewpaymentpom.PlaceOrder();
        }

        [Then(@"I should receive a shopping success message after buying it")]
        public void ThenIShouldReceiveAShoppingSuccessMessageAfterBuyingIt()
        {
            ReviewPaymentPOM reviewpaymentpom = new ReviewPaymentPOM(driver);
            reviewpaymentpom.VerifyPaymentConfirmation();
        }

        [When(@"I Select the bin icon to delete it")]
        public void WhenISelectTheBinIconToDeleteIt()
        {
            ItemDisplayPOM itemdisplaypom = new ItemDisplayPOM(driver);
            itemdisplaypom.RemoveItemFromBasket();
        }

        [Then(@"It should be removed from my basket")]
        public void ThenItShouldBeRemovedFromMyBasket()
        {
            throw new PendingStepException();
        }

    }
}
