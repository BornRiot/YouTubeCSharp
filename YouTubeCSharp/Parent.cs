using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Class Cinstructor called");


        }

        public Parent(string Message)
        {
            Console.WriteLine(Message);


        }
        public class ChildClass: Parent
        {
            public ChildClass() : base ( "Message derived from message controlling Parent class") //Illustrating which constructor gets called
            {
                Console.WriteLine("ChildClass Constructor called"); 
            }
        }
    }
}
