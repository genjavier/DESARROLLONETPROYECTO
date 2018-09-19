using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Producto
    {

        //id INTEGER NOT NULL,
        //creado datetime,
        //modificado         datetime,
        //eliminado datetime,
        private int codigo;
        private string descripcion;
        private Tipo_producto tipo_producto_id;
        private Marca marca_id;
        private Talla talla_id;
        private Color color_id;
        private int stock;
        private int precio;
        private bool estado;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Producto(int codigo)
        {
            this.codigo = codigo;
        }

        public Producto(int codigo, string descripcion, Tipo_producto tipo_producto_id, Marca marca_id, Talla talla_id, Color color_id, int stock, int precio, bool estado)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.tipo_producto_id = tipo_producto_id;
            this.marca_id = marca_id;
            this.talla_id = talla_id;
            this.color_id = color_id;
            this.stock = stock;
            this.precio = precio;
            this.estado = estado;
        }

        public Producto(int codigo, string descripcion, Tipo_producto tipo_producto_id, Marca marca_id, Talla talla_id, Color color_id, int stock, int precio, bool estado, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.tipo_producto_id = tipo_producto_id;
            this.marca_id = marca_id;
            this.talla_id = talla_id;
            this.color_id = color_id;
            this.stock = stock;
            this.precio = precio;
            this.estado = estado;
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Tipo_producto Tipo_producto_id { get => tipo_producto_id; set => tipo_producto_id = value; }
        public Marca Marca_id { get => marca_id; set => marca_id = value; }
        public Talla Talla_id { get => talla_id; set => talla_id = value; }
        public Color Color_id { get => color_id; set => color_id = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
