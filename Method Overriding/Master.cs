using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    abstract public class Master
    {

        public abstract int Multiply();


        public virtual int Subtract()
        {
            return 2 - 1;
        }




        public int calculate()
        {
            return 2 + 2;
        }





    }
}
