using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.IAppServices
{
    public interface IUserAppService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(int id);
        string SaveUser(UserModel user);
        string DeleteUser(int id);

    }
}
