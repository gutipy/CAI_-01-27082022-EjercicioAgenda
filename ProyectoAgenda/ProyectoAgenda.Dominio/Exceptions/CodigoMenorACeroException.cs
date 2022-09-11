using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class CodigoMenorACeroException : Exception
    {
        public CodigoMenorACeroException(int numero) : base("ERROR! El código de contacto " + numero + " debe ser mayor a cero, intente nuevamente.") { }
    }
}
