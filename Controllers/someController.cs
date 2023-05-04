using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParadiseSpa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class someController : ControllerBase
    {
        // GET: api/<someController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<someController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<someController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {

            try
            {
                return Ok(new { Ok = true });

            }
            catch (Exception e)
            {
                return Ok(new {Ok = false});
            }
        }

        // PUT api/<someController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<someController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
