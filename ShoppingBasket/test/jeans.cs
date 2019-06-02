using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class jeans : clothes
    {
        public string size; // to store jeans size
        public int price;   // to store jeans price

        // implementing abstract method for jeans
        public override int getPrice()
        {
            // jeans size = small
            if (size == "s")
            {
                price = 10;
            }
            // jeans size = medium
            else if (size == "m")
            {
                price = 20;
            }
            // jeans size = large
            else if (size == "l")
            {
                price = 30;
            }

            return price;
        }
    }
}
