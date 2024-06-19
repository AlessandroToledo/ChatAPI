//using Dapper;
//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.Mvc;
//using System.Data.SqlClient;

//namespace ChatApi.Controllers
//{
//    [ApiController]
//    [Route("chat/users")]
//    public class ChatController : Controller
//    {
//        private readonly string _connectionString;
//        public ChatController(IConfiguration configuration) 
//        {
//            _connectionString = configuration.GetConnectionString("DefaultConnection");
//        }

//        [HttpGet("{nome}")]
//        public async Task<IActionResult> GetByName(string nome)
//        {
//            var parameters = new
//            {
//                nome
//            };

//            using (var sqlConnection = new SqlConnection(_connectionString))
//            {
//                const string sql = "SELECT * FROM chatusers WHERE nome = @nome";

//                try
//                {
//                    var user = await sqlConnection.QueryFirstAsync(sql, parameters);
//                    return Ok(user);
//                }
//                catch (Exception)
//                {
//                    return BadRequest("Nome de usuário não existe");
//                }

//            }
//        }

//        [HttpPost("{nome}")]
//        public async Task<IActionResult> AddUser(string nome)
//        {
//            var parameters = new
//            {
//                nome
//            };

//            using (var sqlConnection = new SqlConnection(_connectionString))
//            {
//                const string sql = "INSERT INTO chatusers VALUES (@nome)";
//                try
//                {
//                    await sqlConnection.ExecuteAsync(sql, parameters);
//                    var response = new
//                    {
//                        Message = "Adicionado com sucesso",
//                        Nome = nome
//                    };
//                    return Ok(response);
//                }
//                catch (Exception)
//                {
//                    return BadRequest(new { Message = "Nome de usuário já em uso" });
//                }
//            }
//        }

//        [HttpDelete("{nome}")]
//        public async Task<IActionResult> RemoveUser(string nome)
//        {
//            var parameters = new
//            {
//                nome
//            };

//            using (var sqlConnection = new SqlConnection(_connectionString))
//            {
//                const string sql = "DELETE FROM chatusers WHERE nome = @nome";
//                try
//                {
//                    var user = await sqlConnection.ExecuteScalarAsync<string>(sql, parameters);
//                    return Ok("Usuário removido com sucesso");
//                }
//                catch (Exception)
//                {
//                    return BadRequest("Nome de usuário não existe");
//                }
//            }
//        }

//        [HttpGet("count")]
//        public async Task<IActionResult> GetCount()
//        {
//            using (var sqlConnection = new SqlConnection(_connectionString))
//            {
//                const string sql = "SELECT COUNT(*) FROM chatusers";
//                try
//                {
//                    var count = await sqlConnection.ExecuteScalarAsync<int>(sql);
//                    return Ok(new { Count = count });
//                }
//                catch (Exception ex)
//                {
//                    // Log the exception
//                    return StatusCode(500, new { Message = "Erro no servidor", Details = ex.Message });
//                }
//            }
//        }
//    }
//}
