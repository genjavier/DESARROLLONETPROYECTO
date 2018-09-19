using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Marca
    {
        //id INTEGER NOT NULL,
       
        private string nombre;
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Marca(string nombre)
        {
            this.nombre = nombre;
        }

        public Marca(string nombre, bool estado)
        {
            this.nombre = nombre;
            this.estado = estado;
        }

        public Marca(string nombre, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.nombre = nombre;
            this.estado = estado;
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
