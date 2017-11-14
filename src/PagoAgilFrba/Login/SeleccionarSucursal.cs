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

namespace PagoAgilFrba.Login
{
    public partial class SeleccionarSucursal : Form
    {
        public SeleccionarSucursal()
        {
            InitializeComponent();

            SQLParametros parametros = new SQLParametros();
            parametros.add("@id_usuario", Sesion.user_id);

            DataTable rolesDeUsuario;

            if (ConexionDB.Procedure("obtenerSucursalesDeUsuario", parametros.get(), out rolesDeUsuario))
            {
                comboBoxSucursales.DisplayMember = "nombreSucursal";
                comboBoxSucursales.ValueMember = "idSucursal";                
                comboBoxSucursales.DataSource = rolesDeUsuario;
                comboBoxSucursales.Update();

                Shown += SeleccionarSucursal_Shown;
            }
                       

        }

        private void SeleccionarSucursal_Shown(Object sender, EventArgs e)
        {

            if (comboBoxSucursales.Items.Count == 1) // Si solo tiene una sucursal, entra directamente
             {
                 Sesion.sucursal_nombre = ((DataRowView)(comboBoxSucursales.SelectedItem)).Row.ItemArray[1].ToString();
                 Sesion.sucursal_id = Convert.ToInt32(comboBoxSucursales.SelectedValue);
                 this.Hide();
                 buttonSeleccionar_Click(null, null);
             }
        }

     

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (comboBoxSucursales.SelectedIndex > -1) {
                Sesion.sucursal_nombre = ((DataRowView)(comboBoxSucursales.SelectedItem)).Row.ItemArray[1].ToString();
                Sesion.sucursal_id = Convert.ToInt32(comboBoxSucursales.SelectedValue);
                new SeleccionarRol().Show(this);
                this.Hide();
            }
            
        }

        private void buttonSalirRol_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        

    }
}
