using System;

namespace WA2
{
    class Program
    {
        // comma ,
        // colon :
        // semi colon ;
        // '' single inverted comma, single Quotation mark
        // "" double inverted comma, Double Quotation Mark
        //  {} Curly brackets
        // [] Square brackets
        // () Round Brackets

        // 1. Question 
        // Parameters   1. low A  2. Medium B  3. High C
        // 
        public static string mymethod(string a)
        {
            return "";
        }

        // Question 2.
        public static string mymethod2(string e)
        {
            return "";
        }


        public static string[] method3(string a, string b)
        {
            string[] d = new string[2];
            d[0] = a;
            d[1] = b;

            return d;
        }



        static void Main(string[] args)
        {
           string a = Program.mymethod("High");
            // Console.WriteLine(a);

        string email = "Naveedpaen@gmail.com,waheedpaen@gmail.com,abobakar@gmail.com";
        Program.mymethod2(email);
            string first; // only first email
            string second; // second contain all others  and ;

         string[]   my1 =    Program.method3("my name is", "Ahmad");
            Console.WriteLine(my1[0]);
            Console.WriteLine(my1[1]);





            Console.ReadKey();
        }
    }
}
