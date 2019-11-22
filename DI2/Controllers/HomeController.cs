using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IContext _context;

      


        [HttpGet]
        [Route("mobile")]
        public Mobile Mobile()
        {






           // Mobile m2 = new Mobile (new Model(new Country));

            // Method 1
            Mobile m = new Mobile();
            m.ReleaseYear = new DateTime (2019,1,1);

            Model model = new Model();
            m.Models = model;
            model.ModelName = "Galaxy s4";

            Country c = new Country();
            c.CountryName = "Japan";
            model.Countries = c;


            // Method 2


            return m;
        }



    }
}