using ChatApi.Repositories.Interface;
using ChatApi.Services.Interfaces;

namespace ChatApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void addUser(string nome)
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
