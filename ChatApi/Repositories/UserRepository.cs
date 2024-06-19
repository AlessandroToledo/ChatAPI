using ChatApi.Repositories.Interface;
using Dapper;
using System.Data.SqlClient;

namespace ChatApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public void addUser(string nome)
        {
            using (var sqlConnection = GetConnection())
            {
                const string sql = "INSERT INTO chatusers VALUES (@nome)";
                sqlConnection.Execute(sql, new { nome = nome });
            }
        }

        public int usersOn()
        {
            using (var sqlConnection = GetConnection())
            {
                const string sql = "SELECT COUNT(*) FROM chatusers";
                return sqlConnection.ExecuteScalar<int>(sql);
            }
        }

        public void deleteUser(string nome)
        {
            using (var sqlConnection = GetConnection())
            {
                const string sql = "DELETE FROM chatusers WHERE nome = @nome";
                sqlConnection.Execute(sql, new { nome = nome });
            }
        }

        public IEnumerable<string> GetAllUsers()
        {
            using (var connection = GetConnection())
            {
                const string sql = "SELECT * FROM chatusers";
                return connection.Query<string>(sql);
            }
        }

    }
}
