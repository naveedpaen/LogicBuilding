using System;
using System.Collections.Generic;
using System.Text;

namespace WaheedUllah
{
    class Teacher : INecessary
    {
        public void method1()
        {
            Console.WriteLine("1");
        }

        public void method2()
        {
            Console.WriteLine("2");

        }

        public void method3()
        {
            Console.WriteLine("3");

        }

        public void method4(int p)
        {
            Console.WriteLine("4");
        }

        public void method5()
        {
            throw new NotImplementedException();
        }

        public void method6()
        {
            throw new NotImplementedException();
        }


        public void OnlyforStudent()
        {
            Console.WriteLine("this method is only for student");
        }

        public void Salaray()
        {

        }


    }
}
