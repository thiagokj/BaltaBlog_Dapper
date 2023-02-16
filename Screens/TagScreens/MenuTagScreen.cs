namespace Blog.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tags");
            Console.WriteLine("3 - Atualizar tags");
            Console.WriteLine("4 - Apagar tags");
            Console.WriteLine("----------------");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);
            Console.WriteLine(option);

            switch (option)
            {
                case 1:
                    ListTagsScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}