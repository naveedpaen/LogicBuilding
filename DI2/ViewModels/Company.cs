using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI2
{
    public class Company : ICompany
    {
        public int Id { get; set; }

        public string CompantyName { get; set; }

        public Country Countries { get; set; }

    }
}
