using BooksClass;
using DB.Models;
using OpinionForBooks.IDomainService;

namespace OpinionForBooks.DomainServices
{
    public class UserDomainService : IUserDomainService
    {

        private readonly ControlBoxContext _contex;
        public UserDomainService(ControlBoxContext contex)
        {
            _contex = contex;            
        }
        public string DeleteUser(int id)
        {
            var data = _contex.Users.Find(id);
            if (data != null)
            {
                data.Status = 0;
                _contex.SaveChanges();
                return "El usuario ha eliminado con exito";
            }
            else
            {
                return "El Usuario no existe";
            }
        }

        public User GetUser(int id)
        {
            return _contex.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _contex.Users.Where(x => x.Status != 0).ToList();
        }

        public string SaveUser(User user)
        {
            try
            {
                _contex.Add(user);
                _contex.SaveChanges();
                return "Creado con exito";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
