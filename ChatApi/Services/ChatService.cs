using ChatApi.Entities;
using ChatApi.Repositories;

namespace ChatApi.Services
{
    public class ChatService : IChatService
    {
        private readonly ChatRepository _chatRepository;

        public ChatService(ChatRepository chatRepository) 
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
