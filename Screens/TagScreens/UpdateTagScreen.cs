using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe os dados da tag:");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            };

            Update(tag);
            Console.Write("");
            Console.WriteLine("Dados atualizados. Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}