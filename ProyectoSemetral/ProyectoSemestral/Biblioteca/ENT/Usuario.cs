using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Usuario
    {

        //id INTEGER NOT NULL,
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;
        private Persona persona_id;
        private string nombre_Usuario;
        private string clave;
        private bool estado;

        public Usuario(string nombre_Usuario)
        {
            this.nombre_Usuario = nombre_Usuario;
        }

        public Usuario(DateTime creado, DateTime modificado, DateTime eliminado, Persona persona_id, string nombre_Usuario, string clave, bool estado)
        {
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
            this.persona_id = persona_id;
            this.nombre_Usuario = nombre_Usuario;
            this.clave = clave;
            this.estado = estado;
        }

        public Persona Persona_id { get => persona_id; set => persona_id = value; }
        public string Nombre_Usuario { get => nombre_Usuario; set => nombre_Usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
