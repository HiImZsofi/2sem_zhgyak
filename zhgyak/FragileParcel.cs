using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public class FragileParcel : Parcel
    {
        public FragileParcel(int weight, string address, Orientation orientation) : base(weight, address)
        {
            this.orientation = orientation;
        }

        public override double CalculatePrice(bool fromLocker)
        {
            int basePrice = 1000 + this.Weight * 2;
            if(fromLocker) { throw new DeliveryException("A csomag nem adhato fel automatabol"); }
            return basePrice;
        }


    }
}
