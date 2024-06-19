using ChatApi.Entities;
using ChatApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatApi.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : Controller
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpGet]
        public ActionResult getMessages()
        {
            try
            {
                var chat = _chatService.getMessages();
                return Ok(chat);
            }
            catch
            {
                return BadRequest("Falha!!");
            }
        }

        [HttpPost]
        public ActionResult sendMessage([FromBody] Chat chat)
        {
            try
            {
                _chatService.sendMessage(chat);
                return Ok("Sucesso!!");
            }
            catch
            {
                return BadRequest("Falha!!");
            }
        }
    }
}
