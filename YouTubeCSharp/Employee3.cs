using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Employee3
    {
        public string FirstName= "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public class PartTimeEmployee: Employee3
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + "-Part Time  Employee");
            }
        }

        public class FullTimeEwmployee: Employee3
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + "-Full Time  Employee");
            }
        }

        public class TemporaryEmployee : Employee3
        {
            public override void PrintFullName()
            {
                Console.WriteLine(FirstName + " " + LastName + "-Temporary Employee");
            }
        }
    }
}
