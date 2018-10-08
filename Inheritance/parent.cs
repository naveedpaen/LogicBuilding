using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class parent
    {

        public void Pmethod() { }
        public virtual void  common()
        {

            Console.WriteLine("parent common");
        }
    }
}