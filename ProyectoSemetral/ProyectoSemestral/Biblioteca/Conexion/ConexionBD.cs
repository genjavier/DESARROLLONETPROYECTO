using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Biblioteca.Conexion
{
    public class ConexionBD
    {
        private static ConexionBD bd;
        //private SqlConnection cnn;

        private MySqlConnection cnn;




        private string server;
        private string database;
        private string uid;
        private string password;

        private ConexionBD()

        {
            server = "localhost";
            database = "gggg";
            uid = "root";
            password = "";            
            string connectionString = string.Format("Server=localhost; database=gggg; UID=root; password=''; SslMode = none");
           

            cnn = new MySqlConnection(connectionString);
        }

        public static ConexionBD getInstance()
        {
            if (bd == null)
            {
                bd = new ConexionBD();
            }
            return bd;
        }

        public int sqlExecute(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            int var = cmd.ExecuteNonQuery();
            cnn.Close();
            return var;
        }
        public DataTable mySQLSelect(string mysql)
        {
            MySqlCommand cmd = new MySqlCommand(mysql, cnn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}

