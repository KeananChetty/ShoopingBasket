using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class formalPants : clothes
    {
        public string size; // to store Formal Pants size
        public int price;   // to store Formal Pants price

        // implementing abstract method for Formal Pants
        public override int getPrice()
        {
            // Formal Pants size = small
            if (size == "s")
            {
                price = 10 + 30;
            }
            // Formal Pants size = medium
            else if (size == "m")
            {
                price = 20 + 30;
            }
            // Formal Pants size = large
            else if (size == "l")
            {
                price = 30 + 30;
            }

            return price;
        }
    }
}
