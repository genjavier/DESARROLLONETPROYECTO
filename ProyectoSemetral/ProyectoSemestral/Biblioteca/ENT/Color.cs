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
        private string colors;       
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Color(string colors, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.Colors = colors;
            this.Estado = estado;
            this.Creado = creado;
            this.Modificado = modificado;
            this.Eliminado = eliminado;
        }

        public string Colors { get => colors; set => colors = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
