using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Conexion
{
    public class ConexionBD
    {
        private static ConexionBD bd;
        private SqlConnection cnn;

        private ConexionBD()

        {
            cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source = localhost; Initial Catalog = master; Integrated Security = True";
            cnn.Open();
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
            SqlCommand cmd = new SqlCommand(sql, cnn);
            return cmd.ExecuteNonQuery();
        }
        public DataTable mySQLSelect(string mysql)
        {
            SqlCommand cmd = new SqlCommand(mysql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
}
