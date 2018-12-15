using System;

namespace wa3
{
    public class student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
    // require


    //  if you have a list or array,  to read it you have to use loop read on the base of index number.   string n = myarray[0];
    // splits a string on base of anything. like comma, space, @
    // Initialize (creating object) means taking memory space and assigning default values. (It will have default value if we donot assign anything)  int a = 20;  
    // reference variable have name of the object
    class Program
    {

      public static  int a2;

        public static int Good(student a)
        {
         
         //  string [] k  = a.Split(",");
            return a.Id;
        }


        static void Main(string[] args)
        {
  
            string a = "abc@gmail.com,def@gmail.com,ghi@gmail.com";
            string[] myarray = a.Split(",");
            string n = myarray[0];
            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }

            string[] kk = new string[2] { "a", "ko" };

            // reference variable have name of the object
            student o = new  student();
            o.Id = 30;

          int u =  Program.Good(o);

            //string[] v =   mymethod (a)  
            //b[0] = k ;
            //b[1] = c ;

      

            //string[] r = { "i am eating apple" };
            //string[] e = r[0].Split(' ', 5);
            //foreach (var t in e)
            //{
            //    Console.WriteLine(t);
            //}
            Console.ReadKey();
        }
    }
}
