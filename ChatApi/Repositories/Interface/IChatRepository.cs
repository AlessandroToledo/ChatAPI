using ChatApi.Entities;

namespace ChatApi.Repositories.Interface
{
    public interface IChatRepository
    {
        void sendMessage(Chat chat);
        IEnumerable<Chat> getMessages();
    }
}
