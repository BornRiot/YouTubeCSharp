using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Employee2
    {
        public string firstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine(firstName + " " + LastName + "- Contreactor");
;
        }

        public class FullTimeEmployee: Employee2
        {
             
        }

        public class PartTimeEmployee : Employee2
        {
            public new void  PrintFullName() //Hides orignal print method
                //If you want to hide a base class member, use the new keyword
            {
                Console.WriteLine(firstName + LastName);                
                
            }


        }
    }
    
}



