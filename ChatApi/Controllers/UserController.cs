using ChatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatApi.Controllers
{
    [ApiController]
    [Route("chat/")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("{nome}")]
        public IActionResult AddUser(string nome)
        {
            try
            {
                _userService.addUser(nome);
                return Ok("Sucesso!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{nome}")]
        public IActionResult DeleteUser(string nome)
        {
            try
            {
                _userService.deleteUser(nome);
                return Ok("Sucesso!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("usersOn")]
        public IActionResult GetUser()
        {
            try
            {
                var count = _userService.usersOn();
                return Ok(count);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("allUsers")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
