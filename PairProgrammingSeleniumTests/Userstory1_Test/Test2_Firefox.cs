namespace PairProgrammingSeleniumTests;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
[TestClass]
public class Test2_Firefox
{
    [TestMethod]
    public void Check_RecordList_NotEmpty()
    {
        FirefoxOptions options = new FirefoxOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new FirefoxDriver(options);
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        var submitButton = driver.FindElement(By.Id("LoadRecords"));
        
        submitButton.Click();
        var dataList = driver.FindElements(By.ClassName("artist-name"));


        Assert.IsNotEmpty(dataList);
    }
}
