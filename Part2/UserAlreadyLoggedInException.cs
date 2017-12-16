using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;
using System.IO;
using System.Runtime.Serialization;

namespace Part2
{
    [Serializable]
    class UserAlreadyLoggedInException: Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message): base(message)
        {

        }

        public UserAlreadyLoggedInException(string message, Exception innerException): base(message, innerException) 
        {

        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext  context) : base(info, context)
        {

        }
    }
   

}
