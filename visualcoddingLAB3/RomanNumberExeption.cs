using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace visualcoddingLAB3
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
            : base(message)
        { }
    }
}
