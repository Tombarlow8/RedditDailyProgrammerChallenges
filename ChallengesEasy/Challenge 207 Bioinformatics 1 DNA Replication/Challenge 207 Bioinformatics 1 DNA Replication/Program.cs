using System;

namespace Challenge_207_Bioinformatics_1_DNA_Replication
{
    class Program
    {
        /// <summary>
        /// [2015-03-23] Challenge #207 [Easy] Bioinformatics 1: DNA Replication
        /// https://www.reddit.com/r/dailyprogrammer/comments/2zyipu/20150323_challenge_207_easy_bioinformatics_1_dna/
        /// </summary>
        static void Main(string[] args)
        {
            char[] input = "AATGCCTATGGC".ToCharArray();

            Console.WriteLine(input);

            foreach (char letter in input)
            {
                switch (letter)
                {
                    case 'A': Console.Write("T"); break;
                    case 'T': Console.Write("A"); break;
                    case 'G': Console.Write("C"); break;
                    case 'C': Console.Write("G"); break;
                    default:
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
