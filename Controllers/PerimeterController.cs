using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerimeterController : ControllerBase
    {
        // To calculate Square's Perimeter
        [HttpGet]
        [Route("{side}")]
        public int Get(int side) 
        {
            return 4*side;
        }

        // To calculate Rectangle's Perimeter
        [HttpGet]
        [Route("{length}/{breath}")]
        public int Get(int length, int breath)
        {
            return 2*(length+breath);
        }
    }
}