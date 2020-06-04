
using Framework.Models;

namespace  Framework.Services {

    public class IMemoryService : IPagesService
    {
        public PageChild GetPageBase(string pageName)
        {
            switch (pageName) {

        case  "page1" : 
        return new Page1(); 

        case "page2" :
        return new Page2();

        default :
        throw new System.ArgumentException ("Page is not available :  " +   pageName);


            }
        }
    }
}