using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Properties
    { //This class was created to implement the use of built in set and get methods in C#


        public class PvtStudent
        {

            private int _ID;
            private string _Name;
            private int _Passark;

           
            public int setID
            {
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Student ID cannot be negative");
                    }
                    this._ID = value;

                }
                get
                {
                    return this._ID;
                }
            }




            public string setName

            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Name cannot be null or empty");

                    }
                    this._Name = value;
                }
                get
                {

                    return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;



                }
            }

           

            public int getPassMark
            {
                get
                {
                    return this._Passark;
                }
            }





        }
    }
}


