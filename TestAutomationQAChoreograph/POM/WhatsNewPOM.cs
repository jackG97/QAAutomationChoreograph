using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationQAChoreograph.POM
{
    public class WhatsNewPOM
    {
        private IWebDriver driver;
        By NewClothingOption = By.XPath("//span[contains(.,'Zoltan Gym Tee')]");

        public WhatsNewPOM(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void VerifyWhatsNewUrl()
        {
            String WhatsNewUrl = driver.Url;
            driver.Url.Contains("what-is-new.html");
        }

        public void ScrollDown()
        {

        }


    }
}
