using AutoMapper;
using DB.Models;
using OpinionForBooks.DomainServices;
using OpinionForBooks.IAppServices;
using OpinionForBooks.IDomainService;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

namespace OpinionForBooks.Services
{
    public class UserService : IUserAppService
    {
        private readonly IUserDomainService _service;
        private readonly IMapper _mapper;
        public UserService(IUserDomainService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }
        public string DeleteUser(int id)
        {
            return _service.DeleteUser(id);
        }

        public UserDTO GetUser(int id)
        {
            return _mapper.Map<UserDTO>(_service.GetUser(id));
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            var users = _service.GetUsers();
            var usersMapper = _mapper.Map<IEnumerable<UserDTO>>(users);
            return usersMapper;
        }

        public string SaveUser(UserModel user)
        {
            try
            {
                var userMapper = _mapper.Map<User>(user);
                return _service.SaveUser(userMapper);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
