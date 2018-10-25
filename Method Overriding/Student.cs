using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Overriding
{
    class Student : Common
    {
        //  Return only date
        public override DateTime BirthDay()
        {
            return new DateTime(2001, 3, 2);
        }


        public override string Name()
        {
            return "Student Class";
        }
        
        public new int Money()
        {
            return 50;
        }

        public override int Multiply()
        {
            throw new NotImplementedException();
        }
    }
}
