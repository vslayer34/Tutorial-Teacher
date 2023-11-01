using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPIApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "Mohamed", "El-Nagar" };
        // }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"{id}";
        }

        [HttpPost("{value}")]
        public void Post([FromBody] string value) { }
    }
}