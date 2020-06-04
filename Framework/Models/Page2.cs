using System;

namespace Framework.Models
{

    //common attributes of pages goes here just like elements
    public class Page2 : PageChild  {
        public override string Name {get; set;} = "kasun"; 
        public override int Cost {get; set;} = 200;
        public override string Company {get; set;} = "ABC";
        public override string Gender {get; set;} = "Female";

        
    }
}
