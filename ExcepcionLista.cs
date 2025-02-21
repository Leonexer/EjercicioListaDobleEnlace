using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas
{
    internal class EmptyListException : ApplicationException
    {
        public EmptyListException()
            : base("La lista esta vacía.")
        {

        }
    }
}
