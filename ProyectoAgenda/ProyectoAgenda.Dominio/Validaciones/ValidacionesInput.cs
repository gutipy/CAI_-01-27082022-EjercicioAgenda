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

            } while (flag == false);

            return opcion;
        }

        public static bool FuncionValidarCadena(ref string cadena)
        {
            //Declaración de variables
            bool flag = false;

            if (string.IsNullOrEmpty(cadena))
            {
                throw new OpcionVaciaException();
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
                throw new OpcionVaciaException();
            }
            //Validación de que el teléfono ingresado no posea más de 15 números
            else if (telefono.Length > 15)
            {
                throw new TelefonoInvalidoException(telefono);
            }
            //Validación de que el teléfono ingresado no posea más de 15 números
            else if (!Regex.IsMatch(telefono, "^[a-zA-Z]*$"))
            {
                throw new TelefonoInvalidoException(telefono);
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
                throw new FormatoFechaInvalidoException();
            }
            else if (fechaValidada > DateTime.Now)
            {
                throw new FechaMayorQueHoyException();
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
