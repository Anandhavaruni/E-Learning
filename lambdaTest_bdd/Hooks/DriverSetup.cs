using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace lambdaTest_bdd.Hooks
{
  public  class DriverSetup
    {
     //   private LambdaTestDriver LTDriver;
        private string[] tags;
        private ScenarioContext _scenarioContext;
        private readonly IObjectContainer _objectContainer;
        IWebDriver Driverd;

        public  DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }




        [BeforeScenario]
        public void BeforeScenario(ScenarioContext ScenarioContext)
        {
            //TODO: implement logic that has to run before executing each scenario
            //_scenarioContext = ScenarioContext;
            //LTDriver = new LambdaTestDriver(ScenarioContext);
            //ScenarioContext["LTDriver"] = LTDriver;
            //_objectContainer.RegisterInstanceAs<LambdaTestDriver>(LTDriver);
            Driverd = new ChromeDriver();
            _objectContainer.RegisterInstanceAs(Driverd);

        }
    }
}
