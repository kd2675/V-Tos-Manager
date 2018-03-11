using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARIACryptography.NSRI.ARIA
{
    public class InvalidKeyException : Exception
    {
        public InvalidKeyException(string message)
            : base(message)
        {
        }
    }
}
