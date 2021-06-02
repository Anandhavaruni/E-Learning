using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lambdaTest_bdd
{
  public   class GeneralMethods
    {
        protected IWebDriver driver;

        public void Setup(String browsername)
        {
           
            if (browsername.Equals("Chrome"))
            {
              // ChromeOptions options = new ChromeOptions();
                driver = new ChromeDriver();
            }
             

            else if (browsername.Equals("ie"))
                driver = new InternetExplorerDriver();
            else 
                driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();
            //  driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(30));

            Thread.Sleep(2000);
        }

        //[TearDown]
        //public void CleanUp()
        //{
        //    driver.Quit();
        
        //}

        public static IEnumerable<string> BrowserToRunWith()
        {
            String[] Browsers = { "Chrome", "firefox" };
            foreach (string b in Browsers)
            {
              yield  return b;
            }
        }


    }

}
