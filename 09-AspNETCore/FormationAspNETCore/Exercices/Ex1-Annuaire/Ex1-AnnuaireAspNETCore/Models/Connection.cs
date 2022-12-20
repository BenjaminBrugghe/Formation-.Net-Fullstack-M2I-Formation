using System.Data.SqlClient;

namespace Ex1_AnnuaireAspNETCore.Models
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(localDB)\MSSQLLOCALDB;Initial Catalog=PRF2022_EFCore;Integrated Security=True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
