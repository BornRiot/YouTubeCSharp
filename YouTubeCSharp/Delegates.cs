using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    
    class Delegates
    {//Delegates are typesafe functions bevause their signatures also have to mahtch that of methods

        public delegate void HelloFunctionDelegate(string Message);
        public static void hello(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
