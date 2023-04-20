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
    public class IdManager
    {
        public MySqlConnection connection;
        public string connectionString;

        public IdManager()
        {
            connectionString = "server=sql.freedb.tech;database=freedb_MySQLbase;uid=freedb_Togyas;pwd=9KzW9C9?%7N#GrU;";
            connection = new MySqlConnection(connectionString);
        }

        public int GetLastID()
        {
            int lastID = 0;
            try
            {
                connection.Open();
                string query = "SELECT MAX(ID) FROM MyTable";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lastID = reader.GetInt32(0);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lastID;
        }
    }
     
}
