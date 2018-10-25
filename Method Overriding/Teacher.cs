using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    public class Teacher : Common
    {
        // Return Date + Time
        public override DateTime BirthDay()
        {
            return new DateTime(1980, 2, 3, 4, 5, 2);
        }


        public override string Name()
        {
            return "Teacher CLass";
        }


        public new int Money()
        {
            return 20;
        }


        //public new int calculate()
        //{
        //    return 2 + 4;
        //}

        public override int Subtract()
        {
            return 4 - 1;
        }

        //public override int Multiply()
        //{
        //    return 2 * 2;
        //}
    }
}
