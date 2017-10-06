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

namespace PagoAgilFrba.AbmCliente
{
    public partial class ModificarEliminarCliente : Form
    {

        private decimal idCliente;
        private bool salir = true;

        public ModificarEliminarCliente()
        {
            InitializeComponent();          
            
        }

        public void recibirDatos(DataGridViewCellCollection cell)
        {
            idCliente = Convert.ToDecimal(cell["idCliente"].Value);
            textBoxNombre.Text = cell["Nombre"].Value.ToString();
            textBoxApellido.Text = cell["Apellido"].Value.ToString();
            textBoxDni.Text = cell["Documento"].Value.ToString();
            textBoxEmail.Text = cell["E-mail"].Value.ToString();
            textBoxTelefono.Text = cell["Telefono"].Value.ToString();
            textBoxDireccion.Text = cell["Direccion"].Value.ToString();
            textBoxPiso.Text = cell["Piso"].Value.ToString();
            textBoxDpto.Text = cell["Dpto"].Value.ToString();
            textBoxLocalidad.Text = cell["Localidad"].Value.ToString();
            textBoxCodPostal.Text = cell["Cod Postal"].Value.ToString();
            dateTimePickerFecha.Value = (DateTime)cell["Fecha de Nacimiento"].Value;
            checkBoxEstado.Text = cell["Estado"].Value.ToString();
            if (checkBoxEstado.Text.Contains("Activo"))
                checkBoxEstado.Checked = true;
            else
                checkBoxEstado.Checked = false;

            
        }

        private bool validar()
        {
            bool correcto = true;

            if (!Validaciones.ValidarFrase(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Nombre no válido");
                correcto = false;
            }
            if (!Validaciones.ValidarFrase(textBoxApellido.Text))
            {
                errorProvider1.SetError(textBoxApellido, "Nombre no válido");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxDni.Text))
            {
                errorProvider1.SetError(textBoxDni, "Documento no válido");
                correcto = false;
            }
            if (!Validaciones.validarMail(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "Mail no válido");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxTelefono.Text))
            {
                errorProvider1.SetError(textBoxTelefono, "Telefono no válido");
                correcto = false;
            }
            else
            {
                if (Convert.ToDecimal(textBoxTelefono.Text) < 7 && Convert.ToDecimal(textBoxTelefono.Text) > 15)
                {
                    errorProvider1.SetError(textBoxTelefono, "Telefono no válido");
                    correcto = false;
                }
                
            }
            if (!Validaciones.ValidarDireccion(textBoxDireccion.Text))
            {
                errorProvider1.SetError(textBoxDireccion, "Direccion no válida");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxPiso.Text) && (textBoxPiso.Text != ""))
            {
                errorProvider1.SetError(textBoxPiso, "Piso no válido");
                correcto = false;
            }
            if (!Validaciones.ValidarDpto(textBoxDpto.Text))
            {
                errorProvider1.SetError(textBoxDpto, "Dpto no válido");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxCodPostal.Text))
            {
                errorProvider1.SetError(textBoxCodPostal, "CodPostal no válido");
                correcto = false;
            }
                           

            return correcto;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                SQLParametros parametros = new SQLParametros();

                parametros.add("@id_cliente", idCliente);
                parametros.add("@nombre", textBoxNombre.Text);
                parametros.add("@apellido", textBoxApellido.Text);
                parametros.add("@dni", Convert.ToDecimal(textBoxDni.Text));
                parametros.add("@email", textBoxEmail.Text);
                parametros.add("@telefono", textBoxTelefono.Text);
                parametros.add("@direccion", textBoxDireccion.Text);
                parametros.add("@piso", textBoxPiso.Text);
                parametros.add("@dpto", textBoxDpto.Text);
                parametros.add("@localidad", textBoxLocalidad.Text);
                parametros.add("@codPostal", textBoxCodPostal.Text);
                parametros.add("@fechaNac", dateTimePickerFecha.Value);
                parametros.add("@estado", checkBoxEstado.Text);

                if (ConexionDB.Procedure("modificarCliente", parametros.get()))
                {
                    MessageBox.Show("El cliente " + textBoxNombre.Text + " "+textBoxApellido.Text+ " se ha actualizado");
                    
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }

    }
}
