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
    public class SearchStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I am signed in as a user on the home page")]
        public void GivenIAmSignedInAsAUserOnTheHomePage()
        {
            driver.Url = "https://magento.softwaretestingboard.com/";
            driver.Manage().Window.Maximize();
            HomePOM homepom = new HomePOM(driver);
            LoginPOM loginpom = new LoginPOM(driver);
            homepom.SelectSignIn();
            loginpom.EnterEmailAndPassword();
            loginpom.Login();
        }

        [When(@"I enter '([^']*)' in the search bar at the top of the page")]
        public void WhenIEnterInTheSearchBarAtTheTopOfThePage(string jackets)
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.SearchForClothing();
        }

        [When(@"I press the enter key")]
        public void WhenIPressTheEnterKey()
        {
            HomePOM homepom = new HomePOM(driver);
            homepom.PressEnter();
        }

        [Then(@"I should be taken to page which displays the results of the search")]
        public void ThenIShouldBeTakenToPageWhichDisplaysTheResultsOfTheSearch()
        {
            SearchResultsPOM searchresultspom = new SearchResultsPOM(driver);
            searchresultspom.VerifySearchResultUrl();
        }

        [Then(@"I can select the item I want")]
        public void ThenICanSelectTheItemIWant()
        {
            SearchResultsPOM searchresultspom = new SearchResultsPOM(driver);
            searchresultspom.SelectClothingIwant();
        }


    }
}
