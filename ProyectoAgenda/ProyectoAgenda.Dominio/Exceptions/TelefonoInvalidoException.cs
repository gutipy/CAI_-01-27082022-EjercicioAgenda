using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class TelefonoInvalidoException : Exception
    {
        public TelefonoInvalidoException(string telefono) : base("ERROR! El número " + telefono + " es inválido, intente nuevamente.") { }
    }
}
