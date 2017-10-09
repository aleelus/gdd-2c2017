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
    public partial class NuevaSucursal : Form
    {
        private bool salir = true;

        public NuevaSucursal()
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

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                SQLParametros parametros = new SQLParametros();
                

                parametros.add("@nombre", textBoxNombre.Text);
                parametros.add("@direccion", textBoxDireccion.Text);
                parametros.add("@codPostal", textBoxCodigoPostal.Text);
                parametros.add("@estado", checkBoxEstado.Text);

                if (ConexionDB.Procedure("nuevaSucursal", parametros.get()))
                {
                    MessageBox.Show("La empresa " + textBoxNombre.Text + " se ha creado");

                }
            }
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }

    }
}
