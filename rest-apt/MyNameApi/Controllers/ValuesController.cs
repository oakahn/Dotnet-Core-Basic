using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Myname;

namespace MyNameApi.Controllers
{

    [Route("api/[controller]")]
    public class NameController : Controller
    {
        // GET api/name
        [HttpGet]
        public IActionResult Get()
        {
            Name name = new Name();
            dynamic obj = new ExpandoObject();
            obj.name = name.Get();
            return Ok(obj);

        }

    }
}
