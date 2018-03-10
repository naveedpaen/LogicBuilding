using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dates = new int[29];

            int[] date = new int[] { 1,2,3};

            object[] dat = { 5, 5, 5 };

    //  Because the object type is the base type for all the types in .NET
            object[] da = new object[] { 2, 3, "t" };
            Console.WriteLine(da[2]);
            Console.WriteLine("\n");


            int[] abc = new int[2];
            abc[0] = 4;
            Console.WriteLine(abc[1]);
            Console.WriteLine("\n");
            

            

            
            foreach (var item in da)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
