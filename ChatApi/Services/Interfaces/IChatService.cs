using ChatApi.Entities;

namespace ChatApi.Services.Interfaces
{
    public interface IChatService
    {
        void sendMessage(Chat chat);
        IEnumerable<Chat> getMessages();
    }
}
