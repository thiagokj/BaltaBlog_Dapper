using Blog.Screens.CategoryScreens;
using Blog.Screens.PostTagScreens;
using Blog.Screens.ReportsScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserRoleScreens;
using Blog.Screens.UserScreens;

namespace Blog.Screens
{
    public static class MainMenu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("BLOG");
            Console.WriteLine("--------------");
            Console.WriteLine("Menu de opções");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------");
            Console.WriteLine();

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 5:
                    MenuUserRoleScreen.Load();
                    break;
                case 6:
                    MenuPostTagScreen.Load();
                    break;
                case 7:
                    MenuReportScreen.Load();
                    break;
                case 0:
                    Console.Write("Fim da execução.");
                    Environment.Exit(0);
                    break;
                default: Load(); break;
            }
        }
    }
}