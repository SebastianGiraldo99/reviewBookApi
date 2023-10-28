using DB.Models;
using Microsoft.AspNetCore.Mvc;
using OpinionForBooks.InterfacesServices;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpinionForBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookAppService _service;
        public BooksController(IBookAppService service)
        {
            _service = service;
        }
        // GET: api/<BooksController>
        [HttpGet("GetAllBooks")]
        public IEnumerable<BookDTO> GetBooks()
        {
            return _service.GetBooks();
        }

        // GET api/<BooksController>/5
        [HttpGet("GetBook")]
        public BookDTO GetBook(int id)
        {
            return _service.GetBook(id);
        }

        // POST api/<BooksController>
        [HttpPost("SaveBook")]
        public string Post([FromBody] BookModel value)
        {
            try
            {
                return _service.SaveBook(value);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // DELETE api/<BooksController>/5
        [HttpPost("DeleteBook")]
        public string Delete(int id)
        {
            try
            {
                return _service.DeleteBook(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        [HttpGet("GetCategories")]
        public IEnumerable<CategoryDTO> GetCategories() { 
            return _service.GetCategories();
        }

        [HttpGet("GetAutors")]
        public IEnumerable<AutorDTO> GetAutors()
        {
            return _service.GetAutors();
        }
    }
}
