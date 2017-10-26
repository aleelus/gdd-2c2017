using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.BaseDeDatos.Cifrado;
using PagoAgilFrba.BaseDeDatos.ConexionDB;

namespace PagoAgilFrba.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();
            parametros.add("@usu", textBoxUsuario.Text);
            parametros.add("@password", Cifrado.Cifrar(textBoxContrasena.Text));

            DataTable DTUsuario;

            if (ConexionDB.Procedure("loginProc", parametros.get(), out DTUsuario))
            {
                Sesion.user_id = Convert.ToDecimal(DTUsuario.Rows[0][0]);                
                Sesion.usuario = textBoxUsuario.Text;

                new SeleccionarSucursal().Show(this);
                this.Hide();
            }
        }
               
               
    }
}
