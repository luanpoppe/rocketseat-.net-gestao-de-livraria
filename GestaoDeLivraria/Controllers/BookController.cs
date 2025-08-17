using GestaoDeLivraria.Communication.Requests;
using GestaoDeLivraria.Communication.Responses;
using GestaoDeLivraria.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : GestaoDeLivrariaBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterBookJson body)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Author = body.Author,
                Genre = body.Genre,
                InStock = body.InStock,
                Price = body.Price,
                Title = body.Title,
            };
            BooksTemporaryDB.Books.Add(book);

            return Created(string.Empty, book);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {

            return Ok(BooksTemporaryDB.Books);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(BookNotFoundJson), StatusCodes.Status400BadRequest)]
        public IActionResult GetAll(Guid id, [FromBody] RequestRegisterBookJson body)
        {
            var bookNewInfo = new Book
            {
                Id = id,
                Author = body.Author,
                Genre = body.Genre,
                InStock = body.InStock,
                Price = body.Price,
                Title = body.Title,
            };

            var bookIndex = BooksTemporaryDB.Books.FindIndex(b => b.Id == id);

            if (bookIndex == -1)
            {
                return BadRequest(new BookNotFoundJson());
            }

            BooksTemporaryDB.Books[bookIndex] = bookNewInfo;

            return Ok(BooksTemporaryDB.Books[bookIndex]);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(BookNotFoundJson), StatusCodes.Status400BadRequest)]
        public IActionResult Delete(Guid id)
        {
            var bookIndex = BooksTemporaryDB.Books.FindIndex(b => b.Id == id);

            if (bookIndex == -1)
            {
                return BadRequest(new BookNotFoundJson());
            }

            BooksTemporaryDB.Books.RemoveAt(bookIndex);

            return NoContent();
        }
    }
}
