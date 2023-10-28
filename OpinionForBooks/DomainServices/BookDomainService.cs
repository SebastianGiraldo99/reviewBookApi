using BooksClass;
using DB.Models;
using Microsoft.EntityFrameworkCore;
using OpinionForBooks.IDomainService;
using OpinionForBooks.Models;

namespace OpinionForBooks.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly ControlBoxContext _contex;
        public BookDomainService(ControlBoxContext contex)
        {
            _contex = contex;   
        }

        public string DeleteBook(int id)
        {
            var data = _contex.Books.Find(id);
            if (data != null)
            {
                data.Status = 0;
                _contex.SaveChanges();
                return "Libro eliminado con exito";
            }
            else
            {
                return "El libro no existe";
            }
        }

        public Book GetBook(int id)
        {
            return _contex.Books.Find(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _contex.Books.
                Include(x => x.Category).
                Include(x => x.Autor).
                Where(x => x.Status != 0).ToList();
        }

        public string SaveBook(Book book)
        {
            try
            {
                _contex.Add(book);
                _contex.SaveChanges();
                return "Creado con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public IEnumerable<Category> GetCategories()
        {
            return _contex.Categories.Where(x => x.Status != 0).ToList();
        }

        public IEnumerable<Autor> GetAutors()
        {
            return _contex.Autors.Where(x => x.Status != 0).ToList();
        }
    }
}
