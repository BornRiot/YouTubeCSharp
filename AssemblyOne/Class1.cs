using System;
namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 101;
        protected internal int newID = 103;
    }

    public class AssemblyOneClassII
    {
        public void SimpleMethodII()
        {
            AssemblyOneClassI A3 = new AssemblyOneClassI();
            Console.WriteLine(A3.newID);
        }
        public void SimpleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}
