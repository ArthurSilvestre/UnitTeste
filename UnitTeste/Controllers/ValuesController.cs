using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace UnitTeste.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values/5
        [HttpGet("{value}")]
        public bool Get(int value) {
            PrimeService service = new PrimeService();

            return service.IsPrime(value);
        }
        
    }
}
