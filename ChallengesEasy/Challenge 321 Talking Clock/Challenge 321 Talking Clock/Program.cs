using System;
using System.Threading;
using System.Speech.Synthesis;

namespace Challenge_321_Talking_Clock
{
    class Program
    {
        /// <summary>
        /// [2017-06-27] Challenge #321 [Easy] Talking Clock
        /// https://np.reddit.com/r/dailyprogrammer/comments/6jr76h/20170627_challenge_321_easy_talking_clock/
        /// </summary>        
        static void Main(string[] args)
        {           
            while (true)
            {
                SpeechSynthesizer Sp = new SpeechSynthesizer();

                DateTime localDate = DateTime.Now;

                string currentTime = localDate.ToShortTimeString();

                Console.Write("\n" + currentTime);

                string[] words = currentTime.Split(':');
                string[] hours = { "Twelve", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve" };
                string[] minutesTens = { "Twenty", "Thirty", "Forty", "Fifty" };
                string[] teenMinutes = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                int hour, minutes;

                hour = Convert.ToInt16(words[0]);
                minutes = Convert.ToInt16(words[1]);

                if (hour > 12)
                {
                    Console.Write("\n" + hours[hour - 12]);
                    Sp.Speak(hours[hour - 12]);
                }
                else
                {
                    Console.Write("\n" + hours[hour]);
                    Sp.Speak(hours[hour]);
                }

                if (minutes < 20 && minutes >= 10)
                {
                    Console.Write(" " + teenMinutes[minutes - 10]);
                    Sp.Speak(teenMinutes[minutes - 10]);
                }
                else
                {
                    if (words[1].StartsWith("0") && minutes != 0)
                    {
                        Console.Write(" Oh ");
                        Sp.Speak(" Oh ");

                        minutes = Convert.ToInt16(words[1].Substring(1));
                        Console.Write(hours[minutes]);
                        Sp.Speak(hours[minutes]);
                    }
                    else
                    {
                        if (words[1].EndsWith("0") && minutes !=0)
                        {
                            minutes = Convert.ToInt16(words[1].Remove(1));
                            Console.Write(" " + minutesTens[minutes - 2]);
                            Sp.Speak(minutesTens[minutes - 2]);

                        }
                        if (words[1].StartsWith("0") == false && words[1].EndsWith("0") == false)
                        {
                            minutes = Convert.ToInt16(words[1].Remove(1));
                            Console.Write(" " + minutesTens[minutes - 2]);
                            Sp.Speak(minutesTens[minutes - 2]);

                            minutes = Convert.ToInt16(words[1].Substring(1));
                            Console.Write(" " + hours[minutes]);
                            Sp.Speak(hours[minutes]);
                        }
                    }
                }

                if (hour > 12)
                {
                    Console.Write(" PM");
                    Sp.Speak(" PM");
                }
                else
                {
                    Console.Write(" AM");
                    Sp.Speak(" AM");
                }
                //1 min
                Thread.Sleep(60000);
            }
                               
        }
    }
}
