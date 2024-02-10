using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBD
{
    internal class DBConnect
    {
        private MySqlConfiguration _connection;
        private string server;
        private string username;
        private string password;
        private string database;
        private string port;

        private void Initialize()
        {
            server = "localhost\\SQLEXPRESS";
            database = "gestaoformandos";
            username = "localhost\\Gabriela";
        }
    }
}
