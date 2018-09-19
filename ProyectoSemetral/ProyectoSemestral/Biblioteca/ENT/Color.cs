using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Color
    {
        //id INTEGER NOT NULL,
        private string color;       
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Color(string color, bool estado)
        {
            this.Color = color;
            this.Estado = estado;
        }

        public Color(string color, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.color = color;
            this.estado = estado;
            this.Creado = creado;
            this.Modificado = modificado;
            this.Eliminado = eliminado;
        }

        public string Color { get => color; set => color = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
