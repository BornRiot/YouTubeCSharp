using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
     public class Circle
    {
        static float PI;
        int Radius;


        public Circle(int _Radius)
         //Constructors cannot have void type modifiers 
        {
            Console.WriteLine("Instance constructor");
            this.Radius = _Radius;
        }

        //Static constructors are used to initialize and access static fields
        static Circle()
        {
            //Instead of initialize Pi with 3.141F at its creation. It is done within the static constructor
            Console.WriteLine("Static constructor");
            Circle.PI = 3.141F;
        }
     

        public static void Print()
        {
            // Method does not change
        }

        public float CalculateArea()
        {
            //Cannot access PI with an instance reference this.PI, use...
            //..type name instead
            return Circle.PI * this.Radius * this.Radius; //Uses the name of the class instead of an instance of the object 
        }

        

        }
    }

    

    

    

