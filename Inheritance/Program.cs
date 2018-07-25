using System;

namespace Inheritance
{

    public interface Iparent
    {
        void Plus();
        
    }
    public class parent  {
        public void Pmethod() { }
    }

    public class child : parent, Iparent
    {
        public void Cmethod() { }

        public void Plus()
        {
            Console.WriteLine("Plus Method");
        }

        public void Minus() {
        Console.WriteLine("Minus Method");    
        }

    }

    class Program
    {
        private readonly Iparent _Iparent;
        public Program()
        {
            _Iparent = new child();
        }

        public void testing()
        {
            _Iparent.Plus();
        }
        static void Main(string[] args)
        {
            //parent p = new parent();
            //child c = new child();

            //p = new child();
            Program p = new Program();
            p.testing();



            Console.ReadKey();
        }
    }
}
