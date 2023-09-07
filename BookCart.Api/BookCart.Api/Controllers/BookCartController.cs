using BookCart.Models.ViewModels;
using BookCart.Services.BookCart;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BookCart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCartController : ControllerBase
    {
        private readonly IBookCartService _bookCartService;

        public BookCartController(IBookCartService bookCartService)
        {
            _bookCartService = bookCartService;
        }

        //Get All Books
        [HttpGet]
        public async Task<ActionResult<string>> GetBookList()
        {
            var bookdata = await _bookCartService.GetBookList();
            return Ok(JsonSerializer.Serialize(bookdata));
        }

        //Get Single Book
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetBook(Guid id)
        {
            var bookdata = await _bookCartService.GetBook(id);
            if (bookdata != null)
            {
                return Ok(JsonSerializer.Serialize(bookdata));
            }
            return NotFound(JsonSerializer.Serialize(bookdata));
        }

        //Add Books
        [HttpPost]
        public async Task<ActionResult<string>> CreateBook(BookCartViewModel books)
        {
            var book = await _bookCartService.CreateBook(books);
            return Ok(book);
        }
    }
}
