using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Devoluciones
{
    public partial class Devoluciones : Form
    {

        public bool salir = true;

        public Devoluciones()
        {
            InitializeComponent();

            if (Sesion.rol_nombre == "Administrador") {
                buttonDevolverFacturas.Enabled = true;
                buttonDevolverRendiciones.Enabled = true;
            }
            else if (Sesion.rol_nombre == "Cobrador")
            {
                buttonDevolverFacturas.Enabled = true;
                buttonDevolverRendiciones.Enabled = false;
            }
            else {
                buttonDevolverRendiciones.Enabled = false;
            }


        }

        private void buttonDevolverFacturas_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new DevolverFactura();
            nuevoForm.Show(this);
            this.Hide();
        }

        private void buttonDevolverRendiciones_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new DevolverRendicion();
            nuevoForm.Show(this);
            this.Hide();

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }
                
    }
}
