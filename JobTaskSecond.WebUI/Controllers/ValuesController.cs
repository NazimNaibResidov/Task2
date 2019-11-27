using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobTaskSecond.WebUI.Core;
using Microsoft.AspNetCore.Mvc;

namespace JobTaskSecond.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
      static  List<string> sozler = new List<string>();
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Tools.SaveReverseString(sozler.ToArray());
            return sozler.ToList();
        }
 
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public void Post([FromBody] string name)
        {
            var soz = Tools.ReverseString(name);
            sozler.Add(soz);
            
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
       
    }
}
