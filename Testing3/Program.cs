using System;

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
            int a = 0;
            test t = new test();
            t.Name = "asif";
            int b = 30;
          int  sum = a + b;
            Program p = new Program();

            Console.WriteLine(t.c);

            Console.ReadKey();
        }
    }
}
