using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonLazy
{
    class Singleton
    {
        private readonly int count = 0;
        private Singleton()
        {
            count++;
            Console.WriteLine($"Objects Created = {count}");
        }

        public static Singleton CreateObject { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly Singleton instance = new Singleton();        
        }
        public void myName(string name)
        {
            Console.WriteLine(name);
        }
    }
}

