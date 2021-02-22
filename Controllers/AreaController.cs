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
    public class AreaController : ControllerBase
    {
        // To calculate Square area
        [HttpGet]
        [Route("{side}")]
        public int Get(int side) {
            return side*side;
        } 

        // To calculate rectangle area
        [HttpGet]
        [Route("{length}/{breath}")]
        public int Get(int length, int breath) {
            return length*breath;
        }
    }
}