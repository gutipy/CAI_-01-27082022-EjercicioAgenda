using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class FormatoFechaInvalidoException : Exception
    {
        public FormatoFechaInvalidoException() : base("ERROR! Formato de fecha inválido. Ingrese una fecha con formato dd/mm/yyyy.") { }
    }
}
