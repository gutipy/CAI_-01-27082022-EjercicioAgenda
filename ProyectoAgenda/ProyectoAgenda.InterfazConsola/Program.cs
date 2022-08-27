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
            Contacto C1 = new Contacto("Agustín", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-25));

            Console.ReadKey();
        }
    }
}
