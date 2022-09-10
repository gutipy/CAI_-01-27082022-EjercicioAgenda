using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgenda.Dominio;
using ProyectoAgenda.Dominio.Exceptions;

namespace ProyectoAgenda.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string _opcionMenu = "";

            Contacto C1 = new Contacto(1, "Agustín", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-25));

            Contacto C2 = new Contacto(2, "Tomás", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-23));

            Contacto C3 = new Contacto(3, "Mariano", "Gutiérrez", "1234-5678", "Calle 123", DateTime.Now.AddYears(-65));

            Contacto C4 = new Contacto(4, "Graciela", "Andreacchio", "1234-5678", "Calle 123", DateTime.Now.AddYears(-61));

            try
            {
                Agenda agendaElectronica = new Agenda("Mi agenda", "Electrónica");

                agendaElectronica.AgregarContacto(C1);
                agendaElectronica.AgregarContacto(C2);
                agendaElectronica.AgregarContacto(C3);
                agendaElectronica.AgregarContacto(C4);

                bool consolaActiva = true;

                while (consolaActiva)
                {
                    //Despliego en pantalla las opciones para que el usuario decida
                    OpcionesMenu();

                    //Se valida que la opcion ingresada no sea vacío y/o distinta de las opciones permitidas
                    FuncionValidacionOpcion(ref _opcionMenu);

                    //Estructura condicional para controlar el flujo del programa
                    switch (_opcionMenu)
                    {
                        case "1":
                            //Listar contactos de la agenda
                            Listar(agendaElectronica);
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

        public static string FuncionValidacionOpcion(ref string opcion)
        {
            //Declaración de variables
            bool flag = false;

            do
            {
                opcion = Console.ReadLine();

                if (string.IsNullOrEmpty(opcion))
                {
                    throw new OpcionVaciaException();
                }
                else if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                {
                    flag = true;
                }
                else
                {
                    throw new OpcionInvalidaException(opcion);
                }

            }while(flag == false);

            return opcion;
            
        }

        public static void Listar(Agenda agenda)
        {
            foreach(Contacto c in agenda.Contactos)
            {
                Console.WriteLine (c.Codigo + " " + c.Nombre + " " + c.Apellido + " " + c.Telefono + " " + c.Direccion + " " + c.FechaNacimiento);
            }
        }
    }
}
