using System;
using System.Text;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string Intro = "My";
            Intro += "Name";
            Intro += "is";
            Intro += "Naveed Ullah";


            StringBuilder Intro2 = new StringBuilder();
            Intro2.Append("My ");
            Intro2.Append("Name ");
            Intro2.Append("is ");
            Intro2.Append("abc ");

            Intro2.Insert(0,"Hi ");
            Intro2.
            Console.WriteLine(Intro2);


            //Console.WriteLine("String Builder");
            //StringBuilder c = new StringBuilder();
            //for (int i = 1; i <=10000; i++)
            //{
            //    c.Append(i.ToString() + " ");
            //}
            //Console.WriteLine(c);

            //Console.WriteLine("String");
            //string s= null;
            //for (int i = 1; i <=10000;  i++)
            //{
            //    s += i + " "; 
            //}
            //Console.WriteLine(s);






            Console.ReadKey();
        }
    }
}
