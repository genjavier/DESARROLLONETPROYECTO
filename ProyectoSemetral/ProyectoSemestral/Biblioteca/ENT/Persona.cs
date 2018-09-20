using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Persona
    {
        //id INTEGER NOT NULL,
        private int id;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string correo;
        private string telefono;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;
        private DateTime estado;

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(string nombre, string apellido_paterno, string apellido_materno, string correo, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido_paterno = apellido_paterno;
            this.Apellido_materno = apellido_materno;
            this.Correo = correo;
            this.Telefono = telefono;
        }

        public Persona(int id, string nombre, string apellido_paterno, string apellido_materno, string correo, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.correo = correo;
            this.telefono = telefono;
        }

        public Persona(int id, string nombre, string apellido_paterno, string apellido_materno, string correo, string telefono, DateTime creado, DateTime modificado, DateTime eliminado, DateTime estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido_paterno = apellido_paterno;
            this.apellido_materno = apellido_materno;
            this.correo = correo;
            this.telefono = telefono;
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
            this.estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
        public DateTime Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }
    }
}
