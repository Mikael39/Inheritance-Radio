using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    internal class InvalidSongNameException : Exception
    {

        public InvalidSongNameException() { }

        public InvalidSongNameException(string message)
         : base(message)
        {

        }

        public InvalidSongNameException(string message, Exception innerException)
     : base(message, innerException)
        { }


    }
}
