using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    public class Why_Enums
    {
    }

    public class  Customer{

        private string _Name = "";
        private int _gender = 0;
         

        public void setName(string Name)
        {
            this._Name= Name;

        }

        public string getName()
        {
            return this._Name;

        }

        public void   setGeneder(int gender)
        {
            this._gender  = gender;
        }

        public int getGeneder()
        {
            return this._gender;
        }
    }
    
}
