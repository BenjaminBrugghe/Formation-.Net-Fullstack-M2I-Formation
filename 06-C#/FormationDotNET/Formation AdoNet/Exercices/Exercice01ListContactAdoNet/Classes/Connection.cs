using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice01ListContactAdoNet.Classes
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=(localDB)\PRF2022;Integrated Security=True";

        public static SqlConnection New { get => new SqlConnection(connectionString); }
    }
}
