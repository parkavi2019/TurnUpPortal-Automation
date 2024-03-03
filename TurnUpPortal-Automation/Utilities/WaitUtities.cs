using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal_Automation.Utilities
{
    public class WaitUtities
    {
        public static void waitToBeVisible(IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new webDriverwait(driver, TimeSpan.FromSeconds(seconds));

            if (locatorType == "Xpath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementisVisible(By.Xpath(locatorValue)));

            }
            if (locatorType == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementisVisible(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelectoer")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementisVisible(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementisVisible(By.Name(locatorValue)));
            }
        }
        public static void waitToBeClickable(IWebDriver driver,string locatorType,string locatorValue,int seconds)
        {
            var wait = new WebDriver(driver, TimeSpan.FromSeconds(seconds));

            if(locatorType == "Xpath")

            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElemenToClickable(By.XPath(locatorValue)));
            }
            if (locatorType == "id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElemenToClickable(By.Id(locatorValue)));
            }
            if (locatorType == "CssSelectoer")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToClickable(By.CssSelector(locatorValue)));
            }
            if (locatorType == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElemenToClickable(By.Name(locatorValue)));
            }
        }
    }

}
