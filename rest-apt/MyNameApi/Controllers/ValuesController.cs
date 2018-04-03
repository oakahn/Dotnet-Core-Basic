using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Todsphol.Myname;
using System.Net.Http;

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

        [HttpGet("company")]
        public async Task<IActionResult> GetCompany() {
            HttpClient client = new HttpClient();
            HttpResponseMessage reponse = await client.GetAsync("http://10.10.1.8/api/companies/listed");
            string result = await reponse.Content.ReadAsStringAsync();
            return Ok(result);
        }

    }
}
