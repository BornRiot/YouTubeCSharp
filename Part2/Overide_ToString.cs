using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Override_ToString
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
