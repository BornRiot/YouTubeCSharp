using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Method_Parameters
        //Lecture Demonstartes the differewnce or uses of of pass by value and pass 
        //by reference in C#
    {
        //pass by value method
        public  void MyMehtod(int j)
        {
            j = 100;
        }
        //pass by reference method
        public void Refmethod(ref int c)
        {
            c = 102;
        } 
        //Demonstrate the use of out parameters in methods
        public void Calculate (int FN, int SN, out int Sum, out int Multiple)
        {
            Sum = FN + SN;
            Multiple = FN  * SN;
        }
        //Demonstrate the use of pass by paremeters in method use
        //Note pass by parameters methood gives the option of not passing an argument to methods
        public void  MyParaMethod (params int[] numbers) // Params has to be last parameter in the passed arguments
        {
            Console.WriteLine("There are {0} numbers in the array", numbers.Length);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
