using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    internal class InvalidArtistNameException : Exception
    {


        public InvalidArtistNameException() { }

        public InvalidArtistNameException(string message)
         : base(message)
        {

        }

        public InvalidArtistNameException(string message, Exception innerException)
     : base(message, innerException)
        { }
    }
}
