using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile m4 = new Mobile();
            m4.Id = 4;
            m4.ModelName = "Galaxy s5";
            m4.Color = "Blue";
            m4.Companies.CompanyName = "Samsung";
            System.Console.WriteLine(m4.Companies.CompanyName);




            Console.ReadLine();
        }
    }

    public class Mobile 
    {

        public Mobile()
        {
            new Company();
        }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public string processor { get; set; }

        public DateTime ReleaseYear { get; set; }

        public Company Companies { get; set; }



    }

    public class Company
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }


    }
}
