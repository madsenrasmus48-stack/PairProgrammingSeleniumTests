using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PairProgrammingSeleniumTests;

[TestClass]
public class US1_test1_Firefox
{
    [TestMethod]
    public void FindLoadRecordsButton_Mozilla()
    {
        //Arrange
        FirefoxOptions options = new FirefoxOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new FirefoxDriver(options);
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");
        
        //Act
        IWebElement hentDataelement = driver.FindElement(By.Id("LoadRecords"));
        var buttonText = hentDataelement.Text;


        //Assert

        Assert.AreEqual("Load records", buttonText);
    }
}
