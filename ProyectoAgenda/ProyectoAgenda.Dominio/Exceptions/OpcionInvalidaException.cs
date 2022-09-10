using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class OpcionInvalidaException : Exception
    {
        public OpcionInvalidaException(string opcion) : base("ERROR! La opción " + opcion + " no es una opción válida, intente nuevamente.") { }
    }
}
