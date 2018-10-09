using System;

namespace WaheedUllah
{
    class Program 
    {
        // inherit interface  Or implement Interface



        // method declaration  Or Method Signature
        public static void add()
            // Method Defination  OR Method implementation OR method body
        {
      
        }


        static void Main(string[] args)
        {
            // declare a variable
            int a;

            // initialize a variable
            a = 5;

            // declare and initialize
            int b = 6;

            // method 1  method 2  method 3  method 4
            // class 1   class2    method 3  method 4

            // class1 obj = new class1();
            // class can only inherit one class at a time. 


            int s = 20;
             string r =  s.ToString();

            Program p = new Program();
            p.FirstName = "Naveed Ullah";
            p.LastName = "Paen";
            Console.WriteLine(p.ToString());


            Console.ReadKey();
        }

        public string method1(int m)
        {

            m.ToString();
            return null;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + LastName;
        }


    }
}
