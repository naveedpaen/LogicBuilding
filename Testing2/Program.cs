using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing2
{
    class Program
    {
        static void Main(string[] args)
        {


            string a = null;
            a?.Split(',');



            if (string.IsNullOrEmpty(a))
            {
                a.Split(',');
            }



            Console.ReadKey();
        }
    }
}