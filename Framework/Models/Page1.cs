using System;

namespace Framework.Models
{

    //common attributes of pages goes here just like elements
    public class Page1 : PageChild  {
        public override string Name {get; set;} = "Isuru"; 
        public override int Cost {get; set;} = 1000;
        public override string Company {get; set;} = "99x";
        public override string Gender {get; set;} = "male";

        
    }
}
