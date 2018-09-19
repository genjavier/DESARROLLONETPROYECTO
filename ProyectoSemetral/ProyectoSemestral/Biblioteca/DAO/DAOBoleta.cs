using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ENT;


namespace Biblioteca.DAO
{
    public class DAOBoleta
    {
        public static bool insert_boleta(Boleta objBoleta)
        {
            string sql = string.Format("INSERT INTO boleta (boleta_id, fecha_compra,producto_id,cantidad,precio_subtotal,descuento,precio_descuento,precio_total,cuota,estado,creado) values('{0}','{1}',{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')"
                , objBoleta.Fecha_compra
                , objBoleta.Producto_id.Codigo
                , objBoleta.Cantidad
                , objBoleta.Precio_subtotal
                , objBoleta.Descuento
                , objBoleta.Precio_descuento
                , objBoleta.Precio_total
                , objBoleta.Cuota
                ,true
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


        public static bool update_boleta(Boleta objBoleta)
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

        public static bool delete_region(Region region)
        {
            string sql = string.Format("delete from region where id_region = {0} "
                , region.Id_region);
            return true;
        }
    }

}

