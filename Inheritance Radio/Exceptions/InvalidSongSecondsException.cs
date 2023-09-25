using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    public class InvalidSongSecondsException : Exception
    {
        public InvalidSongSecondsException() { }

        public InvalidSongSecondsException(string message)
         : base(message)
        {

        }

        public InvalidSongSecondsException(string message, Exception innerException)
     : base(message, innerException)
        { }


    }
}
