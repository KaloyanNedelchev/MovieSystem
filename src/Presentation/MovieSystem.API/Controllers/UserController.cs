using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.DTOs.UserDTOs;

namespace MovieSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<UserReadDTO> GetAll()
        {
            return _userService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public UserReadDTO GetById(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] UserCreateDTO userFromRequest)
        {
            _userService.Add(userFromRequest);
        }

        [HttpPut]
        public void Put([FromBody] UserUpdateDTO userFromRequest)
        {
            _userService.Update(userFromRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}
