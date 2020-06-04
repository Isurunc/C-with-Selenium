using System;
using Framework.Selenium;

namespace TestSystem.Pages {
    
 public class PagesWrapper {

[ThreadStatic]
     public static PageOne Page ;

[ThreadStatic]
public static PageTwo Page2;

     public static void init () {

         Page = new PageOne ();
         Page2 = new PageTwo ();
     }

     
 }



}