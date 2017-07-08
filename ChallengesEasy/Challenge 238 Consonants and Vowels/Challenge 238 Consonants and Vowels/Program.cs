using System;
using System.Collections.Generic;

namespace Challenge_238_Consonants_and_Vowels
{
    class Program
    {
        /// <summary>
        /// [2015-10-26] Challenge #238 [Easy] Consonants and Vowels
        /// https://www.reddit.com/r/dailyprogrammer/comments/3q9vpn/20151026_challenge_238_easy_consonants_and_vowels/
        /// </summary>>
        static void Main(string[] args)
        {
            bool correctinput = true;

            List<string> newWordList = new List<string>();

            Random rand = new Random();

            string[] vowels = { "a", "e", "i", "o", "u" };
            string[] consonants = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t",
                "v", "w", "x", "y", "z" };

            while (true)
            {
                Console.WriteLine("input a line of 'c's and 'v's to create a new word");

                string input = Console.ReadLine();

                input = input.ToLower();

                foreach (char letter in input.ToCharArray())
                {
                    if (letter == 'c')
                    {
                        newWordList.Add(GetLetter(letter));
                    }
                    else if (letter == 'v')
                    {
                        newWordList.Add(GetLetter(letter));
                    }
                    else
                    {
                        correctinput = false;
                        Console.WriteLine("Input is not made up of 'c's or 'v's ");
                    }
                }

                if (correctinput)
                {
                    string newWord = string.Join("", newWordList);

                    Console.WriteLine("{0} was changed to : {1}", input, newWord);

                    newWordList.Clear();
                }

            }

            string GetLetter(char letter)
            {
                string newLetter = "";

                if (letter == 'c')
                {
                    return newLetter = consonants[rand.Next(0, consonants.Length)];                    
                }
                else if (letter == 'v')
                {
                    return newLetter = vowels[rand.Next(0, vowels.Length)];                    
                }

                return newLetter;
            }
        }
    }
}
