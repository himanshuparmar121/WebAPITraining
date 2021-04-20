using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPITraining.IServices;

namespace WebAPITraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerimeterController : ControllerBase
    {
        private readonly IPerimeterServices _permimeterServices;
        public PerimeterController(IPerimeterServices perimeterServices) {
            _permimeterServices = perimeterServices;
        }

        // To calculate Square's Perimeter
        [HttpGet]
        [Route("{side}")]
        public int Get(int side) 
        {
            return _permimeterServices.Perimeter(side);
        }

        // To calculate Rectangle's Perimeter
        [HttpGet]
        [Route("{length}/{breath}")]
        public int Get(int length, int breath)
        {
            return _permimeterServices.Perimeter(length,breath);
        }
    }
}