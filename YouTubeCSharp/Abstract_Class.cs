using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    public class Abstract_Class
    {
        public abstract class Customer
        {
            //Non abstract members can be in abstract classes
            //Abstarc classes cant be  instantiated 
            //has to be inherited as base class
            //Non abstarc class has to inherit members or be marked abstract itself
            public abstract void Print();

        }
    }
}
