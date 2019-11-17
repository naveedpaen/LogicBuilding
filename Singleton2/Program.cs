using System;

namespace Singleton2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.CreateObj;
            obj.myName("Naveed Ullah");

            Singleton obj2 = Singleton.CreateObj;
            obj2.myName("asif");
            Console.ReadKey();

        }
    }



    class Singleton
    {
        
    private static Singleton instance = null;
        private static readonly object padlock = new object();
        public int count = 0;

      private Singleton()
        {
            count++;
            Console.WriteLine($"Objects Created = {count}");
        }

        public static Singleton CreateObj
        {
            
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public  void myName(string name)
        {
            Console.WriteLine(name);
        }

        public static void myName2(string name)
        {
            Console.WriteLine(name);
        }
    }

}
