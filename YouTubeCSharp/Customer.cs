using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{ 
    public  class Customer
    {
        //Teaches the use of class cinstrutors in lecture 19
        string askFName = "Write your name";
        
        
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();

        public Customer(string firstName, string lastName)
        {
            this.firstName= firstName;
            this.lastName = lastName;
        }

        public void printName()
        {
            Console.WriteLine("{0}, {1}",firstName, lastName);

        }
        //Deconstructor method used to clean up codeMet
        ~Customer()
        {

        }

    }
}
