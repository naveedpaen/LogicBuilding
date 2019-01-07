using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing2
{
    class Program
    {

        public void checkingnull(string r)
        {
           //  r = "a,b,c";
            string [] a;
            

            //if (r == null)
            //{
            //    a = null;
            //} else
            //{
            //   a = r?.Split(",");
            //}


            a = (r == null ? null :r.Split(","));


             a =  r?.Split(",");


            //text?.ToUpper(); //from previous example, would return null

            //int? length = customerList?.Length; // null if customerList is null   
            //Customer first = customerList?[0];  // null if customerList is null  
            //int? count = customerList?[0]?.Orders?.Count();  // null if customerList, the first customer, or Orders is null 
        }

        public static string Info(student s)
        {
            return s.Id + " naveed Ullah";
        }

        static void Main(string[] args)
        {
            // Question
            int a = 2;
            int d = 3;
            a =+ d;
            //  Console.WriteLine(a);






            student s = new student();
            Program p = new Program();
            string k;
            p.checkingnull(null);

            Console.ReadKey();
        }



        public class student
        {
            public int? Id { get; set; }

            public string  Name { get; set; }


            //public string Info(int Id)
            //{
            //    return Id + " naveed Ullah";
            //}

            //internal string Info(int? id)
            //{
            //    throw new NotImplementedException();
            //}
        }

        public class class1
        {
            public class2 Class2 { get; set; }
        }
        public class class2
        {
            public class3 Class3 { get; set; }

        }
        public class class3
        {
            public class4 Class4 { get; set; }

        }
        public class class4
        {
            public string Name { get; set; }

        }

    }
}