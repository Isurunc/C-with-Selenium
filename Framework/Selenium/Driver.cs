using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using System.Collections.Generic

namespace Framework.Selenium {

public static class Driver {

//this section includes chrome driver setup implementation
[ThreadStatic]
public static IWebDriver _driver;
public static void init () {
    _driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
}


public static IWebDriver current => _driver ?? throw new NullReferenceException ("_driver is null");


//this section includes navigation to web urls implementation
public static void GotoTestEnv (String urltest) {
    //to print the url before invoke
    Debug.WriteLine(urltest);
    current.Navigate().GoToUrl(urltest);
}

public static void GotoStagingEnv (String urlstaging) {
    //to print the url before invoke
    Debug.WriteLine(urlstaging);
    current.Navigate().GoToUrl(urlstaging);
}


//this section includes find elements implementation

public static IWebElement FindElement(By by)
{
    return Driver.current.FindElement(by);
}

public static IList<IWebElement> FindElements(By by)
{
    return Driver.current.FindElements(by);
}


}
}