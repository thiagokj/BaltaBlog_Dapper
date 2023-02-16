using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[User]")]
    public class User
    {
        public User() => Roles = new List<Role>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        // Relação no banco muitos para muitos (Tabela UserRoles).
        // Essa relação pode ser representada como uma lista,
        // em apenas uma das entidades.      
        [Write(false)] // Anotação Write | Evita que seja incluido um role ao criar um novo usuario
        public List<Role> Roles { get; set; }
    }
}