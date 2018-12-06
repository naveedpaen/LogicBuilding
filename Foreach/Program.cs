using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Foreach
{

    class student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Mobile { get; set; }

    }

        class Program
        {
        static void Main(string[] args)
        {

        

 





            List<student> studentList = new List<student>()
            {
                new student{Id=2, Name="Waheed Ullah", Mobile=2},
                new student{Id=2, Name="Waheed Ullah", Mobile=2},
                new student{Id=3, Name="Ali", Mobile=0333},
            };



             
            // find all vs find
            // student a = studentList.Find(x => x.Mobile == 2);
            // Console.WriteLine($"ID = {a.Id }");

            //var c = studentList.FindAll(x => x.Mobile==2);
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // prdeicate 

            // Advantage of toList ?
            // distinct not working
            var b = studentList.Where(x => x.Mobile == 2).Distinct().ToList();
            foreach (var item in b)
            {
                Console.WriteLine(item.Name);
            }

           // var distinctList = openTaskslist.Select(x => new { x.SId, x.SupportUserName, x.ToEmail }).Distinct().ToList();

            // not working
            // var b = studentList.Where(x => x.Mobile == 2);
            //b.ForEach(x => { Console.WriteLine(x.Name); });


            // not working
            // var b =    studentList.Distinct();
            // Console.WriteLine(b);

            //  var b = studentList.Select(x => x.Id == 1);
            //  Console.WriteLine(b);
            //  Console.WriteLine(studentList.Select(x => x.Id == 1));
            // Console.WriteLine($"{b.Id}{b.Name}{b.Mobile}");


            foreach (var student in studentList)
            {
            //    Console.WriteLine($" Id= {student.Id} Name={student.Name} Mobile#{student.Mobile}");
            }


          //  studentList.ForEach(x => { Console.WriteLine($" Id= {x.Id} Name={x.Name} Mobile#{x.Mobile}"); });




            var si = studentList.Find(x => x.Id == 1);
            var se = studentList.Select(x => x.Id == 3);


            Console.ReadKey();
        }
    }
}
