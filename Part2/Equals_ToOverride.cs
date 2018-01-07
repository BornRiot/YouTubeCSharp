using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Equals_ToOverride
    {
        public string firstName  { get; set;  }
        public string lastName { get; set; }

        public override bool Equals(object obj)
        {
            if( obj == null)
            {
                return false;
            }
            if(!(obj is Equals_ToOverride)){
                return false;
            }
            return this.firstName == ((Equals_ToOverride)obj).firstName &&
              this.lastName == ((Equals_ToOverride)obj).lastName;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }

    }
}
