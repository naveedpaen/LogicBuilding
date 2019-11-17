using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI2
{
    public class Mobile : IMobile
    {

        public Mobile()
        {

        }


        public int Id { get; set; }

        public DateTime ReleaseYear { get; set; }

        public Model Models { get; set; }

        

    }
}
