using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    public class basket 
    {
        // A list that will accept objects of type clothes
        List<clothes> clothesList = new List<clothes>();
        // Used to store total cost of clothes
        int totalCost;
        // Method to add clothes objects to the basket
        public void Add(clothes clothes)
        {
            clothesList.Add(clothes);
        }

        // Method to calculate the total cost of items in the basket 
        public int getTotalPrice()
        {
            for (int i = 0; i < clothesList.Count(); i++)
            {
                totalCost += clothesList[i].getPrice();
            }

            return totalCost;
        }
    }
}
