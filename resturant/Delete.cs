using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace resturant
{
    class Delete
    {
        public string connectionString;
        public Delete ()
        {
            connectionString = "server=sql.freedb.tech;database=freedb_MySQLbase;uid=freedb_Togyas;pwd=9KzW9C9?%7N#GrU;";

        }
        public void DeleteAll(string MyTable)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand($"DELETE FROM {MyTable}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
