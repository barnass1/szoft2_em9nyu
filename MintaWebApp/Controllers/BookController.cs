using Microsoft.AspNetCore.Mvc;
using MintaWebApp.BookModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MintaWebApp.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/<BookController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Books.ToList());
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var book = context.Books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();  
            }

            return Ok(book);
        }

        // POST api/<BookController>
        [HttpPost]
        public IActionResult Post([FromBody] Book newBook)
        {
            if (newBook == null)
            {
                return BadRequest("A könyv adatai nem érvényesek.");
            }

            using (FunnyDatabaseContext context = new FunnyDatabaseContext())
            {
                // A könyvet hozzáadjuk az adatbázishoz
                context.Books.Add(newBook);

                // Mentsük el a változtatásokat az adatbázisba
                context.SaveChanges();

                // Visszaküldjük a 201 Created státuszkódot és az új könyv adatokat
                return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
            }
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (FunnyDatabaseContext context = new FunnyDatabaseContext())
            {
                // Keresés a könyv alapján az id-val
                var book = context.Books.FirstOrDefault(b => b.Id == id);

                // Ha nem találjuk a könyvet, akkor 404-es hiba
                if (book == null)
                {
                    return NotFound();  // 404 - Book not found
                }

                // Töröljük a könyvet
                context.Books.Remove(book);
                context.SaveChanges();  // Mentsük el a változtatásokat az adatbázisban

                // Ha a törlés sikeres, visszaküldjük a 200 OK választ
                return Ok();
            }
        }
    }
}
