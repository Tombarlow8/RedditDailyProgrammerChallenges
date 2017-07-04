using System;

namespace Challenge_261_verifying_3x3_magic_squares
{
    class Program
    {
        /// <summary>
        /// [2016-04-04] Challenge #261 [Easy] verifying 3x3 magic squares
        /// https://www.reddit.com/r/dailyprogrammer/comments/4dccix/20160404_challenge_261_easy_verifying_3x3_magic/
        /// </summary>        
        static void Main(string[] args)
        {
            //[8, 1, 6, 3, 5, 7, 4, 9, 2] => true
            //[2, 7, 6, 9, 5, 1, 4, 3, 8] => true
            //[3, 5, 7, 8, 1, 6, 4, 9, 2] => false // this fail diagonally
            //[8, 1, 6, 7, 5, 3, 4, 9, 2] => false // this should fail going down

            int[,] Square1 = { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 }  };
            int[,] Square2 = { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };
            int[,] Square3 = { { 3, 5, 7 }, { 8, 1, 6 }, { 4, 9, 2 } };
            int[,] Square4 = { { 8, 1, 6 }, { 7, 5, 3 }, { 4, 9, 2 } };

            int[,][,] Squares = { { Square1, Square2, Square3, Square4 } };

            int DRsum = 0;
            int RDsum = 0;
            int diagonalsum = 0;
            int diagonalsum1 = 0;

            bool sumof15 = true;

            foreach (var square in Squares)
            {
                diagonalsum1 = 0;
                diagonalsum = 0;

                for (int i = 0; i < 3; i++)
                {
                    DRsum = 0;
                    RDsum = 0;
                   
                    for (int j = 0; j < 3; j++)
                    {
                        DRsum += square[j, i];

                        RDsum += square[i, j];
                    }                 

                    if (DRsum != 15 || RDsum != 15 )
                    {
                        sumof15 = false;
                        Console.WriteLine("one of the lines doesn not add to 15");
                        break;
                    }
                }

                diagonalsum1 += (square[0, 2] + square[1, 1] + square[2, 0]);
                diagonalsum += (square[0, 0] + square[1, 1] + square[2, 2]) ;

                if (diagonalsum1 != 15 || diagonalsum != 15)
                {
                    sumof15 = false;
                    Console.WriteLine("one of the lines doesn not add to 15");
                }

                if (sumof15)
                {
                    Console.WriteLine("all lines in square add to 15");
                }
            }

            Console.ReadLine();
        }
    }
}
