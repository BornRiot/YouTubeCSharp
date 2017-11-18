using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Employee
    {
        
        string Fname;
        string Lname;
        string email;

        public void PrintFullName(string _FName, string _LName)
        {
            this.Lname = _LName;
            this.Fname = _FName;

            Console.WriteLine("");
        }
         
    }
}
