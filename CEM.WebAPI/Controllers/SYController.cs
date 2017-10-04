using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CEM.Services.Interfaces;

namespace CEM.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SY")]
    public class SYController : Controller
    {
        private readonly ISYService _service;
        public SYController(ISYService service)
        {
            _service = service;
        }

        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }
    }
}