using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Cust_Enum
    {
        private string _Name;
        public Program.Gender _gender { get; set; }


        public void setName(string Name)
        {
            _Name = Name;

        }

        public string getName()
        {
            return _Name;

        }

        




    }
}
