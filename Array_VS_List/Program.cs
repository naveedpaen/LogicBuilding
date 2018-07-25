using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Array_VS_List
{


    class Program
    {
        public static int Array1()
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

        public static int List1()
        {
            int a = 0;
            List<int> lists = new List<int> {
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
                5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            for (int i = 0; i < lists.Count; i++)
            {
                a += lists[i];
            }
            return a;
        }
        static void Main(string[] args)
        {
            const int m = 1000000;

            // Array Test
            var ArrayStopwatch = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                Program.Array1();
            }
            ArrayStopwatch.Stop();
            double ArrayTime = ArrayStopwatch.Elapsed.TotalSeconds;



            //List Test
            var ListStopWatch = Stopwatch.StartNew();
            for (int i = 0; i < m; i++)
            {
                Program.List1();
            }
            ListStopWatch.Stop();
            double ListTime = ListStopWatch.Elapsed.TotalSeconds;





            Console.WriteLine($"Array = {ArrayTime}");
            Console.WriteLine($"List = {ListTime}");
            Console.ReadKey();
        }
    }
}
