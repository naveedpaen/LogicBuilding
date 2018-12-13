using System;

namespace Property
{
    class Program
    {


        private int roll;

        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        private int myVar;

        public int Id
        {
            get { return myVar; }
            set { myVar = value; }
        }


        private int cost;

        public int Cost
        {
            get
            {


                if (cost == 5)
                {
                    return 20;
                }
                else
                {
                    return  10;
                }
            }

            set
            {
                cost = value;
            }
        }


        private int month;

        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 13)
                {
                    month = value;
                }
                else
                {
                    month = -1;
                    // throw new Exception("Your value for month is not correct");
                }
            }
        }

       




        static void Main(string[] args)
        {

            Program o = new Program();
            o.Cost = 59;
            Console.WriteLine(o.Cost);


            o.Month = 15;


            Console.ReadKey();

        }
    }
}
