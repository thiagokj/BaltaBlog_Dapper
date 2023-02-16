// using System.Configuration;
// using Blog.Models;
// using Blog.Repositories;
// using Microsoft.Data.SqlClient;

// internal class Program
// {
//     private static string CONNECTION_STRING = ConfigurationManager
//         .ConnectionStrings["SqlServerConnectionString"].ConnectionString;

//     private static void Main(string[] args)
//     {
//         var connection = new SqlConnection(CONNECTION_STRING);
//         connection.Open();



//         connection.Close();
//     }

//     public static void ReadUsers(SqlConnection connection)
//     {
//         var repository = new Repository<User>(connection);
//         var items = repository.Get();

//         foreach (var item in items)
//             Console.WriteLine($"Usuario: {item.Name}");
//     }

//     public static void ReadUsersWithRoles(SqlConnection connection)
//     {
//         var repository = new UserRepository(connection);
//         var items = repository.GetWithRoles();

//         foreach (var item in items)
//         {
//             Console.WriteLine($"Usuario: {item.Name}");
//             Console.WriteLine($"Perfis:");
//             foreach (var role in item.Roles)
//             {
//                 Console.WriteLine($" - {role.Name}");
//             }
//         }
//     }

//     public static void ReadRoles(SqlConnection connection)
//     {
//         var repository = new Repository<Role>(connection);
//         var items = repository.Get();

//         foreach (var item in items)
//             Console.WriteLine($"Cargo: {item.Name}");
//     }

//     public static void ReadTags(SqlConnection connection)
//     {
//         var repository = new Repository<Tag>(connection);
//         var items = repository.Get();

//         foreach (var item in items)
//             Console.WriteLine($"Tag: {item.Name}");
//     }
// }