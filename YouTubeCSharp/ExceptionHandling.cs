using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YouTubeCSharp
{
    class ExceptionHandling
    {
        public void DisplayStuff()
        {
            StreamReader myReader = null;
            int thisVariable = 12;

            try
            {//Pertains to lecture 40
                 myReader = new StreamReader(@"C:\Users\javvytech\Desktop\MJavvy Testing\TutorialFiles\myDoc.txt");
                Console.WriteLine(myReader.ReadToEnd());
              
            }
            catch(Exception myEx)
            {
                Console.WriteLine(myEx.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(myEx.StackTrace);
            }
            finally
            { //It is imperative to include a finally block method for methods and variables  to close stream reader resources
              // finally block is guranteed to be executed to release resources
                if (myReader != null) //Check condition to see if strem reder has a value
                { myReader.Close(); }
                Console.WriteLine("Finally Block");
                
            }

            

        }
    }
}
