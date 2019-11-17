using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI2
{
    public class Model : IModel
    {
        public int Id { get; set; }

        public string ModelName { get; set; }

        public Country Countries { get; set; }

    }
}
