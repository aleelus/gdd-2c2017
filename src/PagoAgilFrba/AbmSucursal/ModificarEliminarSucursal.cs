using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.BaseDeDatos.ConexionDB;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class ModificarEliminarSucursal : Form
    {

        private bool salir = true;
        private decimal idSucursal;

        public ModificarEliminarSucursal()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            bool correcto = true;

            if (!Validaciones.ValidarFrase(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Nombre no válido");
                correcto = false;
            }
            if (!Validaciones.ValidarDireccion(textBoxDireccion.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "Direccion no válida");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxCodigoPostal.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "Codigo Postal no válido");
                correcto = false;
            }

            return correcto;
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked)
            {
                checkBoxEstado.Text = "Activo";
            }
            else
            {
                checkBoxEstado.Text = "Inactivo";
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                SQLParametros parametros = new SQLParametros();

                parametros.add("@id_sucursal", idSucursal);
                parametros.add("@nombre", textBoxNombre.Text);                
                parametros.add("@direccion", textBoxDireccion.Text);
                parametros.add("@codPostal", textBoxCodigoPostal.Text);
                parametros.add("@estado", checkBoxEstado.Text);

                if (ConexionDB.Procedure("modificarSucursal", parametros.get()))
                {
                    MessageBox.Show("La sucursal" + textBoxNombre.Text + " se ha modificado");

                }
            }
        }

        public void recibirDatos(DataGridViewCellCollection cell)
        {
            idSucursal = Convert.ToDecimal(cell["idSucursal"].Value);
            textBoxNombre.Text = cell["Nombre"].Value.ToString();
            textBoxDireccion.Text = cell["Direccion"].Value.ToString();
            textBoxCodigoPostal.Text = cell["Cod Postal"].Value.ToString();
            checkBoxEstado.Text = cell["Estado"].Value.ToString();
            if (checkBoxEstado.Text.Contains("Activo"))
                checkBoxEstado.Checked = true;
            else
                checkBoxEstado.Checked = false;


        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }

       
    }
}
