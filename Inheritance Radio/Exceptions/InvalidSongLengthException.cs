using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    internal class InvalidSongLengthException : Exception
    {

        public InvalidSongLengthException() { }

        public InvalidSongLengthException(string message)
         : base(message)
        {

        }

        public InvalidSongLengthException(string message, Exception innerException)
     : base(message, innerException)
        { }
    }
}
