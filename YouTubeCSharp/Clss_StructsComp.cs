using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    public class Clss_StructsComp { 
        ~Clss_StructsComp()
    {
        //Example of how a destructor can be used on a class but not a struct
    }
        //Strcutors cannot have parameterless constructors 
        //Marking a class as sealed prevent it from being  inherited
    
        public struct Customer
        {
            public int Id { set; get; }
            public string Name { set; get; } 

        }
    }
}
