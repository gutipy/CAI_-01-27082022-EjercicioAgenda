using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgenda.InterfazConsola
{
    public class Agenda
    {
        //Atributos de la clase Agenda
        private string _nombre;
        private string _tipo;
        List<Contacto> _contactos = new List<Contacto>();
        private int _cantidadMaximaContactos;

        //Constructor de la clase Agenda
        public Agenda(string nombre, string tipo, Contacto contactos)
        {
            _nombre = nombre;
            _tipo = tipo;
            _contactos = new List<Contacto>();
            //Defino la cantidad máxima de contactos de la agenda arbitrariamente
            _cantidadMaximaContactos = 100;
        }

        //Propiedades de la clase Agenda
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public int CantidadMaximaContactos
        {
            get
            {
                return _cantidadMaximaContactos;
            }
        }

        //Procedimiento que permite agregar un contacto a la agenda
        public void AgregarContacto(Contacto c)
        {
            if( _contactos.Count < _cantidadMaximaContactos)
            {
                //Declaración de variables
                string nombre;
                string apellido;
                string telefono;
                string direccion;
                DateTime fechaNacimiento;

                Console.WriteLine("Ingrese los siguientes datos para agregar un contacto");

                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();

                Console.WriteLine("Apellido:");
                apellido = Console.ReadLine();

                Console.WriteLine("Teléfono:");
                telefono = Console.ReadLine();

                Console.WriteLine("Dirección:");
                direccion = Console.ReadLine();

                Console.WriteLine("Fecha de nacimiento:");
                fechaNacimiento = Convert.ToDateTime(Console.ReadLine());

                //Creo el contacto con los valores que ingresó el usuario
                Contacto C1 = new Contacto(
                    nombre,
                    apellido,
                    telefono,
                    direccion,
                    fechaNacimiento
                    );

                //Agrego los datos que ingresó el usuario a la lista dinámica que almacena los contactos
                _contactos.Add(c);
            }
            else
            {
                Console.WriteLine("ERROR! La agenda ha alcanzo la cantidad máxima de " + _cantidadMaximaContactos + " contactos");
            }

        }

        //Procedimiento que permite eliminar un contacto de la agenda
        public void EliminarContacto(int codigoContacto)
        {
            //Pido al usuario que ingrese el código de contacto a eliminar
            Console.WriteLine("Ingrese el código del contacto que desea eliminar:");
            codigoContacto = Convert.ToInt32(Console.ReadLine());

            //Si el código ingresado no es válido le tira un cartel de error
            if (_contactos.Find(C => C._codigoContacto == codigoContacto) == null)
            {
                Console.WriteLine("El código de contacto " + codigoContacto + " es inválido");
            }

            //Le indico que remueva a todos los contactos que tengan el mismo codigo ingresado por el usuario
            else
            {
                _contactos.RemoveAll(C => C._codigoContacto == codigoContacto);
            }
        }
    }
}
