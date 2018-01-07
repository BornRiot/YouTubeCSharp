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
        private int _gender;
        

        public void setName(string Name)
        {
            _Name = Name;

        }

        public string getName()
        {
            return _Name;

        }

        public void   setGeneder(int gender)
        {
            _gender = gender;
        }

        public int getGeneder()
        {
            return _gender;
        }




    }
    
}
