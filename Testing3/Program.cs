using System;
using System.Linq;

namespace Testing3
{

    public class test {

        public int Id { get; set; }
        public string Name { get; set; }

       public  int c;
    }

    

    class Program
    {
        int b;
        static void Main(string[] args)
        {

            int[] s = { 1, 2, 3, 3, 4,1,2,3 };
            string[] t = { "a", "b", "c", "d", "a" };
            int[] q = s.Distinct().ToArray();
            var a = t;
           }
    }
}
