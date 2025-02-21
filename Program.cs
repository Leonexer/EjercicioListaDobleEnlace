using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List lista = new List(true);

            object Texto1 = Console.ReadLine();
            string Texto2 = Console.ReadLine();
            string Texto3 = Console.ReadLine();
            Console.WriteLine("");

            lista.Prepend(Texto1);
            lista.Append(Texto2);
            lista.Prepend(Texto3);
            lista.ShowList();
            Console.WriteLine("");
            lista.ShowListBackwards();

        }
    }
}
