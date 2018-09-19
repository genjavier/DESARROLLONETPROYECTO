using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Talla
    {
        //id INTEGER NOT NULL,

        //creado       datetime,
        //modificado datetime,
        //eliminado    datetime,
        private string sigla;
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Talla(string sigla, bool estado)
        {
            this.Sigla = sigla;
            this.Estado = estado;
        }

        public Talla(string sigla, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.sigla = sigla;
            this.estado = estado;
            this.Creado = creado;
            this.Modificado = modificado;
            this.Eliminado = eliminado;
        }

        public string Sigla { get => sigla; set => sigla = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
