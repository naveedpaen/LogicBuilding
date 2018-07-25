using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_List
{

    public class Student {
        public int Id { get; set; }

        public string Name { get; set; }


    }



    class Program
    {
        static void Main(string[] args)
        {





            List<Student> stu = new List<Student>();
            Student c1 = new Student();
            c1.Id = 5;
            c1.Name = "Nav";

            Student c2 = new Student();
            c2.Id = 2;
            c2.Name = "Ali";


            Student s3 = new Student() {Id = 4 , Name= "Asif" };

            stu.Add(c1);
            stu.Add(c2);

            foreach (var s in stu)
            {
                Console.WriteLine($"ID= {s.Id} Name = {s.Name}" );
            }

            for (int i = 0; i < stu.Count; i++)
            {
                Student abc =  stu[i];
                Console.WriteLine($"ID= {abc.Id} Name = {abc.Name}");
            }


            List<Student> slist = new List<Student>()
            {
              new Student {Id= 3 , Name = "adnan"},
              new Student {Id=4 , Name = "Ahmad"}

            };
            slist.Add(s3);

            // slist.AsReadOnly();

            // int k = slist.BinarySearch(s3);
            // bool ki = slist.Contains(s3);
            //ar ad = slist.();
            slist.Clear();
            int k = slist.Count;

            List<int> a = new List<int>() { 1,2,3,4,5,6,7,8};

            // convert integer list to comma Seperated string
            string r = string.Join(",", a.ToArray());
            Console.WriteLine(r);


            // split comma seprated string to List<string> and list<int>
            List<string> kh =  r.Split(",").ToList();
            List<int> kv = r.Split(",").Select(int.Parse).ToList();

            // split comma seperated string to array
            Array c = r.Split(",");
            foreach (var item in kh)
            {
                Console.WriteLine(item);
            }
            // Console.WriteLine(r);


            Console.WriteLine( "New Work ");
            List<int> newlist = new List<int> { 1, 2, 3, 4, 5, 6 };
          string rt =   String.Join(",", newlist.ToArray());
            Console.WriteLine(rt);

           string[] ar = rt.Split(",");
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
