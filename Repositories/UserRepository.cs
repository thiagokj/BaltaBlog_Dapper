using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    //Herda as propriedades e métodos para operações padrão CRUD.
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        // Chama a classe pai para passar a conexão.
        public UserRepository(SqlConnection connection)
        : base(connection)
            => _connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"            
                SELECT
                    [User].*,
                    [Role].*
                FROM
                    [User]
                    LEFT JOIN [UserRole] ON
                    [UserRole].[UserId] =  [User].[Id]
                    LEFT JOIN [Role] ON
                    [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();
            var items = _connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var existingUser = users.FirstOrDefault(x => x.Id == user.Id);
                    if (existingUser == null)
                    {
                        existingUser = user;
                        if (role != null)
                        {
                            existingUser.Roles.Add(role);
                        }
                        users.Add(existingUser);
                    }
                    else
                    {
                        existingUser.Roles.Add(role);
                    }

                    return user;
                }, splitOn: "Id");

            return users;
        }
    }
}