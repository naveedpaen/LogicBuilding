using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace For_VS_Foreach
{
    class Program
    {
      

        public static int Forloop()
        {
            int a = 0;
            int[] array = new int[] {
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                a += array[i];
            }
            return a;
        }

        public static int Foreach()
        {
            int a = 0;
            int[] array = new int[] {
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            foreach (int item in array)
            {
                a += item;
            }
            return a;
        }

        static void Main(string[] args)
        {
            const int m = 10000000;
            // For Loop testing
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                int k = Program.Forloop();
            }
            s1.Stop();
            double t = s1.Elapsed.TotalSeconds;


            // For each Loop testing
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                int b = Program.Foreach();
            }
            s2.Stop();
            double u = s2.Elapsed.TotalSeconds;

            Console.WriteLine($"ForLoop = {t}");
            Console.WriteLine($"ForEach = {u}");



            Console.ReadKey();
        }
    }
}
