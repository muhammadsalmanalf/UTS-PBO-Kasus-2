using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Praktek_2
{
    class RetailItem
    {
        private String description;
        private int unitsOnHand;
        private double price;

        public RetailItem(String x, int y, double z)
        {
            description = x;
            unitsOnHand = y;
            price = z;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String x)
        {
            description = x;
        }

        public int getUnitsOnHand()
        {
            return unitsOnHand;
        }

        public void setUnitsOnHand(int y)
        {
            unitsOnHand = y;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double z)
        {
            price = z;
        }
    }
}
