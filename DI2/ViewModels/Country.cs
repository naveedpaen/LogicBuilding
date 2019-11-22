using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI2
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
