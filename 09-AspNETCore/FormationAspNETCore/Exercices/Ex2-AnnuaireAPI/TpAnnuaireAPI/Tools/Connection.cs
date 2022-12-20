using System.Data.SqlClient;

namespace TpAnnuaireAPI.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source = (LocalDb)\PRF2022; Integrated Security = True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
