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

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ModificarEliminarEmpresa : Form
    {

        private decimal idEmpresa;
        private bool salir = true;

        public ModificarEliminarEmpresa()
        {
            InitializeComponent();

            SQLParametros parametros = new SQLParametros();

            DataTable rubros;

            if (ConexionDB.Procedure("obtenerRubros", parametros.get(), out rubros))
            {
                comboBoxRubro.DisplayMember = "descripcionRubro";
                comboBoxRubro.ValueMember = "idRubro";
                comboBoxRubro.DataSource = rubros;
                comboBoxRubro.Update();

            }
        }

        private bool validar()
        {
            bool correcto = true;

            if (!Validaciones.ValidarFrase(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Nombre no válido");
                correcto = false;
            }
            if (!Validaciones.ValidarCuit(textBoxCuit.Text))
            {
                errorProvider1.SetError(textBoxCuit, "Cuit no válido");
                correcto = false;
            }
            if (!Validaciones.ValidarDireccion(textBoxDireccion.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "Direccion no válida");
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

                parametros.add("@id_empresa", idEmpresa);
                parametros.add("@nombre", textBoxNombre.Text);
                parametros.add("@cuit", textBoxCuit.Text);
                parametros.add("@direccion", textBoxDireccion.Text);
                parametros.add("@idRubro", Convert.ToDecimal(comboBoxRubro.SelectedValue));
                parametros.add("@fechaActual", Sesion.fechaActual);
                parametros.add("@estado", checkBoxEstado.Text);

                if (ConexionDB.Procedure("modificarEmpresa", parametros.get()))
                {
                    MessageBox.Show("La empresa " + textBoxNombre.Text + " se ha modificado");

                }
            }
                        
        }

        public void recibirDatos(DataGridViewCellCollection cell)
        {
            idEmpresa = Convert.ToDecimal(cell["idEmpresa"].Value);
            textBoxNombre.Text = cell["Nombre"].Value.ToString();
            textBoxCuit.Text = cell["Cuit"].Value.ToString();
            textBoxDireccion.Text = cell["Direccion"].Value.ToString();
            comboBoxRubro.SelectedValue = cell["Rubro"].Value; 
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
