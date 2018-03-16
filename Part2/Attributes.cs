using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Calculator
        
    {
        [Obsolete("Use Add(List<int> Numbers) Method ")]
        public static int Add (int firstNumber, int SecondNumber)
        {
            return firstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int Number in Numbers)
            {
                Sum += Number;

            }
            return Sum;
        }
    }
}
