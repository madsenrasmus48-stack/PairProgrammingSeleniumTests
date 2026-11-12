using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PairProgrammingSeleniumTests;

[TestClass]
public class Test1_Chrome
{
    [TestMethod]
    [DataRow("Dark Side of The Moon", null, null, null)]
    [DataRow(null, "Pink Floyd", null, null)]
    [DataRow(null, null, 180, null)]
    [DataRow(null, null, null, 1971)]
    public void FrontEnd_Filtering_NotEmpty(string title, string artist, int? duration, int? year)
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new ChromeDriver(options);
        driver.Navigate().GoToUrl("http://127.0.0.1:5501/index.html");
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
        var submitButton = driver.FindElement(By.Id("LoadRecords"));
        var titleInput = driver.FindElement(By.Id("filterTitle"));

        titleInput.SendKeys(title);
        submitButton.Click();

        var dataList = driver.FindElements(By.ClassName("title"));
        Assert.AreEqual(dataList.Count, 1);

    }
}
