using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Employee
    {
        
        public string Fname;
        public string Lname;
         public string email;

        public void PrintFullName()
        {
            
            Console.WriteLine(Fname);
            Console.WriteLine(Lname);
            
        }

        public class FullTimeEmployee : Employee
        {
            public float yearlySalary;

        }

        public class partTimeEmployee : Employee
        {
            public float hourlyRate;

        }

        
        public class A : FullTimeEmployee
        {
     
        }


    }
}
