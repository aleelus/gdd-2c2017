using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PagoAgilFrba
{
    public static class Validaciones
    {
        static Regex regexSoloNumeros = new Regex(@"^[0-9]+$");
        static Regex regexSoloLetras = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ]+$");
        static Regex regexMail = new Regex(@"^[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}$");
        static Regex regexSolofrases = new Regex(@"^[a-zA-ZáéíóúÁÉÍÓÚ ]+$");
        static Regex regexLetrasGuiones = new Regex(@"^[-_a-zA-ZáéíóúÁÉÍÓÚ]+$");
        static Regex regexNumerosGuiones = new Regex(@"^[-0-9]+$");
        static Regex regexDpto = new Regex(@"^[a-zA-Z 0-9]+$");
        static Regex regexDireccion = new Regex(@"^[a-zA-Z .]*[0-9]*$"); //CORREGIR ESTO DESPUES (ADMITE EL PUNTO SOLO)
       
        public static bool validarSoloNumeros(string numero)
        {
            return regexSoloNumeros.IsMatch(numero);
        }

        public static bool validarSoloLetras(string nombre)
        {
            return regexSoloLetras.IsMatch(nombre);
        }

        public static bool validarMail(string mail)
        {
            return regexMail.IsMatch(mail);
        }

        public static bool ValidarFrase(string frase)
        {
            return regexSolofrases.IsMatch(frase);
        }

        public static bool ValidarLetrasGuiones(string cadena)
        {
            return regexLetrasGuiones.IsMatch(cadena);
        }
        public static bool ValidarDireccion(string cadena)
        {
            return regexDireccion.IsMatch(cadena);
        }
        public static bool ValidarDpto(string cadena)
        {
            return regexDpto.IsMatch(cadena);
        }
        public static bool ValidarCuit(string cadena)
        {
            return regexNumerosGuiones.IsMatch(cadena);
        }


    }
}
