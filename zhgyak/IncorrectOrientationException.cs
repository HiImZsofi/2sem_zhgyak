using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public class IncorrectOrientationException : DeliveryException
    {
        public FragileParcel Parcel
        {
            get;
            private set;
        }
        public IncorrectOrientationException(FragileParcel parcel) : base("Nem jó a csomag elhelyezési módja")
        {
            Parcel = parcel;
        }
    }
}
