using Framework.Models;
using Framework.Selenium;
using OpenQA.Selenium;

namespace TestSystem.Pages {

public class PageTwo : PageBase {

public readonly PageTwoMap map;

public PageTwo() : base () {
    map = new PageTwoMap();
    }

 public PageTwo Goto () {
     PageOne.NavigatetoIndustriesPage ();
     return this;
 }


 //public PageChild GetPageBase (){

     //var 
    // return new PageChild 
 }

}


public class PageTwoMap {
 

  public Elements Industries => Driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/Industries/']"),"insert the name of the page here");

  public Elements KnowledgeBase => Driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/KnowledgeBase/']"),"insert the name of the page here");
}


