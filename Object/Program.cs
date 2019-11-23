using ViewModel;
using System;

namespace Object
{
    class Program
    {
      public  Mobile m5 = new Mobile();
        static void Main(string[] args)
        {
            string a;
            // test
            // Method 1
            a = "k";
            Console.WriteLine(a);
            Mobile m = new Mobile();
            m.Id = 1;
            m.ModelName = "Galaxy s4";
            m.Color = "Black";

            // Method 2.  in one line
            Mobile m2a = new Mobile { Id = 2, Color = "Red", ModelName = "iPhone 5s" };

            // Method 2.  in multiple lines (Recommanded)
            // this syntax is called object initialization syntax.  
            // First we were doing through constructos which was a massy way. 
            // usefull when fields are public, and 
            Mobile m2b = new Mobile
            {
                Id = 3,
                Color = "Black",
                ModelName = "iPhone 6s"

            };

            // Method 3 If Mobile depends on another custom class.
            // b. initialize Company when you initialize mobile. 
            Mobile m3 = new Mobile();
            m3.Id = 3;
            m3.ModelName = "6s";
            m3.Color = "Green";
            Company model = new Company
            {
                CompanyName = "Apple"
            };
            Console.WriteLine(model.CompanyName);


            // Method 4 If Mobile depends on another custom class.
            // b. first add new object of company in mobile constructor. 
            Mobile m4 = new Mobile();
            m4.Id = 4;
            m4.ModelName = "Galaxy s5";
            m4.Color = "Blue";
            m4.Companies.CompanyName = "Samsung";
            Console.WriteLine(m4.Companies.CompanyName);


            // Method 6. 

           




            Console.ReadLine();
          
        }
    }


    



}
