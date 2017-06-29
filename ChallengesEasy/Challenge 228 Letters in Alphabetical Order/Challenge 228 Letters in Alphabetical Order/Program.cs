using System;

namespace Challenge_228_Letters_in_Alphabetical_Order
{
    class Program
    {
        /// <summary>
        /// [2015-08-17] Challenge #228 [Easy] Letters in Alphabetical Order
        /// https://www.reddit.com/r/dailyprogrammer/comments/3h9pde/20150817_challenge_228_easy_letters_in/    
        /// </summary>

        static void Main(string[] args)
        {
            string[] words = {"billowy", "biopsy", "chinos", "defaced", "chintz", "sponged", "bijoux",
                "abhors", "fiddle", "begins", "chimps", "wronged" };

            foreach (string word in words)
            {                
                char[] Letters = new char[word.Length];

                for (int i = 0; i < word.Length; i++)
                {
                    word.CopyTo(0, Letters, 0, word.Length);
                }

                Array.Sort(Letters);              

                string sorted = new string(Letters);

                if (sorted == word)
                {
                    Console.WriteLine("{0} In Order", word);
                }
                else
                {                    
                    Array.Reverse(Letters);

                    string reversed = new string(Letters);

                    if (reversed == word)
                    {
                        Console.WriteLine("{0} Reverse Order", word);
                    }
                    else
                    {
                        Console.WriteLine("{0} Not In Order", word);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
