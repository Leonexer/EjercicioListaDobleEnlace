using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas
{
    internal class List
    {
        private Nodo Head;
        private Nodo Tail;
        private int Counter; //Para el ciclo, acuerdate

        public bool ListIsEmpty()
        {
            return Head == null || Tail == null;
        }
        public void Prepend(Object Dato)
        {
            if (ListIsEmpty())
            {
                Head = Tail = new Nodo(Dato);
                Counter++;
            }
            else
            {
                Head = Head.prev = new Nodo(Dato, Tail, Head);
                Counter++;
            }
        }
        public void Append(Object Dato)
        {
            if (ListIsEmpty())
            {
                Tail = Head = new Nodo(Dato);
                Counter++;
            }
            else
            {
                Tail = Tail.next = new Nodo(Dato, Tail, Head);
                Counter++;
            }
        }

        public void ShowList()
        {
            Nodo Actual = Head;
            for (int i = 0; i < Counter; i++)
            {
                Console.WriteLine(Actual.Dato);
                Actual = Actual.next;
            }

        }
    }
}
