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
            Console.WriteLine("\n");


            // what index contain 0
            Console.WriteLine("what index contain 0");
            int[] first = new int[5] { 1,0,3,0,5};
            for (int i = 0; i < 5; i++)
            {
                if (first[i]==0)
                {
                    Console.WriteLine(i);
                }
            }


            // Resize Array
            Console.WriteLine("Resize Array");
            Array.Resize (ref dates, 7);
            Console.WriteLine(dates.Length);
            Console.WriteLine("\n");



            // check a value exist or not
            Console.WriteLine("check a value exist or not");
            int[] t = new int[] { 1, 2, 3, 4, 5, 6, 7 };
           int aa =   Array.BinarySearch(t, 9);
           Console.WriteLine(aa);

            // Method 2. check a value exist or not.
            foreach (var item in t)
            {
                if (item == 9)
                {
                    Console.WriteLine("Value Found");
                }
            }







            Console.WriteLine("\n");
            // change my array according to values you get



            //  Array having different Data Types.
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


            // Assign values to array.
            Console.WriteLine("Assign values to array.");
            int[] assign = new int[10];
            for (int i = 0; i < 10; i++)
            {
                assign[i] = i + 100;
                Console.WriteLine(assign[i]);
            }


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
