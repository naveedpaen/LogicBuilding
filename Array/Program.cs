using System;
using Array;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // different ways to declare array
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



            //...  Get value of any index No
            Console.WriteLine("Get value of any index No");
            int[] ArrayObj = new int[5] { 1, 2, 3, 4, 5 };
            object a = ArrayObj.GetValue(3);
            Console.WriteLine(a);






            Console.ReadKey();
        }
    }
}
