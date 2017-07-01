using System;

namespace Challenge_316_Sydney_tourist_shopping_cart
{
    class Program
    {
        /// <summary>
        /// [2017-05-24] Challenge #316 [Intermediate] Sydney tourist shopping cart
        /// https://www.reddit.com/r/dailyprogrammer/comments/6d29om/20170524_challenge_316_intermediate_sydney/
        /// </summary>

        static void Main(string[] args)
        {
            string[] order1 = { "OH", "OH", "OH", "BC","SK" };
            string[] order2 = { "OH", "BC", "BC", "SK", "SK" };
            string[] order3 = { "BC", "BC", "BC", "BC", "BC","BC", "OH", "OH" };
            string[] order4 = { "SK", "SK", "BC" };

            string[][] orders = { order1, order2, order3, order4 };

            ShoppingCart Sp = new ShoppingCart();

            foreach (var order in orders)
            {
                Sp.GetOrder(order);
                Sp.ViewCart();
                Console.WriteLine("Total = " + Sp.OrderTotal(order));
                Sp.EmpytCart();
            }

            Console.ReadLine();
        }
    }
}
