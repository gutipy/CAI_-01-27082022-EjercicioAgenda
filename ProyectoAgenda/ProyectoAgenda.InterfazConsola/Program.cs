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


            Agenda agendaElectronica = new Agenda("Mi agenda", "Electrónica");

            //agendaElectronica.AgregarContacto(C1);
            //agendaElectronica.AgregarContacto(C2);
            //agendaElectronica.AgregarContacto(C3);
            //agendaElectronica.AgregarContacto(C4);

            bool consolaActiva = true;


            try
            {
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
                        case "3":
                            //Elimino un contacto de la agenda
                            Eliminar(agendaElectronica);
                            break;
                        case "4":
                            //Salir del programa
                            Salir();
                            break;
                    }
                }
            
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            if (agenda.Contactos.Count == 0)
            {
                Console.WriteLine("La agenda se encuentra vacía, presione Enter para elegir otra opción");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                foreach (Contacto c in agenda.Contactos)
                {
                    Console.WriteLine(c.Codigo + " " + c.Nombre + " " + c.Apellido + " " + c.Telefono + " " + c.Direccion + " " + c.FechaNacimiento);
                }

                Console.WriteLine("Presione Enter para elegir otra opción");
                Console.ReadKey();
                Console.Clear();
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

            //Asignación del código de contacto de manera incremental
            _codigoContacto = agendaElectronica.Contactos.Count + 1;

            //Pido al usuario que ingrese los datos de contacto y a la vez valido cada input ingresado
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

            Console.WriteLine("El contacto fue agregado exitosamente a la agenda, presione Enter para elegir otra opción.");
            Console.ReadKey();
            Console.Clear();
        }

        //Método para eliminar un contacto de la agenda
        public static void Eliminar(Agenda agenda)
        {
            //Declaración de variables
            string _codigo;
            int _codigoValidado = 0;
            bool flag;

            //Pido al usuario que ingrese el código de contacto y a la vez valido el input ingresado
            do
            {
                Console.WriteLine("Ingrese el código del contacto que desea eliminar");
                _codigo = Console.ReadLine();
                flag = ValidacionesInput.FuncionValidarNumero(_codigo, ref _codigoValidado);
            } while (flag == false);

            //Le paso el código de contacto validado a la clase Agenda para que busque en la lista de contactos y si existe dicho contacto que lo elimine
            agenda.EliminarContacto(_codigoValidado);
        }

        public static void Salir()
        {
            Console.WriteLine("Usted ha salido de la agenda, presione Enter");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
