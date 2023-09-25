using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    internal class InvalidSongMinutesException : Exception
    {

        public InvalidSongMinutesException() { }

        public InvalidSongMinutesException(string message)
         : base(message)
        {

        }

        public InvalidSongMinutesException(string message, Exception innerException)
     : base(message, innerException)
        { }
    }
}
