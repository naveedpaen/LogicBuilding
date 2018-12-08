using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Program
    {

        public static string[] arrayMethod(string first, string second)
        {
            string[] myarraystring = new string[2];

            myarraystring[0] = first;
            myarraystring[1] = second;
            return myarraystring;
        }




        public static (string , string ) tupleMethod(string first , string second)
        {
            string a = first;
            string b = second;
            return (a, b);
        }


        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            mylist.Add(10);
            mylist.Add(20);

            IEnumerable<int> result = mylist;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }






            string[] value2 = Program.arrayMethod("My Name is", "khan");
          //  Console.WriteLine(value2[0]);
          //  Console.WriteLine(value2[1]);


          var value =   Program.tupleMethod("I am ", "khan");
         //   Console.WriteLine(value.Item1 + value.Item2);
            





            string Intro = "My";
            Intro += "Name";
            Intro += "is";
            Intro += "Naveed Ullah";
           // Console.WriteLine(Intro);


            StringBuilder Intro2 = new StringBuilder();
            Intro2.Append("My ");
            Intro2.Append("Name ");
            Intro2.Append("is ");
            Intro2.Append("abc ");
           // Console.WriteLine(Intro2);


            string a = "";
            StringBuilder mystringbuilder = new StringBuilder();
       
            string emailstring = "naveedpaen@gmail.com,naveed@gmail.com,nav@gmail.com";
            string[] ArrayList = emailstring.Split(',');
            for (int i = 0; i < ArrayList.Length; i++)
            {
                if (i == 0)
                {
                    a = ArrayList[0];
                }

                else  
                {
                    mystringbuilder.Append(ArrayList[i] );
                    if (i < ArrayList.Length -1)
                    {
                    mystringbuilder.Append(";");
                    }
                }
            }

          //  Console.WriteLine(a);
          //  Console.WriteLine(mystringbuilder);

            //Intro2.Insert(0,"Hi ");


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

            //StringBuilder myBuilder = new StringBuilder(myString);
            //myBuilder.Append("New");




            // output
            // getNew


            //  bool k= String.IsNup;llOrWhiteSpace(myString);

            //cant implicitly convert object into string. 
           // string m = r;

            //  Solution 1
           // string k =Convert.ToString(r);


           // string p = r as string;

            //object ab = 14;
            //if ( ab is Int32)
            //{
            //    Console.WriteLine();
            //}

            //bool g = ab is Int32;
            //Console.WriteLine(g);



             Console.ReadKey();
        }
    }
}
