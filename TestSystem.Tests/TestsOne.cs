using System;
using System.IO;
using Framework;
using Framework.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TestSystem.Pages;

namespace TestSystem.Tests
{
    public class TestsOne
    {


        [OneTimeSetUp]
        public void BeforeAll(){
        Base.CreateTestResultsDirectory();
    }
    

        [SetUp]
        public void BeforeEach(){

           Base.SetLogger();
            Driver.init();
            PagesWrapper.init ();
            Base.Log.step("User navigates to this URL");
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
    Assert.That(Driver.Title, Is.EqualTo("Provide the Webpage title here"));
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