using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PagoAgilFrba.BaseDeDatos.ConexionDB;

namespace PagoAgilFrba.AbmRol
{
    public partial class NuevoRol : Form
    {

        private bool salir = true;

        public NuevoRol()
        {
            InitializeComponent();
            //buttonAceptar.Enabled = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();
            parametros.add("@nombre", textBoxNuevoRol.Text);

            if (ConexionDB.Procedure("agregarNuevoRol", parametros.get()))
            {
                salir = false;
                Owner.Show();
                this.Close();
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }

        private void NuevoRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir)
            {
                Application.Exit();
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }
    }
}
