namespace ChatApi.Services.Interfaces
{
    public interface IUserService
    {
        void addUser(string nome);
        int usersOn();
        void deleteUser(string nome);
        IEnumerable<string> GetAllUsers();
    }
}
