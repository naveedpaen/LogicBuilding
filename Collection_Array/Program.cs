using System;

namespace Collection_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Length
            Console.WriteLine("Array Lenght");
            int[] dates = new int[5];
            int lenght = dates.Length;
            Console.WriteLine(lenght);

            Array.Resize (ref dates, 7);
            Console.WriteLine(dates.Length);
            Console.WriteLine("\n");

            // change my array according to values you get



            //  Array having different types of values.
            //   object type is the base type for all types in .NET
            Console.WriteLine("abc");
            object[] da = new object[] { true , 3, "t" };
            Console.WriteLine(da[1]);
            Console.WriteLine("\n");


            Console.WriteLine("For Each");
            int[] abc = new int[3];
            foreach (var item in abc)
            {
                Console.WriteLine(item);
            };
            Console.WriteLine("\n") ;



      
            // assign values at Rrun time;
            int[] run = new int[3];
            for (int i = 0; i < run.Length; i++)
            {
               run[i] =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(run[i]);
               // int sum += run[i];
            }
            



            Console.ReadKey();
        }
    }
}
