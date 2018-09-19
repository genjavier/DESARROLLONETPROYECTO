using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Seguridad
    {
        string sql=" ";
         string conex = Conexion.ConexionBD.getInstance().sqlExecute(sql);


    }
}
