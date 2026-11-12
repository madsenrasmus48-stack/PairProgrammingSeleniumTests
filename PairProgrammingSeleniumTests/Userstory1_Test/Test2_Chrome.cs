namespace PairProgrammingSeleniumTests;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
[TestClass]
public class Test2_Chrome
{
    [TestMethod]
    public void Check_RecordList_NotEmpty()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new ChromeDriver(options);
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        var submitButton = driver.FindElement(By.Id("LoadRecords"));
        
        submitButton.Click();
        var dataList = driver.FindElements(By.ClassName("artist-name"));


        Assert.IsNotEmpty(dataList);
    }
}
