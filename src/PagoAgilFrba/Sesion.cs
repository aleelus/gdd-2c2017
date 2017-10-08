using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PagoAgilFrba
{
    public static class Sesion
    {
        public static SqlConnection conexion;
        public static DateTime fechaActual;

        public static decimal rol_id;
        public static string rol_nombre;
        public static decimal user_id;
        public static string usuario;
        
    }
}
