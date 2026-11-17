using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PairProgrammingSeleniumTests;

[TestClass]
public class LoginFailed
{
    [TestMethod]
    [DataRow("Invalid username","invalid Password")]
    public void LoginFailed_Chrome(string username, string password)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        var usernameInput = driver.FindElement(By.Id("username"));
        var passwordInput = driver.FindElement(By.Id("password"));
        var loginButton = driver.FindElement(By.Id("login-button"));

        usernameInput.SendKeys(username);
        passwordInput.SendKeys(password);
        loginButton.Click();
        Thread.Sleep(1000);


        Assert.ThrowsExactly<NoSuchElementException>(()=> driver.FindElement(By.Id("user-info")));
        driver.Quit();

    }
}
