using System;
using clockO;

namespace Watch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var myText = new TextEffect();
            myText.Text = "Seconds";
            myText.TimeDigit = 60;

            var myText2 = new TextEffect();
            myText2.Text = "Minute";
            myText2.TimeDigit = 60;

            var myText3 = new TextEffect();
            myText3.Text = "hour";
            myText3.TimeDigit = 24;




            Console.WindowWidth = 200;
            while (true)
            {
                Timer(myText, DateTime.Now.Second);
                Timer(myText2, DateTime.Now.Minute);
                Timer(myText3, DateTime.Now.Hour);
                // Mulig å sende et object som inneholder både timeunit og timetitle?



                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void Timer(TextEffect textEffect, int typeClock)
        {
            Console.WriteLine(textEffect.Text);

            WriteWithPad("*", typeClock * 3);

            Console.WriteLine(' ');

            for (int seconds = 1; seconds <= textEffect.TimeDigit; seconds++)
            {
                WriteWithPad(seconds, 3);
            }

            Console.WriteLine(' ');
        }

        private static void WriteWithPad(int value, int length = 1)
        {
            Console.Write(value.ToString().PadLeft(length, ' '));
        }
        private static void WriteWithPad(string value, int length = 1)
        {
            Console.Write(value.PadLeft(length, ' '));
        }

    }
}


/*                //var minutesNow = DateTime.Now.Minute;
   //Console.WriteLine("*".PadLeft(3 * minutesNow, ' '));
   //for (int minutes = 1; minutes <= 60; minutes++)
   //{
   //    Console.Write(minutes.ToString().PadLeft(3, ' '));
   //}
   
   //Console.WriteLine(' ');
   
   //var hoursNow = DateTime.Now.Hour;
   //Console.WriteLine("*".PadLeft(3 * hoursNow, ' '));
   //for (int hours = 1; hours <= 24; hours++)
   //{
   //    Console.Write(hours.ToString().PadLeft(3, ' '));
   
   //}
*/