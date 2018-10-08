using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class child : parent
    {
        public void Cmethod() { }

        public void Cmethod2() { }

        new public  void common()
        {
            Console.WriteLine("child common");
        }
    }
}
