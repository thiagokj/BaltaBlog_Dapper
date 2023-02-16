namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreen
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
                    ListRolesScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
                    break;
                case 3:
                    UpdateRoleScreen.Load();
                    break;
                case 4:
                    DeleteRoleScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}