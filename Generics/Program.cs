using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {

        static bool compare(object a, object b)
        {
            return a == b;
        }

        static bool compare2<T>(T a, T b)
        {
            return a.Equals(b);
        }

        static void Main(string[] args)
        {

            int abc = 30;
            abc.ToString();
            Console.WriteLine(abc.ToString());




            Program.compare(3, "def");
            Program.compare2<int>(6, 8);
            check<int>.compare3(4, 5);

            check<int> ab = new check<int>();
            ab.FirstName = "Naveed Ullah";
            ab.LastName = "Paen";
            Console.WriteLine(ab.ToString());


            List<int> aList = new List<int>();
            aList.Add(1);
            aList.Add(2);
            aList.Add(3);

            List<T> vList = new List<T>();


            Console.ReadKey();

        }
    }

    public class check<T> {
       public static bool compare3(T a, T b)
        {
            return a.Equals(b);
        }



        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return FirstName + LastName;
        }





    }


}
