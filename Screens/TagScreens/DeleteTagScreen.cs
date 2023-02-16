using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Informe o Id da tag para exclusão:");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            var tag = int.Parse(id);

            Delete(tag);
            Console.Write("");
            Console.WriteLine("Registro excluído. Pressione qualquer tecla para voltar.");
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}