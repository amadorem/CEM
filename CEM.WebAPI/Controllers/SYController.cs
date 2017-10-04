using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CEM.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SY")]
    public class SYController : Controller
    {

        public IActionResult Get()
        {
            return NoContent();
        }
    }
}