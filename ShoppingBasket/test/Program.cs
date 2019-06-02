using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Program
    {
        static void Main(string[] args)
        {

            basket basket = new basket();
            tshirt shirt = new tshirt();
            golfer golferShirt = new golfer();
            jeans jean = new jeans();
            formalPants formalPant = new formalPants();

            // Setting the size of the clothes 
            shirt.size = "s";
            golferShirt.size = "m";
            jean.size = "l";
            formalPant.size = "m";

            // Adding items to the basket to get each price 
            basket.Add(shirt);
            basket.Add(golferShirt);
            basket.Add(jean);
            basket.Add(formalPant);

            // Total price of items within the basket
            Console.WriteLine($"Your total price is: R{basket.getTotalPrice()}");
            Console.ReadLine();

        }
    }
}
