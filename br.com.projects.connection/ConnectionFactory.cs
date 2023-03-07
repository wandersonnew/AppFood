using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.connection
{
    internal class ConnectionFactory
    {
        public MySqlConnection mysqlonnnection()
        {
            try
            {
                var stringconn = "server=localhost;uid=root;pwd=;database=appfood";
                var connection = new MySqlConnection(stringconn);
                connection.Open();

                return connection;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Fail: " + erro);
                throw;
            }
        }
    }
}
