using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak
{
    public class Courier
    {
        IDeliverable[] packages;
        public int weight { get; }

        public Courier(int length)
        {
            packages = new IDeliverable[length];
        }

        public void PickUpItem(IDeliverable item)
        {
            int index = 0;
            for (int i = 0; i < packages.Length; i++)
            {
                if (packages[i] == null) {
                    packages[i] = item;
                } else
                {
                    throw new DeliveryException("A csomag nem fér el");
                }
            }
        }

        public IDeliverable[] FragilesSorted()
        {
            int num = 0;
            for (int i = 0; i < packages.Length; i++)
            {
                if (packages[i] is FragileParcel)
                {
                    num++;
                }
            }

            IDeliverable[] sortedPackages = new IDeliverable[num];

            int index = 0;
            for (int i = 0; i < packages.Length; i++)
            {
                if (packages[i] is FragileParcel)
                {
                    sortedPackages[index] = packages[i];
                    index++;
                }
            }

            Array.Sort(sortedPackages);
            return sortedPackages;
        }
    }
}
