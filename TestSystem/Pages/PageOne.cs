using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace TestSystem.Pages
{
    public class PageOne{

        public readonly PageOneMap map;

        public PageOne()
        {
            map = new PageOneMap();
        }

        public void NavigatetoIndustriesPage (){
     map.KnowledgeTabLink.Click();

        }

    }


    public class PageOneMap {

      public Elements KnowledgeTabLink => Driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/knowledgebase/']"),"insert the name of the page here");

    }
}
