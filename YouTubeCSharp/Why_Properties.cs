using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeCSharp
{
    class Why_Properties
    {
        public class Student
        {
            public int ID;
            public string Name;
            public int Passark;

        }

        public class PvtStudent
        {
            private int _ID;
            private string _Name;
            private int _Passark;

            public void SetId(int ID)
            {
                if (ID < 0)
                {
                    throw new Exception("Student ID cannot be negative");
                }
                this._ID = ID;
            }
            public int SetID()
            {
                return this._ID;

            }

            public void setName(string Name)
            {
                if (string.IsNullOrEmpty(this._Name))
                {
                    throw new Exception("Name cannot be null or empty");

                }
                this._Name = Name;
            }


                public string getName()
                {
                if (string.IsNullOrEmpty(this._Name))
                {
                    return "No Name";
                }
                return this._Name;
                
                }

            }
        }
    }

    

