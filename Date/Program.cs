using System;
using System.Timers;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer();
            t.Start();



            // after below interval t.elapsed event is going to fire. 
            t.Interval = 5000;

            // t.slapsed event depends on interval time. the moment that finishes it is going to fire.
            t.Elapsed += new ElapsedEventHandler(check);

            Console.ReadKey();


        }


        public static void check(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Time Elapsed");
        }
    }
}
