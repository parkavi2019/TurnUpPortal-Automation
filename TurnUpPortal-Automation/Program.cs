using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

//Open MSEdge/Chrome browser
IWebDriver driver = new EdgeDriver();
driver.Manage().Window.Maximize();  


//Launch TurnUp portal and navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

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