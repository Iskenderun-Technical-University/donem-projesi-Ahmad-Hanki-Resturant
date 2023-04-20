using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace resturant
{
    public static class DatabaseReader
    {
        public static string connectionString = "server=sql.freedb.tech;database=freedb_MySQLbase;uid=freedb_Togyas;pwd=9KzW9C9?%7N#GrU;";
        public static DataTable GetDataTable (string sql)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            connection.Close();
            return datatable;
        }
        
    }
}
