using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ENT;
using Biblioteca.Conexion;
using System.Data;

namespace Biblioteca.DAO
{
    public class DAOPersona
    {
        public static bool insert_persona(Persona objPersona)
        {
            string sql = string.Format("INSERT INTO persona (nombre,apellido_paterno,apellido_materno, correo,telefono, creado, modificado ,eliminado,estado) values('{0}','{1}','{2}','{3}','{4}', null, null,null,1)"
                
                , objPersona.Nombre
                , objPersona.Apellido_paterno
                , objPersona.Apellido_materno
                , objPersona.Correo
                , objPersona.Telefono
               
                //, objPersona.Creado.Date
                         ////" values('{0}','{1}',{2}','{3}','{4}','{5}','{6}',ture)"
                         ////, objPersona.Nombre
                         ////, objPersona.Apellido_paterno
                         ////, objPersona.Apellido_materno
                         ////, objPersona.Correo
                         ////, objPersona.Telefono
                         ////, objPersona.Creado.Date

                         );
            Conexion.ConexionBD.getInstance().sqlExecute(sql);

            return true;
        }

     

        public static bool update_persona(Persona objPersona)
        {
            string sql = string.Format("update persona set nombre = '{0}' " +
                ",apellido_paterno='{1}'" +
                ",apellido_materno='{2}'" +
                ",correo='{3}'" +
                ",telefono='{4}'" +               
                ",modificado'{5}'" +
                ",estado'{6}'" +
                "where correo = {3} "
                ,objPersona.Nombre
                ,objPersona.Apellido_paterno
                ,objPersona.Apellido_materno
                ,objPersona.Correo
                ,objPersona.Telefono
                ,objPersona.Modificado.Date
                ,objPersona.Estado

                );
            Conexion.ConexionBD.getInstance().sqlExecute(sql);
            return true;
        }

        public static bool delete_persona(Persona objPersona)
        {
            string sql = string.Format("delete from persona where correo = {0} "
                , objPersona.Correo);
            Conexion.ConexionBD.getInstance().sqlExecute(sql);
            return true;
        }

        public static bool desactivar_persona(Persona objPersona)
        {
            string sql = string.Format("update persona set estado = false " +
                "where correo = {0} "              
                , objPersona.Correo                

                );
            Conexion.ConexionBD.getInstance().sqlExecute(sql);
            return true;
        }

        public static DataTable readAll_persona()
        {
            string sql = string.Format("select * from persona");
            DataTable dt = Conexion.ConexionBD.getInstance().mySQLSelect(sql);
            return dt;
        }

        public static DataTable busacar_persona(int id)
        {
            DataTable dtDatos = new DataTable();          
            
            string sql = string.Format("select nombre, apellido_paterno,apellido_materno,correo,telefono  from persona where id ="+id );

            DataTable dt = Conexion.ConexionBD.getInstance().mySQLSelect(sql);
            return dt;

        }


    }
}
