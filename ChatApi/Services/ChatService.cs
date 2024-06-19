using ChatApi.Entities;
using ChatApi.Repositories.Interface;
using ChatApi.Services.Interfaces;

namespace ChatApi.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository) 
        {
            _chatRepository = chatRepository;
        }

        public IEnumerable<Chat> getMessages()
        {
            return _chatRepository.getMessages();
        }

        public void sendMessage(Chat chat)
        {
            _chatRepository.sendMessage(chat);
        }
    }
}
