using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Dominio;

namespace ProyectoAgenda.Dominio.Exceptions
{
    public class AgendaLlenaException : Exception
    {
        public AgendaLlenaException(int CantidadMaximaContactos) : base("ERROR! La agenda ha alcanzo la cantidad máxima de " + CantidadMaximaContactos + " contactos") { }
    }
}
