using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
   public abstract class Common : Master
    {


        public override int Multiply()
        {
            return 1 * 1;
        }

        public abstract DateTime BirthDay();




        public virtual String Name()
        {
            return "Common Class";
        }



        public int Money()
        {
            return 0;
        }

        //public new int calculate()
        //{
        //    return 2 + 3;
        //}


        //public override int Subtract()
        //{
        //    return 3 - 1;
        //}


    }
}
