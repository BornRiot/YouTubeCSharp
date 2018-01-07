using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Reflection
    {
        public int Id { get; set; }
        public string Name { get; set;  }

        public Reflection(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Reflection()
        {
            this.Id = -1;
            this.Name = String.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
