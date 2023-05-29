using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace AmazonProductSearch.Drivers
{
    [Binding]
    public class Hook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
           driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
           driver.Manage().Window.Maximize();





            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

            fluentWait.Timeout = TimeSpan.FromSeconds(30);

            fluentWait.PollingInterval = TimeSpan.FromSeconds(250);

        }

        

        [AfterScenario]
        public void AfterScenario()
        {
           driver.Close();
        }
    }
}