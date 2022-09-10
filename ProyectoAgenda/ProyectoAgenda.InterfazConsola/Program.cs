using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Dominio;
using ProyectoAgenda.Dominio.Exceptions;
using ProyectoAgenda.Dominio.Validaciones;

namespace ProyectoAgenda.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string _opcionMenu = "";

            //Contacto C1 = new Contacto(1, "Agustín", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-25));

            //Contacto C2 = new Contacto(2, "Tomás", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-23));

            //Contacto C3 = new Contacto(3, "Mariano", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-65));

            //Contacto C4 = new Contacto(4, "Graciela", "Andreacchio", "1234-5678", "Calle 123", DateTime.Now.AddYears(-61));

            try
            {
                Agenda agendaElectronica = new Agenda("Mi agenda", "Electrónica");

                //agendaElectronica.AgregarContacto(C1);
                //agendaElectronica.AgregarContacto(C2);
                //agendaElectronica.AgregarContacto(C3);
                //agendaElectronica.AgregarContacto(C4);

                bool consolaActiva = true;

                while (consolaActiva)
                {
                    //Despliego en pantalla las opciones para que el usuario decida
                    OpcionesMenu();

                    //Se valida que la opcion ingresada no sea vacío y/o distinta de las opciones permitidas
                    ValidacionesInput.FuncionValidacionOpcion(ref _opcionMenu);

                    //Estructura condicional para controlar el flujo del programa
                    switch (_opcionMenu)
                    {
                        case "1":
                            //Listar contactos de la agenda
                            Listar(agendaElectronica);
                            break;
                        case "2":
                            //Agrego un contacto a la agenda
                            Agregar(agendaElectronica);
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error general");
            }
            Console.ReadKey();
        }

        public static void OpcionesMenu()
        {
            Console.WriteLine(
                "Bienvenido a la agenda! Seleccione una opción:" + Environment.NewLine +
                "1 - Listar contactos de la agenda" + Environment.NewLine +
                "2 - Agregar contacto" + Environment.NewLine +
                "3 - Eliminar contacto" + Environment.NewLine +
                "4 - Salir"
                )
                ;
        }

        

        //Método para listar todos los contactos que posee la agenda y mostrarlos en pantalla
        public static void Listar(Agenda agenda)
        {
            foreach(Contacto c in agenda.Contactos)
            {
                Console.WriteLine (c.Codigo + " " + c.Nombre + " " + c.Apellido + " " + c.Telefono + " " + c.Direccion + " " + c.FechaNacimiento);
            }
        }

        //Método para agregar un nuevo contacto a la agenda
        public static void Agregar(Agenda agendaElectronica)
        {
            //Declaración de variables
            int _codigoContacto;
            string _nombre;
            string _apellido;
            string _telefono;
            string _direccion;
            string _fechaNacimiento;
            DateTime _fechaNacimientoValidada = DateTime.Now;
            bool flag;


            _codigoContacto = agendaElectronica.Contactos.Count + 1;

            do
            {
                Console.WriteLine("Ingrese el nombre del contacto");
                _nombre = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarCadena(ref _nombre);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el apellido del contacto");
                _apellido = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarCadena(ref _apellido);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese el teléfono del contacto");
                _telefono = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarTelefono(ref _telefono);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la dirección del contacto");
                _direccion = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarCadena(ref _direccion);
            } while (flag == false);

            do
            {
                Console.WriteLine("Ingrese la fecha de nacimiento del contacto");
                _fechaNacimiento = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarFecha(_fechaNacimiento, ref _fechaNacimientoValidada);
            } while (flag == false);

            //Instancio la clase contacto y lo agrego a la agenda
            Contacto c = new Contacto(
                _codigoContacto,
                _nombre,
                _apellido,
                _telefono,
                _direccion,
                _fechaNacimientoValidada
                );

            agendaElectronica.AgregarContacto(c);
        }
    }
}
