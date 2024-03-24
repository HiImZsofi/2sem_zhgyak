using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public enum Orientation
    {
        Arbitrary,
        Horizontal,
        Vertical
    }
    public abstract class Parcel : IDeliverable, IComparable
    {
        public int Weight { get; set; }
        public string Address { get; set; }
        public Orientation orientation { get; set; }

        public abstract double CalculatePrice(bool fromLocker);

        public int CompareTo(object? obj)
        {
            Parcel temp = (Parcel)obj;
            if (temp.Weight > this.Weight) return -1;
            if (temp.Weight < this.Weight) return 1;
            return 0; //ha megegyezik
        }

        protected Parcel(int weight, string address)
        {
            Weight = weight;
            Address = address;
        }

        protected Parcel(int weight, string address, Orientation orientation) : this(weight, address)
        {
            this.orientation = orientation;
        }

        public override string? ToString()
        {
            return $"Címzett: {this.Address} / Elhelyezés: {this.orientation} / Tömeg:{this.Weight} g";
        }
    }
}
