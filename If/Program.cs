using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {












            #region E.g 2 
            int s7 = 4;
            int s8 = 8;

            int answer= 0;
            char c8 = '0' ;
          //  char c8 = Convert.ToChar( Console.ReadLine());

            if (c8 == '+')
            {
                answer =  s7 + s8;
                Console.WriteLine(answer);
            }

            else if (c8 == '-')
            {
                answer = s8 - s7;
                Console.WriteLine(answer);
            }

            else if (c8 == '*')
            {
                answer = s7 * s8;
            Console.WriteLine(answer);
            }

            #endregion





            #region E.g 3
            // null check 

            int? r1= null;
           string r2 = null; 
            if (r1 == null)
            {
                Console.WriteLine("Your value is null");
            }

            #endregion






            Console.WriteLine("End of WA /n");





















            // Example 2. check a = 2 or not






            Console.WriteLine("Example 2. check a = 2 or not");
            int a = 2;



            if (a == 2)
            {
                Console.WriteLine("Value of a is 2");
            }

            else if (a != 2)
            {
                Console.WriteLine("Value of a is not 2");
            }




            //Example 3.  nested if vs && Operator vs Double if
            Console.WriteLine("Example 3. nested if vs && Operator vs Double if");
            int c = 8; 
            if (c>1)
            {
                if(c<10)
                {
                    Console.WriteLine("Correct Value");
                }
            }

            if(c>1 && c<10)
            {
             Console.WriteLine("Right Value");
            }

            if (c>1)
            {
                Console.WriteLine("Right");
            }

            if(c<10)
            {
                Console.WriteLine("Right ");
            }



            // Example 4. who has highest Value. 
            Console.WriteLine("Example 4. who has highest Value.");
            int x = 5; int y = 6; int z = 7;

            if (x > y  && x > z)
            {
                Console.WriteLine("X has Higest Value");
            }

            else if(y>x && y>z)
            {
                Console.WriteLine("Y has Higest Value");
            }

            else if(z>x && z>y)
            {
                Console.WriteLine("Z has Higest Value");
            }




            // Example 5. Method can Retun many values
            Console.WriteLine("Example 5. Method can Retun many values");
             string Abc(int aaa)
            {
                if (aaa == 10) return null;
                if (aaa == 20) return "20";
                if (aaa == 30) return "30";
                return "No Condition";
            }
            Console.WriteLine(Abc(20));




            // Example 6. check user Id and Username
            Console.WriteLine("Example 6. check user Id and Username");
            int Id= 1;
            string UserName = "Naveed";

            if( Id==1 && UserName == "Naveed")
            {
                Console.WriteLine("You are logged in..");
            }
            else
            {
                Console.WriteLine("Invalid UserName Or  Password");
            }



            //Example 7. check answer is correct or not. 
            Console.WriteLine("Example 7. check answer is correct or not. ");
            Start: 
            Console.WriteLine("Please enter your two numbers:");
            int a1 =Convert.ToInt32( Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Your Answer");
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == a1+b1)
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
