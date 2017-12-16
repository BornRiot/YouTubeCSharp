using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectA.TeamA;
using System.IO;
// Aliases can be used to reference namespaces
// Example using PATA = ProjectA.TeamA;
namespace YouTubeCSharp
{
    public delegate void SampleDelegate();
    public delegate int SampleReturnDelegate();

    public class Program : Abstract_Class.Customer, ExplicitInterfaces.I1, ExplicitInterfaces.I2
    //Static variables are allocated for the lifetime of the program
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
            Console.WriteLine("mySum = {0} & myMultiple = {1}", mySum, myMultiple);

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

            //Using Project Reference to call methods from Team C & D
            //Reference from Team C
            ProjectA.TeamC.A.Print();
            //Reference from Team D
            ProjectA.TeamD.A.Print();

            //Demonstrates the use of the Customer class
            Console.Write("What is your frist name:");
            string takeFName = Console.ReadLine();

            Console.Write("What is your last name:");
            string takeLName = Console.ReadLine();
            Customer c1 = new Customer(takeFName, takeLName);
            c1.printName();

            //Demonstrates the use of the circle class
            Circle c2 = new Circle(5); //Circle takes an arugment if 5
            float Area1 = c2.CalculateArea();
            Console.WriteLine("The area of the circle is {0}", Area1);

            Circle c3 = new Circle(6);
            float Area2 = c3.CalculateArea();
            Console.WriteLine("The area of the circle is {0}", Area2);
            Circle.Print(); // Uses Curcle object reference to call Print method

            Employee.FullTimeEmployee FTE = new Employee.FullTimeEmployee();
            FTE.Fname = "Marvin";
            FTE.Lname = "DaCosta";
            FTE.yearlySalary = 20000.36F;
            FTE.PrintFullName();
            Console.WriteLine("Salary is " + FTE.yearlySalary);
            //You can use multi-level inheritance in C# to reference porperties of bases classes
            //Example
            A A1 = new A(); //Inherited from partime  employee class

            //
            Parent.ChildClass CC = new Parent.ChildClass();

            //
            Employee2.FullTimeEmployee E2FTE = new Employee2.FullTimeEmployee();
            E2FTE.firstName = ("Mikle");
            E2FTE.LastName = ("Jack");
            E2FTE.PrintFullName();

            Employee2.PartTimeEmployee E2PTE = new Employee2.PartTimeEmployee();
            E2PTE.firstName = ("Mark");
            E2PTE.LastName = ("Jackson");
            E2PTE.PrintFullName(); //Another way of using the base class method

            Employee2.PartTimeEmployee E2PTE1 = new Employee2.PartTimeEmployee();
            E2PTE1.firstName = ("Mark");
            E2PTE1.LastName = ("Jackson");
            E2PTE1.PrintFullName(); //Another way of using the base class method

            //Write out Part 23 of video series
            //Illustrates the use of polymorphism 
             Employee3[] emPloyee = new Employee3[4];
            emPloyee[0] = new Employee3.PartTimeEmployee();
            emPloyee[1] = new Employee3.FullTimeEwmployee();
            emPloyee[2] = new Employee3.TemporaryEmployee();
            emPloyee[3] = new Employee3();
            

            foreach (Employee3 e in emPloyee)
            {
                e.PrintFullName();
            }

            //base Class Example using the print method
            BaseClass B = new DerivedClass();
            B.Print();
            B.Print1();

            Why_Properties.Student C1 = new Why_Properties.Student();
            C1.ID = -101; //Should not be able to edit variables
            C1.Name = null;
            C1.Passark = 0;

            //Using private student class with get and set methods
            Why_Properties.PvtStudent C2 = new Why_Properties.PvtStudent();
            C2.SetId(1101);

            //Why properties class redone with built in C# get and set fuctions
            Properties.PvtStudent C9 = new Properties.PvtStudent();
            C9.setID = 41;
            C9.setName = "Marvin";

            Console.WriteLine("Student {0} name is {1}", C9.setID, C9.setName);

            //Print an example from the C_Structs class
            C_Structs.Customer nyCust = new C_Structs.Customer("Mark", 101); //intialize though fields   
            nyCust.PrntInfo();

            C_Structs.Customer thisCust = new C_Structs.Customer();
            //Initialize through public fields
            thisCust.Id = 103;
            thisCust.Name = "Montez";
            thisCust.PrntInfo();

            //Using object initializer syntax
            C_Structs.Customer CB = new C_Structs.Customer { Name = " Mark",
                Id = 109
            };

            //Differences between structs and classes
            //Demonstrates the differences between obect referrences variables types and  object types 
            //Object refference variables are stored on the stack whiile objects are stored on the heap 
            //Objects include things such as names 
            //Value types are destroyed immediately after the scope is  lost , objects themselves are stored in memory until the garbage is collected
      
            int  z= 0;
            if(z == 10)
            {
                int j = 20;
                Clss_StructsComp.Customer newC = new Clss_StructsComp.Customer();
                newC.Id = 101;
                newC.Name = "Mark";

            }

            int u = 10;
            int y = u;
            u = u + 1;
            Console.WriteLine("u = {0}, && and y = {1}", u, y);

            //Illlustrates the use of objectt referrence value strage
            Clss_StructsComp.Customer theCust = new Clss_StructsComp.Customer();
            theCust.Id = 101;
            theCust.Name = "Mike";

            Clss_StructsComp.Customer theCust2 = theCust;
            theCust2.Name = "Mickey";
            Console.WriteLine("Custmer 1 name is {0} and Customer 2 is {1}", theCust.Name, theCust2.Name);

            
            //Classes can have destructors but structs cant have destructors

            //Demonstrates using the interface class
            Interface_C.Customer mike = new Interface_C.Customer();
            mike.print();
            mike.print2();
            Interface_C.ICustomer2 mw = new Interface_C.Customer();
            mw.print2();
            //Explicit interface implementation
            //There was more info to go over on this lecture (rewatch)
            Program P = new Program();
            ((ExplicitInterfaces.I1)P).InterFaceMethod();
           

            Abstract_Class.Customer UY = new Program();
            UY.Print();

            //Implementing multiple class inheritance
            //Watch over video to get concept
            Multi_Class_Inherit.AB AV = new Multi_Class_Inherit.AB();
            AV.AMethod();
            AV.BMethod();

            //Write program for Delegates tutorial 
            //Program written
            Delegates.HelloFunctionDelegate del = new Delegates.HelloFunctionDelegate(Delegates.hello);
            del("Hello");


            //The following code correspond to the Delegates Usage Class and viseo
            List<DelegateUsage.Employee> empList = new List<DelegateUsage.Employee>();
            empList.Add(new DelegateUsage.Employee() {ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
            DelegateUsage.PromoteEmployee(empList);

            //part two of the delgates videos using updated method
            List<DelegateUsage2.Employee> empList2 = new List<DelegateUsage2.Employee>();
            empList2.Add(new DelegateUsage2.Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            DelegateUsage2.IsPromotable Ispromote = new DelegateUsage2.IsPromotable(Promote);
            DelegateUsage2.PromoteEmployee(empList2, Ispromote);


            //Use of MultiCast Delegates
            //A delegate pointing to more than 1 function is a mukticast delegate
        SampleDelegate del1, del2, del3, del4;
       del1 = new SampleDelegate(SampleDelegateOne);
        del2 = new SampleDelegate(SampleDelegateTwo);
        del3 = new SampleDelegate(SampleDelegateThree);
        del4 = del1 + del2 + del3; // You can remve a delegate by using the - sgn to take a delgate away
        del4 -= del2;
        del4();
            //Another way assigning delegates
            SampleDelegate del0 = new SampleDelegate(SampleDelegateOne);
            del0 += SampleDelegateTwo;

            //Assigbnmethods with return values for delegates
            //Go over the last 5 mins of video
            SampleReturnDelegate del7 = new SampleReturnDelegate(SampleDelegateSIx);
            del7 += SampleDelegateZero;

            //Output of lecture 40 program
           ExceptionHandling testExcept = new ExceptionHandling();
            testExcept.DisplayStuff();

            //Output of lecture video 41
            //Go over inner exception from another resource
            InnerExceptions displayInner = new InnerExceptions();
            displayInner.getInnerExcept();

    




        Console.ReadKey();

           

        }
        public static int SampleDelegateZero()
        {
            return 0;
            
        }
       


        public static void SampleDelegateOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");

        }

        public static void SampleDelegateTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");

        }

        public static void SampleDelegateThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");

        }

        public static void SampleDelegateFour()
        {
            Console.WriteLine("SampleMethodFour Invoked");
        }

        public static int SampleDelegateSIx()
        {
            return 6;
        }
        public static bool Promote(DelegateUsage2.Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else { return false; }
        }
        public override void Print()
        {
            Console.WriteLine("This is a print method");
        }

        void ExplicitInterfaces.I1.InterFaceMethod()
        {
            Console.WriteLine("This is a line");

        }

        void ExplicitInterfaces.I2.InterFaceMethod()
        {
            Console.WriteLine("This is a line");

        }

    }
}
