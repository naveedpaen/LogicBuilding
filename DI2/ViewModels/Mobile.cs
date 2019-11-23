﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI2
{
    public class Mobile : IMobile
    {


        public Mobile()
        {
            Companies = new Company();
        }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public string processor { get; set; }

        public DateTime ReleaseYear { get; set; }

        public Company Companies { get; set; }



    }
}
