using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto C1 = new Contacto("agu", "guti", "111", "calle falsa 123", DateTime.Now.AddYears(-25));

            Console.WriteLine(C1.ToString());

            Console.WriteLine(C1.Edad());

            Console.ReadKey();
        }
    }
}
