using System;

namespace Challenge_254_Atbash_Cipher
{
    class Program
    {
        /// <summary>
        /// [2016-02-16] Challenge #254 [Easy] Atbash Cipher
        /// https://www.reddit.com/r/dailyprogrammer/comments/45w6ad/20160216_challenge_254_easy_atbash_cipher/
        /// </summary>
        static void Main(string[] args)
        {
            char[] alphabet = " abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] atbash = " zyxwvutsrqponmlkjihgfedcba".ToCharArray();

            string input = Console.ReadLine();

            char[] inputarray = input.ToCharArray();

            Console.WriteLine("you entered {0}",input);

            foreach (char letter in inputarray)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.Write(atbash[i]);                          
                    }                 
                }
            }
            Console.ReadLine();
        }
    }
}
