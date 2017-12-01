using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a bBase Class print method");
        }

        public virtual void Print1()
        {
            Console.WriteLine("I am a bBase Class print method");
        }

    }
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class print Method"); //Derived class overrides base class to be used as print mehtod
        }

        public new void Print1() //Hides method
        {
            Console.WriteLine("I am a Derived Class print Method"); //Base Classe is printed
        }

    }
    


}
