using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Method_Overloading
    {

        //Demonstrates the use of method overloading which cann be done by the number type, and kind of parameters
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);

        }

        public static void Add(int FN, int SN, int TN, int FthN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN +FthN);

        }
        public static void Add(float FN, int SN, int TN, int FthN, out float JH)
        { float thisFloat = (float)TN;
            JH =FN + thisFloat;
            Console.WriteLine("Sum = {0}", FN + SN + TN + FthN);

        }
        //Cannot overload a method based in changing only return type
        //public static int  Add(int FN, int SN, int TN)
        //{
        // Console.WriteLine("Sum = {0}", FN + SN + TN);

        //}

    }
}
