using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.ENT
{
    public class Cliente
    {
        // id
        //creado 
        //modificado    
        //eliminado 
        private byte calificacion;
        private string descripcion;
        private byte bloqueado;
        private DateTime fecha_bloqueo;
        private bool estado;
        private Persona persona_id;
        private DateTime creado;
        private DateTime modificado;
        private DateTime eliminado;

        public Cliente(byte bloqueado)
        {
            this.bloqueado = bloqueado;
        }

        public Cliente(Persona persona_id)
        {
            this.persona_id = persona_id;
        }

        public Cliente(byte calificacion, string descripcion, byte bloqueado, DateTime fecha_bloqueo, bool estado, Persona persona_id)
        {
            this.calificacion = calificacion;
            this.descripcion = descripcion;
            this.bloqueado = bloqueado;
            this.fecha_bloqueo = fecha_bloqueo;
            this.estado = estado;
            this.persona_id = persona_id;
        }

        public Cliente(byte calificacion, string descripcion, byte bloqueado, DateTime fecha_bloqueo, bool estado, Persona persona_id, DateTime creado, DateTime modificado, DateTime eliminado)
        {
            this.calificacion = calificacion;
            this.descripcion = descripcion;
            this.bloqueado = bloqueado;
            this.fecha_bloqueo = fecha_bloqueo;
            this.estado = estado;
            this.persona_id = persona_id;
            this.creado = creado;
            this.modificado = modificado;
            this.eliminado = eliminado;
        }

        public byte Calificacion { get => calificacion; set => calificacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte Bloqueado { get => bloqueado; set => bloqueado = value; }
        public DateTime Fecha_bloqueo { get => fecha_bloqueo; set => fecha_bloqueo = value; }
        public bool Estado { get => estado; set => estado = value; }
        public Persona Persona_id { get => persona_id; set => persona_id = value; }
        public DateTime Creado { get => creado; set => creado = value; }
        public DateTime Modificado { get => modificado; set => modificado = value; }
        public DateTime Eliminado { get => eliminado; set => eliminado = value; }
    }
}
