using OpenQA.Selenium;

namespace TurnUpPortal_Automation.Pages
{
    public class HomePage
    {
        public void NavigatetoTimeandMaterialPage(IWebDriver driver))
        {
            //Navigate to Time and Material module(Click on the administration Dropdown Menu link)
            IWebElement administratuionDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
            administratuionDropdown.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan, FromSeconds(5));
           // Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementisVisible(By.Xpath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")));
            
            waitUtils.waitToBeVisible(DriverCommand,"Xpath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a",3);
            IWebElement timeandMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandMaterialOption.Click();
"
        }
        public void VerifyLoggedInUser(IWebDriver driver))
        {
            //Check if the user has logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("user has logged in successfully");
            }
            else
            {
                Console.WriteLine("user hasn't been logged in :( :(");
            }

        }
    }
}
