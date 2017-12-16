using System;
using System.IO;
using System.Runtime;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in- No Duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex1) {
                Console.WriteLine(ex1.Message);
            }

            Customer[] myCust = new Customer[3] ;
            myCust[0] = new Customer();
            myCust[1] = new Customer();
            myCust[2] = new Customer();

            myCust[0].setName("Mark");
            myCust[0].setGeneder(1);

            myCust[1].setName("Mary  ");
            myCust[1].setGeneder(2);

            myCust[2].setName("Sam");
            myCust[2].setGeneder(0);









            foreach (Customer customer in myCust)
            {
                Console.WriteLine("Name = {0} &&  Gender = {1}", customer.getName(), wordGender( customer.getGeneder()));
            }

           
            Console.ReadKey();
                }
        public static string wordGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";

                case 1:
                    return "Male";

                case 2:
                    return "Female";

                default:
                    return "Invalid Option";

            }

        }
    }
    
}
