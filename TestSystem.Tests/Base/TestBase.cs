using Framework;
using Framework.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestSystem.Pages;

namespace TestSystem.Tests {

public abstract class TestBase {


[OneTimeSetUp]
        public virtual void BeforeAll(){

        Base.SetConfig();    
        Base.CreateTestResultsDirectory();
    }
    

        [SetUp]
        public virtual void BeforeEach(){

            Base.SetLogger();
            Driver.init();
            PagesWrapper.init ();
            Base.Log.step("User navigates to this URL");
            Driver.GotoTestEnv(Base.Config.Test.Url);
           //Driver.GotoStagingEnv (Base.Config.Test.Url);
        
        }

        [TearDown]
        public virtual void AfterEach (){

            var outcome = TestContext.CurrentContext.Result.Outcome.Status;

            if (outcome == TestStatus.Passed)
            {
                Base.Log.info("Outcome: Passed");
            }
            else if (outcome == TestStatus.Failed)
            {
                Driver.TakeScreenshot("test_failed");
                Base.Log.info("Outcome: Failed");
            }
            else
            {
                Base.Log.warning("Outcome: " + outcome);
            }


            Driver.Quit();
        }



















}

}