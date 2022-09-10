using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio
{
    public class Contacto
    {
        //Atributos de la clase Contacto
        private int _codigoContacto;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        //Constructor de la clase Contacto
        public Contacto(int codigoContacto, string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _codigoContacto = codigoContacto;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
        }

        //Propiedades de la clase Contacto
        public int Codigo
        {
            get
            {
                return _codigoContacto;
            }
        }
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
            //Declaración de variables
            int edad;

            //Calculo la edad
            edad = (DateTime.Now - _fechaNacimiento).Days / 365;

            return edad;
        }

        //Procedimiento que realiza una llamada y suma 1 al contador de llamadas
        public void Llamar()
        {
            _llamadas++;
        }
    }
}
