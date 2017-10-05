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


namespace PagoAgilFrba.AbmRol
{
    public partial class AdministrarRoles : Form
    {
        private bool salir = true;

        DataTable rolesActuales;

        public AdministrarRoles()
        {
            InitializeComponent();
        }

        private void ActualizarRoles()
        {
            if (ConexionDB.Procedure("obtenerRoles", null, out rolesActuales))
            {
                comboBoxSeleccionarRol.DataSource = rolesActuales;
                comboBoxSeleccionarRol.DisplayMember = "nombreRol";
                comboBoxSeleccionarRol.ValueMember = "idRol";                
                comboBoxSeleccionarRol.Update();
                comboBoxSeleccionarRol.SelectedIndex = -1;
            }

        }

         private void resetear()
        {
            for (int i = 0; i < checkedListBoxFuncionalidades.Items.Count; i++)
            {
                checkedListBoxFuncionalidades.SetItemChecked(i, false);
            }

            checkBoxEstado.Checked = false;
            
        }

        private void AdministrarRoles_Load(object sender, EventArgs e)
        {
            ActualizarRoles();

            DataTable funcionalidades;

            if (ConexionDB.Procedure("obtenerFuncionalidades", null, out funcionalidades))
            {
                foreach (DataRow row in funcionalidades.Rows)
                {

                    checkedListBoxFuncionalidades.Items.Add(row["nombreFuncionalidad"].ToString());

                }
                
            }
        }

        private void comboBoxSeleccionarRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRow[] rowRol = rolesActuales.Select("idRol = " + comboBoxSeleccionarRol.SelectedValue);

            resetear();
            try
            {
                if (rowRol[0][2].ToString().Contains("Activo"))
                    checkBoxEstado.Checked = true;
                else
                    checkBoxEstado.Checked = false;
            }
            catch (IndexOutOfRangeException) { }

            buttonGuardar.Enabled = false;

            SQLParametros parametros = new SQLParametros();
            parametros.add("@nombre", comboBoxSeleccionarRol.SelectedValue);

            DataTable funcsActivas;

            if (ConexionDB.Procedure("funcionesDelRol", parametros.get(), out funcsActivas))
            {


                foreach (DataRow funcAct in funcsActivas.Rows)
                {
                    checkedListBoxFuncionalidades.SetItemChecked(checkedListBoxFuncionalidades.Items.IndexOf(funcAct["nombreFuncionalidad"].ToString()), true);
                }
            }

        }


        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;

            if (checkBoxEstado.Checked)
            {
                checkBoxEstado.Text = "Activo";
            }
            else
            {
                checkBoxEstado.Text = "Inactivo";
            }
        }

        private void checkedListBoxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void buttonNuevoRol_Click(object sender, EventArgs e)
        {
            NuevoRol nvoRol = new NuevoRol();
            nvoRol.ShowDialog(this);

            resetear();

            this.ActualizarRoles();
        }

        private void AdministrarRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir)
            {
                Application.Exit();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            if (!Validaciones.ValidarLetrasGuiones(comboBoxSeleccionarRol.Text))
            {
                errorProvider1.SetError(comboBoxSeleccionarRol, "Elija un Rol");
                return;
            }

            string funciones = "";
            string estado = "Inactivo";

            if (checkBoxEstado.Checked)
                estado = "Activo";
            else 
                estado = "Inactivo";

            buttonGuardar.Enabled = false;

            foreach (Object itemChecked in checkedListBoxFuncionalidades.CheckedItems)
            {
                funciones = funciones + "," + itemChecked.ToString();

            }

            resetear();

            SQLParametros parametros = new SQLParametros();

            parametros.add("@rol", comboBoxSeleccionarRol.Text);
            parametros.add("@listaFuc", funciones);
            parametros.add("@estado", estado);

            ConexionDB.Procedure("asignarNuevasFuncAlRol", parametros.get());


            this.ActualizarRoles();

        }
   
    }
}
