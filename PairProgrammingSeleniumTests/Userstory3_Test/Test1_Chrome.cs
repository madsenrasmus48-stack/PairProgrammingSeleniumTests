using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PairProgrammingSeleniumTests;

[TestClass]
public class US3_Test1_Chrome
{
    [TestMethod]
    [DataRow("user1", "password1")]
    public void Login_Successful(string username, string password)
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://127.0.0.1:5501/PairProgrammingFrontEnd/index.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        var usernameInput = driver.FindElement(By.Id("username"));
        var passwordInput = driver.FindElement(By.Id("password"));
        var loginButton = driver.FindElement(By.Id("login-button"));


        usernameInput.SendKeys(username);
        passwordInput.SendKeys(password);
        loginButton.Click();
        var userInfo = driver.FindElement(By.Id("user-info"));

        Assert.AreEqual(userInfo.Text, $"Brugernavn: {username}");
        driver.Quit();
    }
}
