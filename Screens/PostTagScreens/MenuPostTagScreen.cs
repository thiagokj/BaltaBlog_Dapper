namespace Blog.Screens.PostTagScreens
{
    public static class MenuPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar usuarios");
            Console.WriteLine("2 - Cadastrar usuarios");
            Console.WriteLine("3 - Atualizar usuarios");
            Console.WriteLine("2 - Apagar usuarios");
            Console.WriteLine("----------------");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);
            Console.WriteLine(option);

            switch (option)
            {
                case 1:
                    ListPostTagsScreen.Load();
                    break;
                case 2:
                    CreatePostTagScreen.Load();
                    break;
                case 3:
                    UpdatePostTagScreen.Load();
                    break;
                case 4:
                    DeletePostTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}