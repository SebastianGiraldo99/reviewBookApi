using AutoMapper;
using DB.Models;
using OpinionForBooks.AutoMapper;
using OpinionForBooks.IDomainService;
using OpinionForBooks.InterfacesServices;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.Services
{
    public class BookService : IBookAppService
    {
        private readonly IBookDomainService _service;
        private readonly IMapper _mapper;
        public BookService(IBookDomainService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public IEnumerable<BookDTO> GetBooks()
        {
            var books = _service.GetBooks();
            var booksModel = _mapper.Map<IEnumerable<BookDTO>>(books);
            return booksModel;
        }

        public BookDTO GetBook(int id)
        {
           return _mapper.Map<BookDTO>(_service.GetBook(id));
        }

        public string SaveBook(BookModel book)
        {
            try
            {
                var bookMapper = _mapper.Map<Book>(book);
                return _service.SaveBook(bookMapper);
            }
            catch (Exception ex)
            {

                throw new Exception();
            } 
        }

        public string DeleteBook(int id)
        {
            return _service.DeleteBook(id);
        }

        public IEnumerable<CategoryDTO> GetCategories() { 
            var categories = _service.GetCategories();
            var categoryMapper = _mapper.Map<IEnumerable<CategoryDTO>>(categories);
            return categoryMapper;
        }

        public IEnumerable<AutorDTO> GetAutors()
        {
            var autors = _service.GetAutors();
            var autorMapper = _mapper.Map<IEnumerable<AutorDTO>>(autors);
            return autorMapper;
        }

    }
}
