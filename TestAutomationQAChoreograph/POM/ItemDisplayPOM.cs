using Microsoft.Dynamics365.UIAutomation.Browser;
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
    public class ItemDisplayPOM
    {
        private IWebDriver driver;
        By AddToCartButton = By.XPath("//button[contains(@title, 'Add to Cart')]");
        By AddToWishListButton = By.XPath("//span[contains(.,'Add to Wish List')]");
        By BasketOption = By.XPath("//a[contains(@class, 'action showcart')]");
        By ProceedToCheckoutButton = By.XPath("//button[contains(@title, 'Proceed to Checkout')]");
        By RemoveButton = By.XPath("//a[contains(@class, 'action delete')]");
        By OkConfirmationButton = By.XPath("//span[contains(., 'OK')]");
        By NoItemInBasketMessage = By.XPath("//strong[contains(., 'You have no items in your shopping cart.')]");
        By ReviewOption = By.XPath("//a[contains(., 'Reviews')]");
        By SummaryField = By.XPath("//input[contains(@id, 'summary_field')]");
        string summary = "Great Item";
        By ReviewField = By.XPath("//textarea[contains(@id, 'review_field')]");
        string review = "Great Item, Will purchase again soon!";
        By SubmitButton = By.XPath("//button[contains(@type, 'submit')]");
        By SuccessfulReviewMessagePublished = By.XPath("//div[contains(., 'You submitted your review for moderation.')]");



        public ItemDisplayPOM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddItemToCartAndCheckout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IList<IWebElement> ClothesSize = driver.FindElements(By.XPath("//div[contains(@class, 'swatch-option text')]"));
            Thread.Sleep(2000);
            ClothesSize[2].Click();
            IList<IWebElement> ClothesColour = driver.FindElements(By.XPath("//div[contains(@class, 'swatch-option color')]"));
            Thread.Sleep(2000);
            ClothesColour[0].Click();
            wait.Until(ExpectedConditions.ElementExists(AddToCartButton)).Click();
            wait.Until(ExpectedConditions.ElementExists(BasketOption)).Click();
            Thread.Sleep(20000);
            wait.Until(ExpectedConditions.ElementExists(ProceedToCheckoutButton));

        }

        public void AddItemToWishList()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IList<IWebElement> ClothesSize = driver.FindElements(By.XPath("//div[contains(@class, 'swatch-option text')]"));
            Thread.Sleep(2000);
            ClothesSize[2].Click();
            IList<IWebElement> ClothesColour = driver.FindElements(By.XPath("//div[contains(@class, 'swatch-option color')]"));
            Thread.Sleep(2000);
            ClothesColour[0].Click();
            wait.Until(ExpectedConditions.ElementExists(AddToWishListButton)).Click();

        }

        public void RemoveItemFromBasket()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(RemoveButton)).Click();
            wait.Until(ExpectedConditions.ElementExists(OkConfirmationButton)).Click();
        }

        public void VerifyItemIsGone()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(NoItemInBasketMessage));
        }

        public void ReviewOptionMenu()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(ReviewOption)).Click();
        }

        public void FillOutReviewForm()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IList<IWebElement> StarRating = driver.FindElements(By.XPath("//div[contains(@class, 'control review-control-vote')]/..//label"));
            Thread.Sleep(2000);
            StarRating[2].Click();
            wait.Until(ExpectedConditions.ElementExists(SummaryField)).SendKeys(summary);
            wait.Until(ExpectedConditions.ElementExists(ReviewField)).SendKeys(review);
            wait.Until(ExpectedConditions.ElementExists(SubmitButton)).Click();

        }

        public void VerifyReviewMessageIsSuccessful()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement ReviewSuccessMessage = wait.Until(ExpectedConditions.ElementExists(SuccessfulReviewMessagePublished));
            ReviewSuccessMessage.IsVisible();
        }
    }
}
