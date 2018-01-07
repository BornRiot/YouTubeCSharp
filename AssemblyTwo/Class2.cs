using System;
using AssemblyOne; 
namespace AssemblyTwo
{
    public class AssemblyTwoClassI: AssemblyOneClassI
    { public void getAssembly()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            //A1.ID = 103;
            //Cannot access variable ID due to being marked as internal

            AssemblyOneClassI A7 = new AssemblyOneClassI();
            base.newID = 21;
            //Can access variable newId due to being marked protected internal
            //and inheriting the AssemblyOneClassI 
        }
    }
}
