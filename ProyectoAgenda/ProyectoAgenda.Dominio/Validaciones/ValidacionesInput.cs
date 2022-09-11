using ProyectoAgenda.Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoAgenda.Dominio.Validaciones
{
    public class ValidacionesInput
    {
        public static string FuncionValidacionOpcion(ref string opcion)
        {
            //Declaración de variables
            bool flag = false;

            do
            {
                opcion = Console.ReadLine();

                if (string.IsNullOrEmpty(opcion))
                {
                    Console.WriteLine("ERROR! La opción ingresada no puede ser vacío, intente nuevamente.");
                }
                else if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("ERROR! La opción " + opcion + " no es una opción válida, intente nuevamente.");
                }

            } while (flag == false);

            return opcion;
        }

        public static bool FuncionValidarCadena(ref string cadena)
        {
            //Declaración de variables
            bool flag = false;

            if (string.IsNullOrEmpty(cadena))
            {
                Console.WriteLine("ERROR! La opción ingresada no puede ser vacío, intente nuevamente.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public static bool FuncionValidarTelefono(ref string telefono)
        {
            //Declaración de variables
            bool flag = false;

            //Validación de que el teléfono ingresado no sea vacío
            if (string.IsNullOrEmpty(telefono))
            {
                Console.WriteLine("ERROR! La opción ingresada no puede ser vacío, intente nuevamente.");
            }
            //Validación de que el teléfono ingresado no posea más de 15 números
            else if (telefono.Length > 15)
            {
                Console.WriteLine("ERROR! El número " + telefono + " no puede poseer más de 15 dígitos, intente nuevamente.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public static bool FuncionValidarFecha(string fecha, ref DateTime fechaValidada)
        {
            bool flag = false;

            if (!DateTime.TryParse(fecha, out fechaValidada))
            {
                Console.WriteLine("El campo Fecha de nacimiento debe tener un formato válido del tipo dd/mm/aaaa, intente nuevamente.");
            }
            else if (fechaValidada > DateTime.Now)
            {
                Console.WriteLine("La fecha ingresada no puede ser superior al día de hoy, intente nuevamente.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public static bool FuncionValidarNumero(string numero, ref int numeroValidado)
        {
            bool flag = false;

            if (!int.TryParse(numero, out numeroValidado))
            {
                Console.WriteLine("El código ingresado debe ser de tipo numérico, intente nuevamente");
            }
            else if (numeroValidado <= 0)
            {
                Console.WriteLine("El código ingresado debe ser mayor a cero, intente nuevamente");
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
