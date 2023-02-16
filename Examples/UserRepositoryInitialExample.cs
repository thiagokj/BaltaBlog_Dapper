// using Blog.Models;
// using Dapper.Contrib.Extensions;
// using Microsoft.Data.SqlClient;

// namespace Blog.Repositories
// {
//     public class UserRepository
//     {
//         private readonly SqlConnection _connection;

//         public UserRepository(SqlConnection connection)
//             => _connection = connection;

//         public IEnumerable<User> Get() => _connection.GetAll<User>();

//         public User Get(int id) => _connection.Get<User>(id);

//         public void Create(User user)
//         {
//             user.Id = 0;
//             _connection.Insert<User>(user);
//         }

//         public void Update(User user)
//         {
//             if (user.Id != 0)
//                 _connection.Update<User>(user);
//         }

//         public void Delete(int id)
//         {
//             if (id != 0) return;

//             var user = _connection.Get<User>(id);
//             _connection.Delete<User>(user);
//         }


//         // Versão de exemplo antes de ser aprimorado
//         // public IEnumerable<User> Get()
//         // {
//         //     using var connection = new SqlConnection(CONNECTION_STRING);
//         //     return connection.GetAll<User>();
//         // }

//         //Versão enxuta
//         // public User Get(int id) => _connection.Get<User>(id);
//     }
// }