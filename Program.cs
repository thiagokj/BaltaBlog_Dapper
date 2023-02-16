using System.Configuration;
using Microsoft.Data.SqlClient;
using Blog;
using Blog.Screens;

internal class Program
{
    private static string CONNECTION_STRING = ConfigurationManager
        .ConnectionStrings["SqlServerConnectionString"].ConnectionString;

    private static void Main(string[] args)
    {
        Database.Connection = new SqlConnection(CONNECTION_STRING);
        Database.Connection.Open();

        MainMenu.Load();

        Console.ReadKey();
        Database.Connection.Close();
    }

}