// using Blog;
// using Blog.Repositories;
// using Dapper.Contrib.Extensions;
// using Microsoft.Data.SqlClient;

// internal class Program
// {
//     private const string CONNECTION_STRING = @"Server=localhost,1433;
//      Database=Blog; User ID=sa; Password=********";

//     private static void Main(string[] args)
//     {
//         Console.Clear();

//         var connection = new SqlConnection(CONNECTION_STRING);
//         connection.Open();

//         ReadUsers(connection);
//         ReadRoles(connection);

//         connection.Close();
//     }

//     public static void ReadUsers(SqlConnection connection)
//     {
//         var repository = new UserRepository(connection);
//         var users = repository.Get();

//         foreach (var user in users)
//             Console.WriteLine($"Usuario: {user.Name}");

//     }

//     public static void ReadRoles(SqlConnection connection)
//     {
//         var repository = new RoleRepository(connection);
//         var roles = repository.Get();

//         foreach (var role in roles)
//             Console.WriteLine($"Cargo: {role.Name}");
//     }
// }