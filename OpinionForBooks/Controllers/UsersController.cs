using Microsoft.AspNetCore.Mvc;
using OpinionForBooks.IAppServices;
using OpinionForBooks.Models;
using OpinionForBooks.Models.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OpinionForBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserAppService _service;
        public UsersController(IUserAppService service)
        {
            _service = service;
        }
        // GET: api/<UserController>
        [HttpGet("GetAllUsers")]
        public IEnumerable<UserDTO> GetUsers()
        {
            return _service.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("GetUser")]
        public UserDTO GetUser(int id)
        {
            return _service.GetUser(id);
        }

        // POST api/<UserController>
        [HttpPost("SaveUser")]
        public string SaveUser([FromBody] UserModel value)
        {
            return _service.SaveUser(value);
        }

        // PUT api/<UserController>/5
        [HttpPost("DeleteUser")]
        public string DeleteUser(int id)
        {
            return _service.DeleteUser(id);
        }
    }
}
