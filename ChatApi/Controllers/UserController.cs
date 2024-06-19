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
            } catch (Exception ex) {
            
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
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
                var response = new Response
                {
                    Message = ex.Message
                };
                return BadRequest(response);
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
            catch
            {
                return BadRequest("Falha!!");
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
            catch
            {
                return BadRequest("Falha!!");
            }
        }

    }
}

public class Response
{
    public string Message { get; set; }
}
