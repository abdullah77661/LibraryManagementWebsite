using LMS_APIs.Data;
using LMS_APIs.Models;
using LMS_APIs.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace LMS_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _bookService;
        private readonly ApplicationDBContext _context;

        // Constructor should inject both the service and the context
        public BookController(IBook bookService, ApplicationDBContext context)
        {
            _bookService = bookService;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            // Return books from the service
            return _bookService.GetBooks();
        }

        [HttpGet("GetAllBookList")]
        public List<Book> GetAllBookList()
        {
            // Using FromSqlRaw to execute raw SQL query
            string sql = "SELECT * FROM Books";

            // Execute the query and map the results to a list of Books.
            var collection = _context.Books.FromSqlRaw(sql).ToList();

            // Return the list of Books.
            return collection;
        }




        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null) return NotFound("Not Found");
            return book;
        }

        [HttpPost]
        public ActionResult<Book> PostBook(Book book)
        {
            return _bookService.PostBook(book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, Book book)
        {
            var updatedAuthor = _bookService.UpdateBook(id, book);
            if (updatedAuthor == null) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var deleted = _bookService.DeleteBook(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
