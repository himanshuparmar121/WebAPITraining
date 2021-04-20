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
    public class AreaController : ControllerBase
    {
        private readonly IAreaServices _areaService;

        public AreaController(IAreaServices areaService) 
        {
            _areaService = areaService;
        }

        // To calculate rectangle area
        [HttpGet]
        [Route("{length}/{breath}")]
        public int Area(int length, int breath) 
        {
            return _areaService.Area(length, breath);
        }

        // To calculate square area
        [HttpGet]
        [Route("{side}")]
        public int Area(int side) {
            return _areaService.Area(side);
        }
    }
}