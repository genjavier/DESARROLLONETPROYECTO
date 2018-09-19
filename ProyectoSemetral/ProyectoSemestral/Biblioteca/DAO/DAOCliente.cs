using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ENT;

namespace Biblioteca.DAO
{
    public class DAOCliente
    {
        public static bool insert_boleta(Cliente objCliente)
        {
            string sql = string.Format("INSERT INTO cliente (perona_id, calificacion,descripcion,creado,bloqueado,fecha_bloqueo,estado,creado) values('{0}','{1}',{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')"
                ,objCliente.Persona_id.
                , true
                , objBoleta.Creado.Date);
            //insertar en la BD
            Conexion.ConexionBD.getInstance().sqlExecute(sql);

            return true;
        }

        //public static bool insert_comuna(Comuna comuna)
        //{
        //    string sql = string.Format("insert into comuna (nombre,id_provincia) values('{0}'.'{1}')"
        //        , region.Nombre
        //         ,comuna.Provincia.id_provincia);
        //    //insertar en la BD
        //    return true;
        //}

        public static bool update_boleta(Cliente objBoleta)
        {
            string sql = string.Format("update boleta set nombre = '{0}' " +
                ",cantidad='{3}'" +
                ",precio_subtotal='{4}'" +
                ",descuento='{5}'" +
                ",cuota='{8}'" +
                ",estado='{9}'" +
                ",modificado'{11}'" +
                "where nombre = {0} "
                , objBoleta.Producto_id.Codigo
                , objBoleta.Fecha_compra
                , objBoleta.Cantidad
                , objBoleta.Precio_subtotal
                , objBoleta.Descuento
                , objBoleta.Precio_descuento
                , objBoleta.Precio_total
                , objBoleta.Cuota
                , true
                , objBoleta.Creado.Date);
            return true;
        }

        public static bool delete_region(Cliente region)
        {
            string sql = string.Format("delete from region where id_region = {0} "
                , region.Id_region);
            return true;
        }

    }
}
