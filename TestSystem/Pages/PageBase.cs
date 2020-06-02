using OpenQA.Selenium;

namespace TestSystem.Pages
{

public abstract class PageBase {

    public readonly PageOne PageOne;
    public PageBase(IWebDriver driver){
            PageOne  = new PageOne(driver);
        
    }


}

    
}