using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.BaseDeDatos.ConexionDB;
using System.IO;

namespace PagoAgilFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string ruta = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            System.IO.StreamReader file = new StreamReader(Path.Combine(ruta, "config.txt"));
            string sqlcon = file.ReadLine();            
            file.Close();

            Sesion.conexion = ConexionDB.ConectarDB(sqlcon);
            

            Application.Run(new Login.Login());

            ConexionDB.DesconectarDB(Sesion.conexion);
        
        }
    }
}
