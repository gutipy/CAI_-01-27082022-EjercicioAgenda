using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class FormatoInvalidoException : Exception
    {
        public FormatoInvalidoException(string campo) : base("ERROR! El campo " + campo + " debe tener formato un formato válido, intente nuevamente.") { }
    }
}
