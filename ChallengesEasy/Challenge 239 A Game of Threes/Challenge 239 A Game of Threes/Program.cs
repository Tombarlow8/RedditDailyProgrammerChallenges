using System;

namespace Challenge_239_A_Game_of_Threes
{
    class Program
    {
        /// <summary>
        /// [2015-11-02] Challenge #239 [Easy] A Game of Threes
        /// https://www.reddit.com/r/dailyprogrammer/comments/3r7wxz/20151102_challenge_239_easy_a_game_of_threes/
        /// </summary>
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter the number :");

            int input = Convert.ToInt32(Console.ReadLine());

            while (input != 1)
            {               
                if (input % 3 == 0)
                {
                    input = input / 3;
                    Console.WriteLine("Divided by 3 to get {0}", input);                        
                }
                else
                {
                    if ((input + 1) % 3 == 0)
                    {
                        input = (input + 1) / 3;
                        Console.WriteLine("Added 1 then divided by 3 to get {0}", input);                           
                    }
                    else if ((input - 1) % 3 == 0)
                    {
                        input = (input - 1) / 3;
                        Console.WriteLine("Subtracted 1 then divided by 3 to get {0}", input);                            
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
