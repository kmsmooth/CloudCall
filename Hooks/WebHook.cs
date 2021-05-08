using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CloudCall.Hooks
{
    [Binding]
    public sealed class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {

           driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
           driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        }

        [AfterScenario]
        public static void AfterScenario()
        {
            
        }
    }
}
