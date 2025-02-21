using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas
{
    internal class List
    {
        private bool Circular;
        private Nodo Head;
        private Nodo Tail;
        private int Counter; //Para el ciclo, acuerdate

        public List(bool Circular) //Al declarar la lista debes poner true en el parentesis para que sea circular
        {
            this.Circular = Circular;
        }
        public List() //Sino, procede sin ser circular
        {
            this.Circular = false;
        }


        public bool ListIsEmpty()
        {
            return Head == null && Tail == null;
        }

        public void CheckCircular()
        {
            if (Circular) 
            {
                Tail.next = Head;
                Head.prev = Tail;
            }
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
                Head = Head.prev = new Nodo(Dato, null, Head);
                Counter++;
            }
            CheckCircular();
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
                Tail = Tail.next = new Nodo(Dato, Tail, null);
                Counter++;
            }
            CheckCircular();
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
        public void ShowListBackwards()
        {
            Nodo Actual = Tail;
            for (int i = 0; i < Counter; i++)
            {
                Console.WriteLine(Actual.Dato);
                Actual = Actual.prev;
            }
        }

        public object DeleteHead()
        {
            if (!ListIsEmpty())
            {
                throw new EmptyListException();
            }

            object DeletedObj = Head.dato;

            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.next;
                Head.prev = null;
            }
            CheckCircular();
            Counter--;
            return DeletedObj;
        }

        public object DeleteTail()
        {
            if (!ListIsEmpty())
            {
                throw new EmptyListException();
            }
            object DeletedObj = Tail.dato;
            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Tail = Tail.prev;
                Tail.next = null;
            }
            CheckCircular();
            Counter--;
            return DeletedObj;
        }
    }
}
