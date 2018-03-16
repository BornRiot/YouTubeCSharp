using System;
using System.IO;
using System.Runtime;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Part2
{
    class Program : Access_Modifiers
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

            Customer[] myCust = new Customer[4];
            for (int i = 0; i < myCust.Length; i++)
            {
                myCust[i] = new Customer();
            }


            myCust[0].setName("Mathew");
            myCust[0].setGeneder(1);

            myCust[1].setName("Mark");
            myCust[1].setGeneder(2);

            myCust[2].setName("Luke");
            myCust[2].setGeneder(1);

            myCust[3].setName("Mary  ");
            myCust[3].setGeneder(2);


            Cust_Enum[] enumCust = new Cust_Enum[1];

            for (int j = 0; j < enumCust.Length; j++)
            {
                enumCust[j] = new Cust_Enum();
            }

            enumCust[0] = new Cust_Enum {

                _gender = Gender.Unknown
            };
            enumCust[0].setName("John");

            foreach (Cust_Enum customer in enumCust)
            {
                Console.WriteLine("This is from enumGender. Name = {0} &&  Gender = {1}", customer.getName(), enumGender(customer._gender));
            }

            foreach (Customer customer in myCust)
            {
                Console.WriteLine("Name = {0} &&  Gender = {1}", customer.getName(), wordGender(customer.getGeneder()));
            }

            //The following code corresponds to video 47 of tutorial 
            int[] Values = (int[])Enum.GetValues(typeof(Enums_Explained.Gender));
            foreach (int val in Values)
            {
                Console.WriteLine(val);
            }

            string[] Names = Enum.GetNames(typeof(Enums_Explained.Gender));
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

            short[] Values2 = (short[])Enum.GetValues(typeof(Gender1));
            foreach (short val in Values)
            {
                Console.WriteLine(val);
            }

            //explicit type cast conversion of an enum is as follows:
            Gender thiGen = (Gender)3;
            int myGen = (int)Gender.Male;


            //Explicit casting of the Season enum using the gender enum
            Gender thisGen = (Gender)season.Spring;

            //The following codes pertains to lesso 49 Access Modifiers
            Access_Modifiers c1 = new Access_Modifiers
            {
                ID = 5
            };
            Console.WriteLine(c1.ID);
            CorporateCustomer newCorp = new CorporateCustomer();
            newCorp.PrintID();

            //Demonstrating the use of concetps taught in video 52
            Calculator.Add(23,9); //Indicates that the method being use is obsolete 

            //Use of non obsolete method 
            Calculator.Add(new List <int>() { 10, 25, 39 });

            //The following code corresponds to video 53 reflection
            Reflection myReflect = new Reflection();
            //Use tpye to get the Type reference of the class
            Type T = Type.GetType("Part2.Reflection");

            //Another way to get typeof
            Type T1 = typeof(Reflection);

            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the name = {0}", T.Name);
            Console.WriteLine("Just the Namespace= {0}", T.Namespace);

            Console.WriteLine("Propeties in Reflection Class");
            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " "  + property.Name);
            }


            Console.WriteLine("Methods in Reflection Class");
            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("Constructors in Reflection Class ");
            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }

            //The Following code pertains to video 55 of the tutorials
            Assembly executingAssembly =  Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Part2.LateBinding");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("getFullName");
            string[] parameters = new string[2];
            parameters[0] = "Marvin";
            parameters[1] = "DaCosta";
            string FullName= (string)getFullNameMethod.Invoke(customerInstance,parameters);
            Console.WriteLine("Full Name = {0}", FullName);

            //The following code corresponds to video 56 generics
            //Using tied or ecplicitly specified data type for method
            bool Equal = Generics.IntAreEqual(1,5);
            bool Equal2 = Generics.AreEqual(10, 1);
            Equal2 = Generics.AreEqual(15, 1);
            Equal2 = Generics.AreEqual("A", "A");

            //The follwing code pertains to video 57 "why you should override to string
            int toStringNum = 10;
            Console.WriteLine(toStringNum);
            Override_ToString C1 = new Override_ToString
            {
                firstName = "Mike",
                lastName = "Turner"
            };
            Console.WriteLine(C1.ToString());

            //The following ccode corresponds to video 58 of the tutorials
            Equals_ToOverride E1 = new Equals_ToOverride();
            E1.firstName = "Simon";
            E1.lastName = "Garfunkle";

            Equals_ToOverride E2 = new Equals_ToOverride();
            E2.firstName = "Simon";
            E2.lastName = "Garfunkle";

            Console.WriteLine(E1 == E2);
            Console.WriteLine(E1.Equals(E2));

            //The following code corresponds to video 59 
            ConVtoStringvToString F1 = null;
            string str = Convert.ToString(F1);
            //string str2 = F1.ToString(); //Produces a null referrence error 
            Console.WriteLine(str);
            //Console.WriteLine(str2);

            //the following code pertains to video 60
            string myString = "Hellow ";
            myString += "Goodbye ";
            myString += "Hate to see you go ";
            myString += "But love to watch you leave ";
            Console.WriteLine(myString);


            StringBuilder mySung = new StringBuilder("Hello");
            mySung.Append("Gang Gang");
            mySung.Equals("Jamaica");
            Console.WriteLine(mySung.ToString());
            //String Builder offers better performaance for heavy string manipulation due to not storing objects on the heap


            Console.ReadKey();



        }
        public class CorporateCustomer: Access_Modifiers
        {

            //Using protected  type member

            public void PrintID()
            {
                CorporateCustomer CC = new CorporateCustomer();
                Console.WriteLine(thisID);
            }
        }
        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

        //To change the default value of an enum from int to something else use:
        public enum Gender1 : short 
        {
            //You can change each value of the members in an enum 
            Male = 1, //As demonstrated here 
            Female,
            Unknown
        }

        public enum season
        {
            Winter,
            Spring,
            Summer
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
        public static string enumGender(Gender gender2)
        {
            switch (gender2)
            {
                case Gender.Unknown:
                    return "Unknown";

                case Gender.Male:
                    return "Male";

                case Gender.Female:
                    return "Female";

                default:
                    return "Invalid Option";

            }

        }

    } }
