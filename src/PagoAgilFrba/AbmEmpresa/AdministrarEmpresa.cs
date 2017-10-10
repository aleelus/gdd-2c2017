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
    public partial class AdministrarEmpresa : Form
    {

        private bool salir = true;

        public AdministrarEmpresa()
        {
            InitializeComponent();
            dataGridViewBuscarEmpresa.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewBuscarEmpresa.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewBuscarEmpresa.EnableHeadersVisualStyles = false;


            SQLParametros parametros = new SQLParametros();
           
            DataTable rubros;

            if (ConexionDB.Procedure("obtenerRubros", parametros.get(), out rubros))
            {
                comboBoxRubro.DisplayMember = "descripcionRubro";
                comboBoxRubro.ValueMember = "idRubro";
                comboBoxRubro.DataSource = rubros;
                comboBoxRubro.Update();
                comboBoxRubro.SelectedIndex = -1;
    
            }

        }


        private void ActulizarResultados()
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@nombre", textBoxNombre.Text);
            parametros.add("@cuit", textBoxApellido.Text);
            if (comboBoxRubro.SelectedValue == null) {
                comboBoxRubro.Text = "";
                parametros.add("@id_rubro", comboBoxRubro.Text);
            }
            else{
                parametros.add("@id_rubro", comboBoxRubro.SelectedValue.ToString());
            }
            



            DataTable empresasEncontradas;

            if (ConexionDB.Procedure("buscarEmpresa", parametros.get(), out empresasEncontradas))
            {
                dataGridViewBuscarEmpresa.DataSource = empresasEncontradas;
                dataGridViewBuscarEmpresa.Columns[0].Visible = false;
                dataGridViewBuscarEmpresa.Columns[1].Visible = false;
            }


            dataGridViewBuscarEmpresa.AutoResizeColumns();
            dataGridViewBuscarEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBuscarEmpresa.RowHeadersVisible = false;
            dataGridViewBuscarEmpresa.AllowUserToAddRows = false;


            comboBoxRubro.SelectedIndex = -1;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void comboBoxRubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void buttonNuevaEmpresa_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new AbmEmpresa.NuevaEmpresa();
            nuevoForm.Show(this);
            this.Hide();
        }

        private void buttonModificarEliminar_Click(object sender, EventArgs e)
        {
            salir = false;
            Form nuevoForm = null;

            DataGridViewCellCollection cell;
            if (dataGridViewBuscarEmpresa.SelectedRows.Count > 0)
            {
                cell = dataGridViewBuscarEmpresa.SelectedRows[0].Cells;
                nuevoForm = new AbmEmpresa.ModificarEliminarEmpresa();
                ModificarEliminarEmpresa nuevo = (ModificarEliminarEmpresa)nuevoForm;
                nuevo.recibirDatos(cell);
                nuevo.Show(this);
                dataGridViewBuscarEmpresa.DataSource = null;
                this.Hide();
            }
            else
                MessageBox.Show("Debe seleccionar una fila antes");
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();            
            this.Close();
        }



    }
}
