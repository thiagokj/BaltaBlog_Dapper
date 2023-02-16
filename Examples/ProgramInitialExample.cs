// using Blog;
// using Dapper.Contrib.Extensions;
// using Microsoft.Data.SqlClient;

// // private const string CONNECTION_STRING = @"Server=localhost,1433;
// //  Database=Blog; User ID=sa; Password=********";

// // static void Main(string[] args)
// // {
// //     Console.Clear();

// //     // ReadUsers();
// //     // ReadUser();
// //     // CreateUser();
// //     // UpdateUser();
// //     DeleteUser();
// // }

// static void CreateUser()
// {
//     var user = new User()
//     {
//         Name = "Usuario",
//         Email = "usuario@email.au",
//         PasswordHash = "HASH",
//         Bio = "Biografia aqui",
//         Image = "https://imagem",
//         Slug = "usuario-do-blog"
//     };

//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var returnId = connection.Insert<User>(user);
//         Console.WriteLine($"Novo usuário criado com Id: {returnId}.");
//     }
// }

// static void UpdateUser()
// {
//     var user = new User()
//     {
//         Id = 4,
//         Name = "Cristiano Ronaldo",
//         Email = "cr7@emailcomercial.mq",
//         PasswordHash = "HASH4444",
//         Bio = "Biografia nova",
//         Image = "https://imagem",
//         Slug = "cristiano-ronaldo"
//     };

//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var returnId = connection.Update<User>(user);
//         Console.WriteLine($"Usuário atualizado: {returnId}.");
//     }
// }

// static void DeleteUser()
// {
//     //Forma alternativa
//     // var user = new User()
//     // {
//     //     Id = 3
//     // };

//     // using (var connection = new SqlConnection(CONNECTION_STRING))
//     // {
//     //     var returnId = connection.Delete<User>(user);
//     //     Console.WriteLine($"Usuário removido: {returnId}.");
//     // }

//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var user = connection.Get<User>(2);
//         connection.Delete<User>(user);

//         Console.WriteLine($"Usuario {user.Name} removido.");
//     }


// }

// static void ReadUsers()
// {
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var users = connection.GetAll<User>();
//         foreach (var user in users)
//         {
//             Console.WriteLine($"Usuario: {user.Name}");
//         }
//     }
// }

// static void ReadUser()
// {
//     using (var connection = new SqlConnection(CONNECTION_STRING))
//     {
//         var user = connection.Get<User>(1);

//         Console.WriteLine($"Usuario: {user.Name}");

//     }
// }
