using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksClass
{
    public class ControlBoxContext : DbContext
    {
        public ControlBoxContext(DbContextOptions<ControlBoxContext> options): base(options) 
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ReviewBook> ReviewBooks { get; set; }



    }
}