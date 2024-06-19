namespace ChatApi.Repositories.Interface
{
    public interface IUserRepository
    {
        void addUser(string nome);
        int usersOn();
        void deleteUser(string nome);
        IEnumerable<string> GetAllUsers();
    }
}
