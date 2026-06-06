using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace COurseWork
{
    public class DatabaseManager
    {
        private readonly string connectionString = "Server=localhost;Database=bookstore_db;User ID=root;Password=vova1vova1;";
        private MySqlConnection connection;

        public DatabaseManager()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
