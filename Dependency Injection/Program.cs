using System;

namespace Dependency_Injection
{

    public class A : IA
    {
        public string MyName()
        {
            return "Ali";
        }
    }

    interface IA
    {
        string MyName();
    }


    public class B
    {
        private A _a;
        public B( A a)
        {
            this._a = a;
        }

        public void Print()
        {
            Console.WriteLine(_a.MyName());
        }
    }


    class Program
    {
        private IA _ia; 
        public Program(IA ia)
        {
            _ia = ia;
        }
        static void Main(string[] args)
        {
            // B b = new B(new A());
            //  b.Print();

           // Program.abc();
           


            Console.ReadKey();
        }


        public  void abc()
        {     
            Console.WriteLine(_ia.MyName());
        }
    }
}
