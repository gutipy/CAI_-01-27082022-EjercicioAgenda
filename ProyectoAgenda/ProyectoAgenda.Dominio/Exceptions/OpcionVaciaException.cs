using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Dominio;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class OpcionVaciaException : Exception
    {
        public OpcionVaciaException() : base("ERROR! La opción ingresada no puede ser vacío, intente nuevamente.") { }
    }
}
