 using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Access_Modifiers
    {
        //This class corresponds to lecture 49 of the tutorial 
        private int _id;
        protected int thisID= 109;

        public int ID
        {
            get{return _id; }
            set{_id = value;}


        }
    }
}
