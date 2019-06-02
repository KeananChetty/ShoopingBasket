using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class golfer : clothes 
    {
        public string size; // to store golfer size
        public int price;   // to store golfer price

        // implementing abstract method for golfer
        public override int getPrice()
        {
            // golfer size = small
            if (size == "s")
            {
                price = 10 * 2;
            }
            // golfer size = medium
            else if (size == "m")
            {
                price = 20 * 2;
            }
            // golfer size = large
            else if (size == "l")
            {
                price = 30 * 2;
            }

            return price;
        }
    }
}
