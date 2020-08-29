using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    
public class Account
    {
        [Flags]
        public enum Access
        {
            Delete = 1,
            Publish = 2,
            Submit = 4,
            Comment = 8,
            Modify = 16,
            Writer = 20,
            Editor = 11,
            Owner = 31
            //Delete = 0,
            //Publish = 1,
            //Submit = 2,
            //Comment = 3,
            //Modify = 4,
            //Writer = Submit | Modify | 5,
            //Editor = Delete | Publish | Comment | 6,
            //Owner = Writer | Editor | 6
        }

        
   
    }
}
