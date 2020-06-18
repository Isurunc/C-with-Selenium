using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Selenium {

//this class includes our own implementation of Drivers. ChromeDriver is implemented atm
public static class DriverFactory{


public static IWebDriver Build (string browserName) {


        Base.Log.info($"Browser: {browserName}");
    switch (browserName){
        case "chrome":
        return new ChromeDriver(Base.WORKSPACE_DIRECTORY + "_drivers");

        case "firefox" :
        return new FirefoxDriver ();

        default:
        throw new System.ArgumentException($"{browserName} not supported");


    }

}


}


}

