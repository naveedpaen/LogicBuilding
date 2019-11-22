using ViewModel;
using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            // test
            // Method 1
            Mobile m = new Mobile();
            m.Id = 1;
            m.ModelName = "Galaxy s4";
            m.Color = "Black";

            // Method 2
            Mobile m2a = new Mobile { Id = 2, Color = "Red", ModelName = "iPhone 5s" };
            // OR
            Mobile m2b = new Mobile
            {
                Id = 3,
                Color = "Black",
                ModelName = "iPhone 6s"

            };

            // Method 3 If Mobile depends on a custom class then two ways.
            // 3a
            Mobile m3 = new Mobile();
            m3.Id = 3;
            m3.ModelName = "6s";
            m3.Color = "Green";
            Company model = new Company
            {
                CompanyName = "Apple"
            };
            System.Console.WriteLine(model.CompanyName);


            // 3b. first add new object of company in mobile constructor. 
            Mobile m4 = new Mobile();
            m4.Id = 4;
            m4.ModelName = "Galaxy s5";
            m4.Color = "Blue";
            m4.Companies.CompanyName = "Samsung";
            System.Console.WriteLine(m4.Companies.CompanyName);




            Console.ReadLine();
          
        }
    }


    



}
