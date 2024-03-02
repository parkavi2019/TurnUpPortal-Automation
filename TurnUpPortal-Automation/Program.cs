using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

//Open MSEdge/Chrome browser
//IWebDriver driver = new EdgeDriver();
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();  


//Launch TurnUp portal and navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Just to wait for 5 seconds doing nothing
Thread.Sleep(5000);

//Identify login button and Click on Login Button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();



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

//================================================

//Navigate to Time and Material module(Click on the administration Dropdown Menu link)
IWebElement administratuionDropdown = driver.FindElement(By.XPath("//*[contains(text(),'Administration')]"));
administratuionDropdown.Click();
IWebElement timeandMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeandMaterialOption.Click();

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
//IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
//codeTextbox.Sendkeys("TurnUpPortal");


//Enter Description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("TurnUpPortalDescription");

//Enter the price
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
if(newRecordCode.Text== "Turnup2024")
{
    Console.WriteLine("New Material/Time Record has been created successfully");

}
else
{
    Console.WriteLine("New Material/Time Record has not been created");
}