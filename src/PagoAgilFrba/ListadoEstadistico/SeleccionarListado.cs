using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class SeleccionarListado : Form
    {

        private bool salir = true;

        int anioIngresado;
        int listadoIndex;
        int trimestreIndex;

        public SeleccionarListado()
        {
            InitializeComponent();

            comboBoxTipoListado.Items.Add("Porcentaje de facturas cobradas por empresa");
            comboBoxTipoListado.Items.Add("Empresas con mayor monto rendido");
            comboBoxTipoListado.Items.Add("Clientes con mas pagos");
            comboBoxTipoListado.Items.Add("Clientes con mayor porcentaje de facturas pagadas");           

            comboBoxTrimestre.Items.Add("Enero-Febrero-Marzo");
            comboBoxTrimestre.Items.Add("Abril-Mayo-Junio");
            comboBoxTrimestre.Items.Add("Julio-Agosto-Septiembre");
            comboBoxTrimestre.Items.Add("Octubre-Noviembre-Diciembre");

            comboBoxTipoListado.SelectedIndex = 0;
            comboBoxTrimestre.SelectedIndex = 0;

            buttonGenerarListado.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Validaciones.validarSoloNumeros(textBoxAnio.Text) && textBoxAnio.Text.Length == 4)
            {
                errorProvider1.Clear();
                anioIngresado = Convert.ToInt32(textBoxAnio.Text);
                buttonGenerarListado.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(textBoxAnio, "El año ingresado no es correcto");
                buttonGenerarListado.Enabled = false;
            }
        }

        private void buttonGenerarListado_Click(object sender, EventArgs e)
        {
            new GenerarListado(anioIngresado, listadoIndex, trimestreIndex).Show(this);
            this.Hide();            
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }

        private void comboBoxTrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            trimestreIndex = comboBoxTrimestre.SelectedIndex;
        }

        private void comboBoxTipoListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            listadoIndex = comboBoxTipoListado.SelectedIndex;
        }
    }
}
