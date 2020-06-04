using System.IO;
using Framework.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSystem.Pages;

namespace TestSystem.Tests
{
    public class TestsOne
    {

        [SetUp]
        public void BeforeEach(){

            Driver.init();
            PagesWrapper.init ();
            Driver.GotoTestEnv("https://www.vsoftconsulting.com/");
           // Driver.GotoStagingEnv ("staging url");
        
        }

        [TearDown]
        public void AfterEach (){

            Driver.current.Quit();
        }

        [Test]
        public void Test1(){
    
    var pagetwo = new PageTwo (); 
    //var Pageon = PagesWrapper.PageOne.
    pagetwo.Goto().PageOne.NavigatetoIndustriesPage ();

    // Assertion
    var knowledge= Driver.current.FindElement(By.CssSelector("a[href*='text']"));
    Assert.That(knowledge.Displayed);
}

static string[] PageNames = {" PageOne", "PageTwo"};

[Test,Category("PageChild")]
[TestCaseSource("PageNames")]
[Parallelizable(ParallelScope.Children)]
        public void Test2(){
        //click on navigation
    Driver.current.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/knowledgebase/']"));
    // Assertion
    var knowledge= Driver.current.FindElement(By.CssSelector("a[href*='text']"));
    Assert.That(knowledge.Displayed);
}


    }
}