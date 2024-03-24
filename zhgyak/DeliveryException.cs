using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public class DeliveryException : Exception
    {
        public DeliveryException(string message): base(message) { }
    }
}
