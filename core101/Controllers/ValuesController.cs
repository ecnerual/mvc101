using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core101.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace core101.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/values/5
        [HttpGet("{nom}")]
        public ActionResult<string> Get(string nom)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("toUpper")]
        public IActionResult ToUpperPost(PostToUpperCaseDTO request)
        {
            var response = new PostToUpperResponseDTO();

            response.upperCaseName = request.name.ToUpper();
            response.isOld = request.age > 20;

            return Ok(response);
        }


        // GET api/values/toupper/imen
        [HttpGet("toupper/{nom}")]
        public ActionResult<string> ToUpper(string nom)
        {
            return nom.ToUpper();
        }
    }
}
