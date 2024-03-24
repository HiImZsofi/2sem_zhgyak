using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public class NormalParcel : Parcel
    {
        public NormalParcel(int weight, string address) : base(weight, address)
        {
            Random r = new Random();
            this.orientation = (Orientation)r.Next(3);
        }

        public override double CalculatePrice(bool fromLocker)
        {
            int basePrice = 500 + Weight;
            if(fromLocker) { basePrice -= 250; }
            return basePrice;
        }
    }
}
