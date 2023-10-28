using DB.Models;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.IDomainService
{
    public interface IBookDomainService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        string SaveBook(Book book);
        string DeleteBook(int id);
        IEnumerable<Category> GetCategories();
        IEnumerable<Autor> GetAutors();
    }
}
