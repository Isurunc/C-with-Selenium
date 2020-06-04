using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Selenium
{

public class Wait {

private readonly WebDriverWait _wait;
public Wait(int WaitSeconds)
{
    _wait = new WebDriverWait(Driver.current, TimeSpan.FromSeconds(WaitSeconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };
            _wait.IgnoreExceptionTypes(

                typeof(NoSuchElementException),
                typeof(ElementNotVisibleException),
                typeof(StaleElementReferenceException),
                typeof(WebDriverTimeoutException),
                typeof(DriverServiceNotFoundException),
                typeof(XPathLookupException)
                
            );
            }

public bool Until(Func<IWebDriver, bool> condition)
        {
            return _wait.Until(condition);
        }



}



}