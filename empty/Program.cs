using System;
using System.Threading;

namespace empty
{
    class Program
    {
        static void FirstLoop ()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Loop one =  {i.ToString()}");
                Thread.Sleep(2000);
            }
        }

        static void SecondLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Loop two =  {i.ToString()}");
               // Thread.Sleep(2000);
            }
        }

        static void Main(string[] args)
        {

            Thread o = new Thread(FirstLoop);
            Thread o2 = new Thread(SecondLoop);
            o.Start();
            o.IsBackground = true;
            o.Name = "Nav thread";
            Console.WriteLine(o.ManagedThreadId);
            o2.Start();

            Console.ReadKey();
        }
    }
}
