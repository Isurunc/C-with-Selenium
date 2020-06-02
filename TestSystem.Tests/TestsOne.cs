using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSystem.Pages;

namespace TestSystem.Tests
{
    public class TestsOne
    {

        IWebDriver driver;
        
        
        [SetUp]
        public void BeforeEach(){
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
            driver.Url = "https://www.vsoftconsulting.com/";
        
        }

        [TearDown]
        public void AfterEach (){

            driver.Quit();
        }

        [Test]
        public void Test1(){
    
    var pagetwo = new PageTwo (driver); 
    pagetwo.Goto().PageOne.NavigatetoIndustriesPage ();

    // Assertion
    var knowledge= driver.FindElement(By.CssSelector("a[href*='text']"));
    Assert.That(knowledge.Displayed);
}


        public void Test2(){
        //click on navigation
    driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/knowledgebase/']"));
    // Assertion
    var knowledge= driver.FindElement(By.CssSelector("a[href*='text']"));
    Assert.That(knowledge.Displayed);
}


    }
}