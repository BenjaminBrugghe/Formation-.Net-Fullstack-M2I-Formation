using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_ListeContacts.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(localDB)\MSSQLLOCALDB;Initial Catalog=PRF2022_EFCore;Integrated Security=True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
