using OpinionForBooks.Models.DTO;
using OpinionForBooks.Models;
using DB.Models;

namespace OpinionForBooks.IDomainService
{
    public interface IUserDomainService
    {

        IEnumerable<User> GetUsers();
        User GetUser(int id);
        string SaveUser(User user);
        string DeleteUser(int id);

    }
}
