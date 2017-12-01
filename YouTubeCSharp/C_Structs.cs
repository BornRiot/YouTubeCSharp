using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    public class C_Structs
    {
       public struct Customer
        {
            private int _id;
            private string _Name;

            public int Id { get => _id; set => _id = value; } //Auto generated propety
            public string Name { get => _Name; set => _Name = value; } //Auto generated propety

            public  Customer(string Name, int ID) //Constructor for property
            {
               this._Name = Name;
                this._id = ID;            }

            public void PrntInfo()
            {
                Console.WriteLine("Costuomer ID = {0} && Name = {1}", this._id, this._Name);
            }

           
        }
    }
}
