using Microsoft.AspNetCore.Mvc;
using webApp.JokeModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApp.Controllers
{
    [Route("api/vicci")]
    [ApiController]
    public class viccController : ControllerBase
    {
        // GET: api/<ValuesController>
        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var v = from x in context.Jokes
                    where x.JokeSk == id
                    select x;

            return Ok(v);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
