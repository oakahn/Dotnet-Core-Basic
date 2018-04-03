using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace MyNameApi.Controllers
{
    
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        // GET api/name
        [HttpGet]
        public IActionResult Get()
        {
             dynamic obj = new ExpandoObject();
            obj.name = "Watch me";
            return Ok(obj);

        }

    }
}
