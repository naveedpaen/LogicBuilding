using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 2;

            //if (a != 2)
            //{
            //    Console.WriteLine("Value of a is not 2");
            //}

            //else if (a == 2)
            //{
            //    Console.WriteLine("Value of a is 2");
            //}


            //int b = 4;

            //if (b == 2)
            //{
            //    Console.WriteLine("Value of b is 2");
            //}
            //if (b==3)
            //{
            //    Console.WriteLine("Value of b is 3");
            //}
            Start:
            Console.WriteLine("Please enter your two numbers:");
            int a =Convert.ToInt32( Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Answer");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == a+b)
            {
                Console.WriteLine("Right ANswer Wao");
            }
            else
            {
                Console.WriteLine("Noooooooooo");
            }
            


            Console.ReadKey();
            Console.WriteLine();
                goto Start;
        }
    }
}
