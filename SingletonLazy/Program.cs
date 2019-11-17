using System;

namespace SingletonLazy
{

   class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.CreateObject;
            obj.myName("Naveed Ullah");
            Singleton obj2 = Singleton.CreateObject;
            obj2.myName("asif");
            Console.ReadKey();
        }
    }
}
