using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados da nova tag:");
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag
            {
                Name = name,
                Slug = slug
            };

            Create(tag);
            Console.Write("");
            Console.WriteLine("Cadastro realizado. Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}