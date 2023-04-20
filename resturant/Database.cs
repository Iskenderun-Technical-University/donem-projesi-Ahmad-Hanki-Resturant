using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace resturant
{
    public class Database
    {
        public MySqlConnection conn;
        public string connectionString;
        
        public Database ()
        {
            connectionString = "server=sql.freedb.tech;database=freedb_MySQLbase;uid=freedb_Togyas;pwd=9KzW9C9?%7N#GrU;";
        }
        
        
        public void connOpen()
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        public void connClose()
        {
            conn.Close();
        }
        public void insertdata(int id, string ord, int z, string fu, int te)
        {
            string query= "INSERT INTO MyTable (ID, Orderr, Price, FullName, PhoneNumber)VALUES (@ID, @Orderr, @Price, @FullName, @PhoneNumber)";
            MySqlCommand command = new MySqlCommand(query, conn);
            
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Orderr", ord); 
            command.Parameters.AddWithValue("@Price", z);
            command.Parameters.AddWithValue("@FullName", fu);
            command.Parameters.AddWithValue("@PhoneNumber", te);
            command.ExecuteNonQuery();
            

        }
    }
}
