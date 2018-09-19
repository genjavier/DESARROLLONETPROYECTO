using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Cuota
    {
        //id INTEGER NOT NULL,
        //creado              datetime,
        //modificado
        private Boleta boleta_id;
        private int precio;
        private DateTime fecha_vencimiento;
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Cuota(Boleta boleta_id)
        {
            this.boleta_id = boleta_id;
        }

        public Cuota(DateTime fecha_vencimiento)
        {
            this.fecha_vencimiento = fecha_vencimiento;
        }

        public Cuota(Boleta boleta_id, int precio, DateTime fecha_vencimiento, bool estado)
        {
            this.boleta_id = boleta_id;
            this.precio = precio;
            this.fecha_vencimiento = fecha_vencimiento;
            this.estado = estado;
        }

        public Cuota(Boleta boleta_id, int precio, DateTime fecha_vencimiento, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.boleta_id = boleta_id;
            this.precio = precio;
            this.fecha_vencimiento = fecha_vencimiento;
            this.estado = estado;
            this.Creado = creado;
            this.Modificado = modificado;
            this.Eliminado = eliminado;
        }

        public Boleta Boleta_id { get => boleta_id; set => boleta_id = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
