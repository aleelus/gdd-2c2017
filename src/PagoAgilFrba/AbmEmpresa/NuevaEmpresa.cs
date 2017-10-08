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
    public partial class NuevaEmpresa : Form
    {
        public NuevaEmpresa()
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

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                SQLParametros parametros = new SQLParametros();
                DateTime fecha = new DateTime(2018, 10, 19);  // FECHA HARDCODEADA POR EL MOMENTO

                parametros.add("@nombre", textBoxNombre.Text);
                parametros.add("@cuit", textBoxCuit.Text);
                parametros.add("@direccion", textBoxDireccion.Text);
                parametros.add("@idRubro", Convert.ToDecimal(comboBoxRubro.SelectedValue));
                parametros.add("@fecha", fecha);
                parametros.add("@estado", checkBoxEstado.Text);

                if (ConexionDB.Procedure("nuevaEmpresa", parametros.get()))
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


    }
}
