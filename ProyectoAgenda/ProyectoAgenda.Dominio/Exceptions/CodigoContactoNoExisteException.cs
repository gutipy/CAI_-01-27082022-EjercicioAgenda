using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Dominio;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class CodigoContactoNoExisteException : Exception
    {
        public CodigoContactoNoExisteException(int codigoContacto) : base("El código de contacto " + codigoContacto + " es inválido") { }
    }
}
