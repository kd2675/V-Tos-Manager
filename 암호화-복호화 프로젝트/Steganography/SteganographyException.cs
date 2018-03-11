using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    public class SteganographySizeException : Exception
    {
        public SteganographySizeException() : base("You can not encrypt a string by its size.")
        {
        }

        public SteganographySizeException(string message) : base(message)
        {

        }

        public SteganographySizeException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
