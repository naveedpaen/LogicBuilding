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
                new student{Id=1, Name="Naveed Ullah", Mobile=0303},
                new student{Id=2, Name="Waheed Ullah", Mobile=0345},
                new student{Id=3, Name="Ali", Mobile=0333},
            };

           // studentList.ForEach(x => x.Id);
            Console.WriteLine();

            foreach (var student in studentList)
            {
                Console.WriteLine($" Id= {student.Id} Name={student.Name} Mobile#{student.Mobile}");
            }


            studentList.ForEach(x => {Console.WriteLine($" Id= {x.Id} Name={x.Name} Mobile#{x.Mobile}");});
            var si = studentList.Find(x=> x.Id == 1);
            var se = studentList.Select(x => x.Id == 3);
            





            ReadLine();



                 
        }
    }
}
