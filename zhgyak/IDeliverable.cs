using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public interface IDeliverable
    {
        int Weight { get; set; }
        string Address { get; set; }
        double CalculatePrice(bool fromLocker);
    }
}
