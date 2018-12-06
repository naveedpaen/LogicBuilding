using System;
using System.Collections.Generic;
using System.Text;

namespace WaheedUllah
{

   // own method have high priority
    internal class Student : Teacher, INecessary
    {
        public new void  method1()
        {
            Console.WriteLine("a");
        }

        public void StudentFees()
        {

        }


        public void method2()
        {
            Console.WriteLine("b");

        }

        public void method3()
        {
            Console.WriteLine("c");

        }

        public void method4(int d)
        {
            Console.WriteLine("d");
        }

        public void method6()
        {

        }

                    




    }
}
