using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ENT;
using Biblioteca.DAO;
using System.Data;

namespace Biblioteca.NEG
{
    public class NEGPersona
    {
        public static bool insert_persona(Persona objPersona)
        {
            string nombre = objPersona.Nombre;
            string apP = objPersona.Apellido_paterno;
            string apM = objPersona.Apellido_materno;
            string correo = objPersona.Correo;
            string telefono = objPersona.Telefono;

            Biblioteca.DAO.DAOPersona.insert_persona(objPersona);
            return true;
            //try
            //{
            //if (nombre == null)
            //{
            //    throw new System.ArgumentException("debe ingresar un nombre");
            //}
            //else 
            //{
            //    return true;
            //}

            //if (apP == null)
            //{
            //    throw new System.ArgumentException("debe ingresar un apellido paterno");
            //}
            //else
            //{
            //    return true;
            //}
            //if (apM == null)
            //{
            //    throw new System.ArgumentException("debe ingresar un apellido materno");
            //}
            //else
            //{
            //    return true;
            //}
            //if (correo == null)
            //{
            //    throw new System.ArgumentException("debe ingresar un correo");
            //}
            //else
            //{
            //    return true;
            //}
            //if (telefono == null)
            //{
            //    throw new System.ArgumentException("debe ingresar un telefono");
            //}
            //else
            //{
            //    return true;
            //}


            //}
            //catch (ArgumentException ex)
            //{

            //    throw ex;
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}


        }

        public static DataTable selectTodas(Persona id)
        {
            int ids = id.Id;
            return DAO.DAOPersona.busacar_persona(ids);
        }
    }
}
