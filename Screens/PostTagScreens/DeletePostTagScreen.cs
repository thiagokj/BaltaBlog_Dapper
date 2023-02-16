namespace Blog.Screens.PostTagScreens
{
    public static class DeletePostTagScreen
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
            Console.WriteLine("----------------");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);
            Console.WriteLine(option);

            switch (option)
            {
                case 1:
                    Load();
                    break;
                case 2:
                    Load();
                    break;
                default: Load(); break;
            }
        }
    }
}