using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace zhgyak
{
    public class Envelope : IDeliverable
    {
        public int Weight { get; set; }
        public string Address { get; set; }

        string description;
        public double CalculatePrice(bool fromLocker)
        {
            int price = 0;
            if(Weight > 2000)
            {
                throw new OverweightException();
            }
            price = Weight <= 50 ? price = 200 : Weight < 500 ? price = 400 : price = 1000;
            return price;
        }

        public Envelope(int weight, string address, string description)
        {
            Weight = weight;
            Address = address;
            this.description = description;
        }

        public override string? ToString()
        {
            return $"Címzett: {this.Address} / Leírás: {this.description} / Tömeg:{this.Weight} g";
        }
    }
}
