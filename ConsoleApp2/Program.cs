using System;

namespace ConsoleApp2
{
    public class student
    {
        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }


        private int StudentId;

        public int abc { get; set; }
        public int GetId {

            get { return this.StudentId; }
        }

        public int GetId2 ()
        {
            return StudentId;
        }




        public student()
        {

        }
        private int id;

        public student(int idd)
        {
            this.id = idd;
        }

        public int myMethod()
        {
            return id;
        }


        private int Id2 { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {



            student s = new student(1);
            int a =s.GetId;
            
            Console.WriteLine(s.myMethod());


            Book o = new Book();


            // var a = o.Id;

            // o.Id = 10;
            //Console.WriteLine(o.Id);

            Console.ReadKey();
        }
    }



    public class Book {
        private int id;

        public int Id
        {
            get { return id = 20; }
            set { id = value; }
        }







    



    }

}
