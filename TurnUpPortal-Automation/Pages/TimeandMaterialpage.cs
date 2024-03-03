using OpenQA.Selenium;

namespace TurnUpPortal_Automation.Pages
{
    public class TimeandMaterialpage
    {
        public void CreateTimeMaterialRecord(IWebDriver driver))
        {

            //Click on create new button
            IWebElement creatNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            creatNewButton.Click();

            //Select Time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeMainDropdown.Click();

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typeCodeDropdown.Click();

            //Enter code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Turnup2024");

       
            //Enter Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("TurnUpPortalDescription");

            //Enter the price
            waitUtils.waitToBeClickable(driver,"Xpath","//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]",1)

            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("25");

            //Enter the selectfile Button
            //IWebElement selectfileButton = driver.FindElement(By.Id("//*[@id="files"]"));
            //selectfileButton.click();

            //Click on the Save Button
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();

            Thread.Sleep(2000);

            //Check if a new time record has been created successfully
           
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newRecordCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[1]"));
            if (newRecordCode.Text == "Turnup2024")
            {
                Console.WriteLine("New Material/Time Record has been created successfully");

            }
            else
            {
                Console.WriteLine("New Material/Time Record has not been created");

            }
            public void EditTimeMaterialRecord(IWebDriver driver)
        {
        
        }
        public void DeleteTimeMaterialRecord(IWebDriver driver)
        { 
        }
    }

}
