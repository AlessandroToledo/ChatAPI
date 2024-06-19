using ChatApi.Entities;
using ChatApi.Repositories.Interface;
using Dapper;
using System.Data.SqlClient;

namespace ChatApi.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly string _connectionString;
        public ChatRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public void sendMessage(Chat chat)
        {
            using (var sqlConnection = GetConnection())
            {
                const string sql = "INSERT INTO chat VALUES (@remetente, @texto)";
                sqlConnection.Execute(sql, chat);
            }
        }

        public IEnumerable<Chat> getMessages()
        {
            using (var connection = GetConnection())
            {
                const string sql = "SELECT TOP (50) [remetente],[texto] FROM chat ORDER BY [id] DESC";
                return connection.Query<Chat>(sql);
            }
        }
    }
}
