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
    public partial class NuevoCliente : Form
    {
        private bool salir = true;
        
        public NuevoCliente()
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

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                SQLParametros parametros = new SQLParametros();

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

                if (ConexionDB.Procedure("nuevoCliente", parametros.get()))
                {
                    MessageBox.Show("El cliente " + textBoxNombre.Text + " "+textBoxApellido.Text+ " se ha creado");
                    
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
