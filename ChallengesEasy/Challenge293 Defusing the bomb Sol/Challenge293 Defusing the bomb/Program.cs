using System;

namespace Challenge293_Defusing_the_bomb
{
    class Program
    {
        /// <summary>
        /// /r/dailyprogrammer [2016-11-21] Challenge #293 [Easy] Defusing the bomb
        /// </summary>
        /*
        To disarm the bomb you have to cut some wires.These wires are either white, black, purple,
        red, green or orange.
        The rules for disarming are simple:
        If you cut a white cable you can't cut white or black cable.
        If you cut a red cable you have to cut a green one
        If you cut a black cable it is not allowed to cut a white, green or orange one
        If you cut a orange cable you should cut a red or black one
        If you cut a green one you have to cut a orange or white one
        If you cut a purple cable you can't cut a purple, green, orange or white cable

        If you have anything wrong in the wrong order, the bomb will explode.
        There can be multiple wires with the same colour and these instructions are for one wire at a time.
        Once you cut a wire you can forget about the previous ones.
        */
        static void Main(string[] args)       
        {
            
            string[] Order = { "White","Red", "Green", "White" }; //should be no "Boom"
            //string[] Order = { "White", "White", "Red", "Green", "White" }; //should go "Boom"
            //string[] Order = { "White", "Red", "Green", "White","Purple","Red","Green","Orange","Black" }; //should go "Boom"

            for (int i = 0; i < Order.Length; i++)
            {
                if (Checkwhite() == false || Checkred() == false || Checkblack() == false ||
                    Checkorange() == false || Checkgreen() == false || Checkpurple() == false)
                {
                    Console.WriteLine("Boom");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} Wire Cut", Order[i]); 
                }
                             
                bool Checkwhite()
                {
                    if (i == (Order.Length-1))
                    {                          
                        return true;
                    }
                    else
                    {             
                        return (Order[i] == "White" && Order[i + 1] == "White" ||
                            Order[i] == "White" && Order[i + 1] == "Black") ? false : true;
                    }                   
                }

                bool Checkred()
                {
                    if (i == (Order.Length - 1))
                    {                        
                        return true;
                    }
                    else
                    {
                        return (Order[i] == "Red" && Order[i + 1] != "Green") ? false : true;               
                    }
                }

                bool Checkblack()
                {
                    if (i == (Order.Length - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return (Order[i] == "Black" && Order[i + 1] == "White" ||
                                    Order[i] == "Black" && Order[i + 1] == "Green" ||
                                         Order[i] == "Black" && Order[i + 1] == "Orange") ? false : true;                      
                    }
                }

                bool Checkorange()
                {
                    if (i == (Order.Length - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return (Order[i] == "Orange" && Order[i + 1] != "Red" &&
                            Order[i] == "Orange" && Order[i + 1] != "Black") ? false : true;
                    }
                }

                bool Checkgreen()
                {
                    if (i == (Order.Length - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return (Order[i] == "Green" && Order[i + 1] != "White" &&
                            Order[i] == "Green" && Order[i + 1] != "Orange") ? false : true;                     
                    }
                }
                
                bool Checkpurple()
                {
                    if (i == (Order.Length - 1))
                    {
                        return true;
                    }
                    else
                    {
                        return (Order[i] == "Purple" && Order[i + 1] == "White" ||
                                 Order[i] == "Purple" && Order[i + 1] == "Green" ||
                                     Order[i] == "Purple" && Order[i + 1] == "Purple" ||
                                         Order[i] == "Purple" && Order[i + 1] == "Orange") ? false : true;
                    }
                }                
            }
            Console.ReadLine();
        }     
    }
}
