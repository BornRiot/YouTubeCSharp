using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectA.TeamA;
// Aliases can be used to reference namespaces
// Example using PATA = ProjectA.TeamA;
namespace YouTubeCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // illustrates the use of pass by value method
            int i = 0;
            Method_Parameters p = new Method_Parameters();
            p.MyMehtod(i);
            Console.WriteLine(i);

            //illustrates the use of pass by reference method
            int d = 0;
            Method_Parameters o = new Method_Parameters();
            o.Refmethod(ref d);
            Console.WriteLine(d);

            //Pass by using out parameters
            Method_Parameters q = new Method_Parameters();
            int myMultiple = 0;
            int mySum = 0;
            q.Calculate(10, 20, out mySum, out myMultiple);
            Console.WriteLine("mySum = {0} & myMultiple = {1}",mySum, myMultiple);

            //Passing param arrays
            Method_Parameters x = new Method_Parameters();
            int[] myArray = new int[3];
            myArray[0] = 105;
            myArray[1] = 106;
            myArray[2] = 107;
            x.MyParaMethod(myArray);

            //Demonstrating the use of namespaces 
            //Placed using directive call method from Team A
            A.Print();
            //Using fully qualified name to envoke Print Method for Team  B
            projectA.TeamB.A.Print();

            //Using Prohject Reference to call methods from Team C & D
            //Reference from Team C
            ProjectA.TeamC.A.Print();
            //Reference from Team D
            ProjectA.TeamD.A.Print();


            //Demonstrates the use of the Customer class
            Console.Write("What is your frist name:");
            string takeFName = Console.ReadLine();

            Console.Write("What is your last name:");
            string takeLName = Console.ReadLine();
            Customer c1 = new Customer(takeFName,takeLName);
            c1.printName();
            Console.ReadKey();
        }
    }
}
