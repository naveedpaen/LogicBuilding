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

            Mobile m = new Mobile();
            m.Id = 1;
            m.ReleaseYear = new DateTime (2019,1,1);

            Model modelObj = new Model();
            m.Models = modelObj;
            modelObj.Id = 1;
            modelObj.ModelName = "Galaxy s4";

            Country c = new Country();
            c.Id = 1;
            c.CountryName = "Japan";
            modelObj.Countries = c;



            return m;
        }



    }
}