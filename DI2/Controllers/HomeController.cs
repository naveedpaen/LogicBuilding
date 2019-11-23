using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI2.Controllers
{
    // karachi
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IContext _context;
        Mobile m6 = new Mobile(); 
        
        [HttpGet]
        [Route("mobile")]
        public Mobile Mobile()
        {
            // Method 1
            m6.ModelName = "Samsung s4";
            m6.Companies.CompantyName = "Samsung";
            return m;
        }



    }
}