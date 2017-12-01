using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    
    class Delegates
    {
        public delegate void HelloFunctionDelegate(string Message);
        public static void hello(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
