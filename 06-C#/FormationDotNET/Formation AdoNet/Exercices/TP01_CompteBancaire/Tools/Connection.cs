using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_CompteBancaire.Tools
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(LocalDb)\mssqllocaldb;Initial Catalog=PRF2022;Integrated Security=True";
        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
