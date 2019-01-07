using System;

namespace Question_mark
{
    public class Model
    {
        public Model2 Model2 { get; set; }
    }
    public class Model2
    {
        public Model3 Model3 { get; set; }
    }
    public class Model3
    {
        public Model4 Model4 { get; set; }
    }
    public class Model4
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Model = new Model
            {
                Model2 = new Model2
                {
                    Model3 = new Model3
                    {
                        Model4 = new Model4()
                    }
                }
            };

            Console.WriteLine("Name is null: {0}", Model.Model2.Model3.Model4.Name == null);

            var name = Model.Model2?.Model3?.Model4?.Name ?? "N/A";

            Console.WriteLine(name);


            Console.ReadLine();
        }
    }
}
