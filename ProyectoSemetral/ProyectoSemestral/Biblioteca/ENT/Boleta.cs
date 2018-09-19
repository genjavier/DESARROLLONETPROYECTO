using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Boleta
    {
        //id INTEGER NOT NULL,
        //creado
        //modificado datetime
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;
        private Cliente cliente_id;
        private DateTime fecha_compra;
        private Producto producto_id;
        private byte cantidad;
        private int precio_subtotal;
        private double descuento;
        private int precio_descuento;
        private int precio_total;
        private byte cuota;
        private bool estado;

        public Boleta(DateTime fecha_compra)
        {
            this.fecha_compra = fecha_compra;
        }

        public Boleta(Cliente cliente_id)
        {
            this.cliente_id = cliente_id;
        }

        public Boleta(Cliente cliente_id, DateTime fecha_compra, Producto producto_id, byte cantidad, int precio_subtotal, double descuento, int precio_descuento, int precio_total, byte cuota, bool estado)
        {
            this.cliente_id = cliente_id;
            this.fecha_compra = fecha_compra;
            this.producto_id = producto_id;
            this.cantidad = cantidad;
            this.precio_subtotal = precio_subtotal;
            this.descuento = descuento;
            this.precio_descuento = precio_descuento;
            this.precio_total = precio_total;
            this.cuota = cuota;
            this.estado = estado;
        }

        public Boleta(DateTime creado, DateTime modificado, DateTime eliminado, Cliente cliente_id, DateTime fecha_compra, Producto producto_id, byte cantidad, int precio_subtotal, double descuento, int precio_descuento, int precio_total, byte cuota, bool estado)
        {
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
            this.cliente_id = cliente_id;
            this.fecha_compra = fecha_compra;
            this.producto_id = producto_id;
            this.cantidad = cantidad;
            this.precio_subtotal = precio_subtotal;
            this.descuento = descuento;
            this.precio_descuento = precio_descuento;
            this.precio_total = precio_total;
            this.cuota = cuota;
            this.estado = estado;
        }

        public Cliente Cliente_id { get => cliente_id; set => cliente_id = value; }
        public DateTime Fecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public Producto Producto_id { get => producto_id; set => producto_id = value; }
        public byte Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio_subtotal { get => precio_subtotal; set => precio_subtotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public int Precio_descuento { get => precio_descuento; set => precio_descuento = value; }
        public int Precio_total { get => precio_total; set => precio_total = value; }
        public byte Cuota { get => cuota; set => cuota = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
