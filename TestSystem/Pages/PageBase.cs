using OpenQA.Selenium;

namespace TestSystem.Pages
{

public abstract class PageBase {

    public readonly PageOne PageOne;
    public PageBase(){
            PageOne  = new PageOne();
        
    }


}

    
}