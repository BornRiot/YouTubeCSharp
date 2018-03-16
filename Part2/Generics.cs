using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Generics
    {
        public static bool IntAreEqual(int value1, int value2)
        {
            if (value1 == value2) 
            {
                Console.WriteLine("Equal");
                return true;
            } 
            else
            {
                Console.WriteLine("Not Equal");
                return false;
            }
        }

        public static bool ObjAreEqual(object value1, object value2)
        {
            //This method uses boxing to convert value type to object type which uses resources unnecessarily 
            return value1 == value2;
        }

        public static bool AreEqual<T>(T value1, T value2)
        {

            if (value1.Equals(value2))
            {
                Console.WriteLine("Equal");
                return true;
            }
            else
            {
                Console.WriteLine("Not Equal");
                return false;
            }

            
        }
        //You can also make classes generic also by using the <T> symbol
    }
}
