using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.InterfazConsola
{
    public class Contacto
    {
        //Atributos de la clase Contacto
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        //Constructor de la clase Contacto
        public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
        }

        //Propiedades de la clase Contacto
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
        }

        public int Llamadas
        {
            get
            {
                return _llamadas;
            }
        }


        //Función que calcula la edad de un contacto
        public int Edad()
        {
            int edad;

            edad = (DateTime.Now - _fechaNacimiento).Days / 365;

            return edad;
        }
    }
}
