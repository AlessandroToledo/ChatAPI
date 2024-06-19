namespace ChatApi.Services
{
    public interface IUserService
    {
        void adduser(string nome);
        int usersOn();
        void deleteUser(string nome);
        IEnumerable<string> GetAllUsers();
    }
}
