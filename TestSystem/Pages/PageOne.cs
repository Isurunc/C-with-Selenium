using System;
using OpenQA.Selenium;

namespace TestSystem.Pages
{
    public class PageOne{

        public readonly PageOneMap map;

        public PageOne(IWebDriver driver)
        {
            map = new PageOneMap(driver);
        }

        public void NavigatetoIndustriesPage (){
     map.KnowledgeTabLink.Click();

        }

    }


    public class PageOneMap {

        IWebDriver _driver ;
        public PageOneMap (IWebDriver driver)
        {
            _driver = driver;
        }
      public IWebElement KnowledgeTabLink => _driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/knowledgebase/']"));

    }
}
