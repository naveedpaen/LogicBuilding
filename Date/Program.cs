using System;
using System.Timers;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t = new Timer();                
            t.Enabled = true;
            t.Interval = 5000;
            t.Elapsed += new ElapsedEventHandler(check);
            t.Start();








            Console.ReadKey();


        }


        public static void check(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Time finished");
        }
    }
}
