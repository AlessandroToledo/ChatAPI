using ChatApi.Entities;

namespace ChatApi.Services
{
    public interface IChatService
    {
        void sendMessage(Chat chat);
        IEnumerable<Chat> getMessages();
    }
}
