using DB.Models;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.InterfacesServices
{
    public interface IBookAppService
    {
        IEnumerable<BookDTO> GetBooks();
        BookDTO GetBook(int id);
        string SaveBook(BookModel book);
        string DeleteBook(int id);

        IEnumerable<CategoryDTO> GetCategories();

        IEnumerable<AutorDTO>GetAutors();  
    }
}
