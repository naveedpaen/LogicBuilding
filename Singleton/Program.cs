using System;

namespace Singleton
{
     sealed class Singleton {
        private Singleton(){
            count++;
            Console.WriteLine($"Objects Created = {count}");
        }
        private readonly int count = 0;
        public static Singleton getInstance = null; // a property contain reference of object.
        public static Singleton CreateObject() // method which confirms above property is null or not. 
        {
            if (getInstance == null)
            {
                return new Singleton();
            }
            return getInstance;
        }

        public void myName(string name)
        {
            Console.WriteLine(name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.CreateObject();
            obj.myName("Naveed Ullah");
            Singleton obj2 = Singleton.CreateObject();
            obj2.myName("asif");
            Console.ReadKey();
        }
    }
}
