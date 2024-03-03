using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortal_Automation.Pages;
public class Program
{
    private static void Main(string[] args)
    {
        //Open MSEdge/Chrome browser
        IWebDriver driver = new ChromeDriver();

         LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver,"hari","123123");

        HomePage homePageObj = new HomePage();
        homePageObj.VerifyloggedInUser(driver);
        homePageObj.NavigatetoTimeandMaterialPage(driver);

        TimeandMaterialpage timeandMaterialPageObj = new TimeandMaterialpage();
        TimeandMaterialpage timeandMaterialpageObj = timeandMaterialPageObj;
        timeandMaterialpageObj CreateTimeandMaterialRecord(driver);
        timeandMaterialpageObj.EditTimeandMaterialRecord(driver);
        timeandMaterialPageObj.DeleteTimeandMaterialRecord(driver);

    }

}