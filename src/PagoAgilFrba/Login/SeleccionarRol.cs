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
using System.Data.SqlClient;

namespace PagoAgilFrba.Login
{
    public partial class SeleccionarRol : Form
    {

        private bool salir = true;

        public SeleccionarRol()
        {
            InitializeComponent();
            SQLParametros parametros = new SQLParametros();
            parametros.add("@id_usuario", Sesion.user_id);

            DataTable rolesDeUsuario;

            if (ConexionDB.Procedure("obtenerRolesDeUsuario", parametros.get(), out rolesDeUsuario))
            {
                comboBoxRoles.DisplayMember = "nombreRol";
                comboBoxRoles.ValueMember = "idRol";
                comboBoxRoles.DataSource = rolesDeUsuario;
                comboBoxRoles.Update();

                Shown += SeleccionarRol_Shown;
            }
        }

        private void SeleccionarRol_Shown(Object sender, EventArgs e)
        {
           if (comboBoxRoles.Items.Count == 1)
            {
                this.Hide();
                buttonSeleccionar_Click(null, null);
            }
        }


        private void buttonVolverALogin_Click(object sender, EventArgs e)
        {
            
            Owner.Show();
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            Sesion.rol_nombre = comboBoxRoles.SelectedText;
            Sesion.rol_id = Convert.ToInt32(comboBoxRoles.SelectedValue);

            new SeleccionarFuncionalidad().Show(this);
            this.Hide();
        }

        private void SeleccionarRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir)
            {
                Application.Exit();
            }
        }
    }
}
