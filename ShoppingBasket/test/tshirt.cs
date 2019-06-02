using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class tshirt : clothes
    {
        public string size;  // to store shirt size
        public int price;    // to store shirt price
        
        // implementing abstract method for tshirts
        public override int getPrice()
        {
            // shirt size = small
            if (size == "s")
            {
                price = 10;
            }
            // shirt size = medium
            else if (size == "m")
            {
                price = 20;
            }
            // shirt size = large
            else if (size == "l")
            {
                price = 30;
            }

            return price;
        }
    }
}
