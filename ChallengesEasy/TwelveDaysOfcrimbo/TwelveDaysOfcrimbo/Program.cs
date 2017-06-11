using System;

namespace TwelveDaysOfcrimbo
{
    class Program
    {
        /// <summary>
        /// /r/dailyprogrammer
        /// [2016-12-19] Challenge #296 [Easy] The Twelve Days of Christmas
        /// Print out the lyrics of The Twelve Days of Christmas
        /// </summary>

        static void Main(string[] args)
        {          
            string[] Days = new string[12] { "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th",
                "10th","11th", "12th" };   
            
            string[] Lyrics = new string[12] {"a Partridge in a Pear Tree." ,"Two Turtle Doves" , "Three French Hens",
                "4 Calling Birds" ,"5 Gold Rings" ,"6 Geese a-Laying" ,"7 Swans a-Swimming" ,"8 Maids a-Milking" ,
                    "9 Ladies Dancing" , "10 Lords a-Leaping"  ,"11 Pipers Piping" ,"12 Drummers Drumming"};

            for (int i = 0; i < Days.Length; i++)
            {
               Console.WriteLine("On the {0} day of Christmas my true love sent to me", Days[i]);
                
               int j = i;

                while (j <= i)
                {
                    if (j != 0)
                    {
                        Lyrics[0] = "and Partridge in a Pear Tree.";
                        Console.WriteLine(Lyrics[j]);                       
                        j--;
                    }
                    else { Console.WriteLine(Lyrics[j]); break; }
                }
            }
            Console.ReadLine();
        }
    }
}
