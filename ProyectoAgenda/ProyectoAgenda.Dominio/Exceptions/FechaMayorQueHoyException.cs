using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class FechaMayorQueHoyException : Exception
    {
        public FechaMayorQueHoyException() : base("ERROR! La fecha ingresada no puede ser superior al día de hoy, intente nuevamente.") { }
    }
}
