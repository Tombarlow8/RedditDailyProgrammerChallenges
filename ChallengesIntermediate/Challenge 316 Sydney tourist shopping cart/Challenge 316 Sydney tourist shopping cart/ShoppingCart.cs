using System;
using System.Collections.Generic;

namespace Challenge_316_Sydney_tourist_shopping_cart
{
    class ShoppingCart
    {
        List<string> cartList = new List<string>();

        public void GetOrder(string[] order)
        {
            foreach (string item in order)
            {
                cartList.Add(item);
            }
        }

        public void ViewCart()
        {
            int itemNumber = 1;

            foreach (string item in cartList)
            {
                Console.WriteLine("{0}: {1}", itemNumber, item);
                itemNumber++;
            }
        }

        public int OrderTotal(string[] order)
        {
            //OH Opera house tour	$300.00
            //BC Sydney Bridge Climb	$110.00
            //SK Sydney Sky Tower	$30.00

            int orderTotal = 0;
            int OHcount = 0;
            int BCcount = 0;
            int SKcount = 0;
            int OHprice = 300;
            int BCprice = 110;
            int SKprice = 30;

            foreach (string item in cartList)
            {
                if (item == "OH")
                {
                    orderTotal += OHprice;
                    OHcount++;
                }
                if (item == "BC")
                {
                    orderTotal += BCprice;
                    BCcount++;
                }
                if (item == "SK")
                {
                    orderTotal += SKprice;
                    SKcount++;
                }
            }

            //applying discount

            if (OHcount % 3 == 0)
            {
                //We are going to have a 3 for 2 deal on opera house ticket.For example,
                //if you buy 3 tickets, you will pay the price of 2 only getting another one completely 
                //free of charge.
                orderTotal -= (OHprice * (OHcount / 3));
            }
            if (SKcount > OHcount && SKcount != 0 && OHcount != 0)
            {                
                //We are going to give a free Sky Tower tour for with every Opera House tour sold
                orderTotal -= (SKprice * (SKcount -= OHcount));                
            }
            if (OHcount > SKcount && SKcount != 0 && OHcount != 0)
            {
                //We are going to give a free Sky Tower tour for with every Opera House tour sold
                orderTotal -= (SKprice * SKcount);
            }
            if (BCcount >= 4)
            {
                //The Sydney Bridge Climb will have a bulk discount applied, where the price will drop $20, 
                //if someone buys more than 4
                orderTotal -= 20 * BCcount;
            }

            return orderTotal;
        }

        public void EmpytCart()
        {
            cartList.Clear();
        }
    }
}
