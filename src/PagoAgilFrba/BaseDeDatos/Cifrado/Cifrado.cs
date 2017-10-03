using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PagoAgilFrba.BaseDeDatos.Cifrado
{
    class Cifrado
    {
        public static string Cifrar(string valorACifrar)
        {
            SHA256Managed contraseña = new SHA256Managed();

            //Guarda en un Array el texto sin cifrar
            byte[] sinCifrar = System.Text.Encoding.ASCII.GetBytes(valorACifrar);

            //Guarda en un Array el texto cifrado
            byte[] cifrado = contraseña.ComputeHash(sinCifrar);

            //Convierte a String lo cifrado
            string password = Convert.ToBase64String(cifrado);

            //Retorna el password cifrado
            return password;
        }

    }
}
