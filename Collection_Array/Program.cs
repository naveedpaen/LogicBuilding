using System;

namespace Collection_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Length or last Index Index No
            Console.WriteLine("Array Lenght or last index No");
            int[] dates = new int[5];
            int lenght = dates.Length;
            Console.WriteLine(lenght);

            // Resize Array
            Console.WriteLine("Resize Array");
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

            // Read array values one by one.
            Console.WriteLine("For Each");
            int[] abc = new int[3];
            foreach (var item in abc)
            {
                Console.WriteLine(item);
            };
            Console.WriteLine("\n") ;




            // assign values at Run time and Add Them;
            Console.WriteLine("Plz Enter 3 values");
            int[] run = new int[3];
            int sum = 0;
            for (int i = 0; i < run.Length; i++)
            {
              run[i] =Convert.ToInt32(Console.ReadLine());
              sum += run[i];
            }
            Console.WriteLine("Sum of Array =",sum);
            



            Console.ReadKey();
        }
    }
}
