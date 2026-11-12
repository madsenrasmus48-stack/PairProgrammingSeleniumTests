using System.Xml.Serialization;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PairProgrammingSeleniumTests;

[TestClass]
public class US1_test1_Chrome
{
    [TestMethod]
    public void FindLoadRecordsButton_Chrome()
    {
        //Arrange
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless=new");
        IWebDriver driver = new ChromeDriver(options);
        driver.Navigate().GoToUrl("http://127.0.0.1:5500/index.html");
        
        //Act
        IWebElement hentDataelement = driver.FindElement(By.Id("LoadRecords"));
        var buttonText = hentDataelement.Text;


        //Assert

        Assert.AreEqual("Load records", buttonText);
    }
}
