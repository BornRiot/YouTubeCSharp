using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    /*
     Teaches the  creation and use of interfaces 
    A class or a strcut can inherit from more thann one interfaces at a tme 
    A STRUCT CAN INHERIT FROM AN INTERFACE
    An interface can inherit from other interfaces and therfore a class must provide implementation for all members 
    of the interface chainfrom those interfaces 
    You cannot create an instance of an interface
         */
    public class Interface_C
    {
        public interface ICustomer
        {
            void print();
        }

        public interface ICustomer2 : ICustomer
        {
            void print2();
        }

        public class Customer : ICustomer2
        {
            public void print()
            {
                Console.WriteLine("Interface  print method");
            }

    

            public void print2()
            {
                Console.WriteLine("Interface 2 print method");
            }
           

            
        }
    }
}
