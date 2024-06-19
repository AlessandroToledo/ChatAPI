using ChatApi.Repositories;

namespace ChatApi.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void adduser(string nome)
        {
            _userRepository.addUser(nome);
        }

        public void deleteUser(string nome)
        {
            _userRepository.deleteUser(nome);
        }

        public IEnumerable<string> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public int usersOn()
        {
            return _userRepository.usersOn();
        }
    }
}
