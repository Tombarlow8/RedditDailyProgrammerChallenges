using System;

namespace Challenge_291_Goldilocks__Bear_Necessities
{
    class Program
    {
        /// <summary>
        /// [2016-11-07] Challenge #291 [Easy] Goldilocks' Bear Necessities
        /// https://www.reddit.com/r/dailyprogrammer/comments/5bn0b7/20161107_challenge_291_easy_goldilocks_bear/
        /// </summary>
        static void Main(string[] args)
        {

            int[] chairWeight = { 100, 297, 66, 257, 276, 280, 219, 254, 86, 206, 71,104, 238, 52, 129, 144,
                157, 210, 11, 268, 261, 12, 186, 174, 77, 54, 174, 16, 59, 290, 248 };
 
            int[] porridgeTemp = { 120, 90, 110 ,113, 191, 129, 163, 193, 153 , 147, 137, 40, 127, 146, 197,
                59, 124, 59, 54, 119, 121, 189, 108, 21 ,18 ,90 ,52 , 129, 181, 123, 132};
                       
            for(int i = 1; i < chairWeight.Length; i++)
            {
                if (chairWeight[i] >= chairWeight[0] && porridgeTemp[i] <= porridgeTemp[0])
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
