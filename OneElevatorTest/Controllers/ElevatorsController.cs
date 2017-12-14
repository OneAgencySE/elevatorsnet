using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OneElevatorTest.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneElevatorTest.Controllers
{
    [Route("api/[controller]")]
    public class ElevatorsController : Controller
    {
        // GET: api/elevators
        [HttpGet]
        public IActionResult Get()
        {
            var ElevatorList = new List<Elevator>();
            // do some magic



            return Ok(JsonConvert.SerializeObject(ElevatorList));
        }

        // GET api/elevators/5
        [HttpGet("{id}")]
        public IActionResult GetElevator(int id)
        {                                                                                               
            return Ok(Json(""));
        }

    }
}
