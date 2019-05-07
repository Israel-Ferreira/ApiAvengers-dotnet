using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvengersNegocio;
using Microsoft.AspNetCore.Mvc;

namespace AvengersAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvengersController : ControllerBase
    {
        AvengerNegocio _avengerNegocio = new AvengerNegocio();
        // GET api/values
        [HttpGet]
        [Route("Pegar")]
        public IActionResult Get()
        {
            return Ok(_avengerNegocio.Get());
        }

     
        [HttpDelete]
        [Route("Deletar")]
        public IActionResult Delete()
        {
            return Ok(_avengerNegocio.Delete());
        }
    }
}
