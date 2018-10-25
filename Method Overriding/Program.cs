using System;

namespace Method_Overriding
{
    class Program
    {


        static void Main(string[] args)
        {
            Program p = new Program();

            Teacher t = new Teacher();
            t.BirthDay();
            Console.WriteLine("Teacher");
            Console.WriteLine(t.BirthDay());
            t.Name();
            Console.WriteLine(t.Name());
            t.Money();
            Console.WriteLine(t.Money());
            t.calculate();
            Console.WriteLine(t.calculate());
            t.Subtract();
            Console.WriteLine(t.Subtract());
            t.Multiply();
            Console.WriteLine();
            Console.WriteLine( t.Multiply());




            Console.WriteLine();

            Student s = new Student();
            s.BirthDay();
            Console.WriteLine("Student");
            Console.WriteLine(s.BirthDay());
            s.Name();
            Console.WriteLine(s.Name());





            Console.ReadKey();
        }








    }
}
