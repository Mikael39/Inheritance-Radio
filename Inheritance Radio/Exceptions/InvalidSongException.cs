using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Radio.Exceptions
{
    [Serializable]
    public class InvalidSongException : Exception
    {

        public InvalidSongException() { }

        public InvalidSongException(string message)
      : base(String.Format("Invalid song.", message))
        {

        }






    }
}
