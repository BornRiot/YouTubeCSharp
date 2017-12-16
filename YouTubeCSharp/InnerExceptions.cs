using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YouTubeCSharp
{ //Go over inner exception from another resource
    public class InnerExceptions
    {
        public void getInnerExcept() {
            try {


                try
                {
                    Console.WriteLine("enter first number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter second number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                    int Result = FN / SN;
                    Console.WriteLine("Result is:{0}", Result);
                }
                catch (Exception ex1)
                { string filePath = @"C:\Users\Marvin\Desktop\TubeCSharpFiles\Log29.txt";
                    StreamWriter sw = new StreamWriter(filePath);

                        if (File.Exists(filePath))
                        {
                        sw.Write(ex1.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex1.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem. Please try again later");
                        Console.WriteLine(ex1.Message);
                        Console.WriteLine(ex1.StackTrace);
                        }
                        else {
                        throw new FileNotFoundException(filePath + "is not present", ex1);
                        } }
                
            }
            catch (Exception exceptThis){
                Console.WriteLine("Current exception = {0} ", exceptThis.GetType().Name);
                if (exceptThis.InnerException != null)
                {
                    Console.WriteLine("Inner exception = {0}", exceptThis.InnerException.GetType().Name);
                }
            }

        }
    }
}
