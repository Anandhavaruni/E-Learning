using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(4)]



namespace lambdaTest_bdd.Step_Definition
{
    [Binding]
    //[TestFixture]
    //[Parallelizable]
 public  class LambadaTest_bddStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
       
        private IWebDriver _driver;
        private LambdaTestDriver LTDriver = null;
        String test_url = "https://lambdatest.github.io/sample-todo-app/";
        String itemName = "Adding item to the list";


        String username = "varunineelan";
        String accesskey = "dcvf67iCPgQwLYuiVMINlMLJ2bzxSLXG8W4r91cRflJnF0eQG4";
        String gridURL = "@hub.lambdatest.com/wd/hub";
        String Text = "SpecFlow - Using FirefoxOption WebDriver using C# and NUnit";


        public LambadaTest_bddStep(ScenarioContext ScenarioContext)
        {
            LTDriver = (LambdaTestDriver)ScenarioContext["LTDriver"];
        }


        [Given(@"that I am on the LambdaTest Sample app (.*) and (.*)")]
        public void GivenThatIAmOnTheLambdaTestSampleAppAnd(string profile, string environment)
        {
      
            // driver = new FirefoxDriver();


            _driver = LTDriver.Init(profile, environment);

            _driver.Url = test_url;
            _driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);

            //cross browser Testing
            //    DesiredCapabilities capabilities = new DesiredCapabilities();

            //  var caps = new ChromeOptions();

            ////var caps = new FirefoxOptions();

            //capabilities.SetCapability("user", username);
            //capabilities.SetCapability("accessKey", accesskey);
            //capabilities.SetCapability("build", "SpecFlow - Using Firefox WebDriver using C# and NUnit");
            //capabilities.SetCapability("name", "SpecFlow - Using Firefox WebDriver using C# and NUnit");
            //capabilities.SetCapability("platform", "Windows 10");
            //capabilities.SetCapability("browserName", "Firefox");
            //capabilities.SetCapability("version", "62.0");

            //// caps.PlatformName = "Windows 10";
            //// caps.BrowserVersion = "62";
            //// caps.AddAdditionalCapability("username", username, true);
            //// caps.AddAdditionalCapability("password", accesskey, true);
            //// caps.AddAdditionalCapability("name", Text, true);

            //////  driver = new RemoteWebDriver(new Uri("https://" + username + ":" + accesskey + gridURL), capabilities, TimeSpan.FromSeconds(600));

            ////  driver = new RemoteWebDriver(new Uri("https://" + username + ":" + accesskey + gridURL), caps);

            //// driver.Url = test_url;

            //// driver.Manage().Window.Maximize();
            //// System.Threading.Thread.Sleep(2000);

            //Setup(browsername);
            // driver.Url = test_url;
        }
        
        [Then(@"select the first item")]
        public void ThenSelectTheFirstItem()
        {
            // Click on First Check box
            IWebElement firstCheckBox = _driver.FindElement(By.Name("li1"));
            firstCheckBox.Click();
        }

        [Then(@"select the second item")]
        public void ThenSelectTheSecondItem()
        {
            IWebElement secondCheckBox = _driver.FindElement(By.Name("li2"));
            secondCheckBox.Click();
        }

        [Then(@"select the Third item")]
        public void ThenSelectTheThirdItem()
        {
            IWebElement ThirdCheckBox = _driver.FindElement(By.Name("li3"));
            ThirdCheckBox.Click();
        }


        [Then(@"find the text box to enter the new value")]
        public void ThenFindTheTextBoxToEnterTheNewValue()
        {
            // Enter Item name
            IWebElement textfield = _driver.FindElement(By.Id("sampletodotext"));
            textfield.SendKeys(itemName);
        }

        [Then(@"click the Submit button")]
        public void ThenClickTheSubmitButton()
        {
            IWebElement addButton = _driver.FindElement(By.Id("addbutton"));
            addButton.Click();
        }

        [Then(@"verify whether the item is added to the list")]
        public void ThenVerifyWhetherTheItemIsAddedToTheList()
        {
            IWebElement itemtext = _driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
            String getText = itemtext.Text;
            // Check if the newly added item is present or not using
            // Condition constraint (Boolean)
            Assert.That((itemName.Contains(getText)), Is.True);

            /* Perform wait to check the output */
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Firefox - Test 1 Passed");
        }

        [Then(@"close the browser instance")]
        public void ThenCloseTheBrowserInstance()
        {
            // CleanUp();
            _driver.Quit();
        }

        /* public static void InitCaps()

         {
             if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("LT_USERNAME")))
             {
                 ltUserName = ConfigurationSettings.AppSettings["LTUser"];
             }
             if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("LT_APPKEY")))

                 ltAppKey = ConfigurationSettings.AppSettings["LTAccessKey"];

             if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("LT_OPERATING_SYSTEM")))

                 platform = ConfigurationSettings.AppSettings["OS"];

             if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("LT_BROWSER")))

                 browser = ConfigurationSettings.AppSettings["Browser"];

             if (String.IsNullOrEmpty(Environment.GetEnvironmentVariable("LT_BROWSER_VERSION")))

                 browserVersion = ConfigurationSettings.AppSettings["BrowserVersion"];
         }*/
    }
}

