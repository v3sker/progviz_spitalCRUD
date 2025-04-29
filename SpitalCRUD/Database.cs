using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SpitalCRUD
{
    internal class Database
    {
        private static string connectionString = "Host=localhost;Database=spital;Username=postgres;Password=root";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
