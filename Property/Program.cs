using System;

namespace Property
{
    class Program
    {
       
        public Program()
        {
            // myreadonly = 12;

        }
        const int myconst = 100;
        public readonly int myreadonly = 15;

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
                    return  0;
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


        private int purchase;

        public int Purchase
        {

              get => purchase == -1 ? DateTime.Now.Month : month;
              set => purchase = (value > 0 && value< 13) ? value : -1;
        }


        //   get => month == -1 ? DateTime.Now.Month : month;
        //   set => month = (value > 0 && value< 13) ? value : -1;




        static void Main(string[] args)
        {
            Program o = new Program();
            Console.WriteLine(o.myreadonly);            
            
            o.Roll = 20;
            //Console.WriteLine(o.Roll);
            o.Month = 15;
            Console.ReadKey();

        }
    }
}
