using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas
{
    internal class Nodo
    {
        public object dato;
        public Nodo next;
        public Nodo prev;

        public Nodo(object dato, Nodo prev, Nodo next)
        {
            this.prev = prev;
            this.dato = dato;
            this.next = next;
        }

        public Nodo(object dato, Nodo prev)
        {
            this.dato = dato;
            this.prev = prev;
        }

        public Nodo(object dato)
        {
            this.dato = dato;
            this.next = null;
            this.prev = null;
        }

        public Nodo()
        {
            this.dato = "";
            this.next = null;
            this.prev = null;
        }

        public object Dato
        {
            get { return this.dato; }
            set { this.dato = value; }

        }

        public Nodo Next
        {
            get { return this.Next; }
            set { this.Next = value; }
        }
        public Nodo Anterior
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }
}


