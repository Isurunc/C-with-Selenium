using OpenQA.Selenium;

namespace TestSystem.Pages {

public class PageTwo : PageBase {

public readonly PageTwoMap map;

public PageTwo(IWebDriver driver) : base (driver) {
    map = new PageTwoMap(driver);
    }

 public PageTwo Goto () {
     PageOne.NavigatetoIndustriesPage ();
     return this;
 }




}


public class PageTwoMap {
 IWebDriver _driver; 

 public PageTwoMap(IWebDriver driver){
     _driver = driver;
 }

  public IWebElement Industries => _driver.FindElement(By.CssSelector("a[href*='https://www.vsoftconsulting.com/Industries/']"));

}


}