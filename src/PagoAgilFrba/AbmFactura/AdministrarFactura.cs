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

namespace PagoAgilFrba.AbmFactura
{
    public partial class AdministrarFactura : Form
    {

        private bool salir = true;

        public AdministrarFactura()
        {
            InitializeComponent();

            dataGridViewBuscarFactura.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewBuscarFactura.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewBuscarFactura.EnableHeadersVisualStyles = false;


            SQLParametros parametros = new SQLParametros();

            DataTable empresas;

            if (ConexionDB.Procedure("obtenerEmpresas", parametros.get(), out empresas))
            {
                comboBoxEmpresa.DisplayMember = "nombreEmpresa";
                comboBoxEmpresa.ValueMember = "idEmpresa";
                comboBoxEmpresa.DataSource = empresas;
                comboBoxEmpresa.Update();
                comboBoxEmpresa.SelectedIndex = -1;
                comboBoxEmpresa.SelectedValue = -1;

            }

        }

        private void ActulizarResultados()
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@dni", textBoxDni.Text);
            if (comboBoxEmpresa.SelectedValue == null)
            {
                comboBoxEmpresa.Text = "";
                parametros.add("@id_empresa", comboBoxEmpresa.Text);
            }
            else
            {
                parametros.add("@id_empresa", comboBoxEmpresa.SelectedValue.ToString());
            }
            parametros.add("@nroFactura",textBoxNroFactura.Text);



            DataTable facturasEncontradas;

            if (ConexionDB.Procedure("buscarFactura", parametros.get(), out facturasEncontradas))
            {
                dataGridViewBuscarFactura.DataSource = facturasEncontradas;
                dataGridViewBuscarFactura.Columns[0].Visible = false;
                dataGridViewBuscarFactura.Columns[1].Visible = false;
                dataGridViewBuscarFactura.Columns[2].Visible = false;
            }


            dataGridViewBuscarFactura.AutoResizeColumns();
            dataGridViewBuscarFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBuscarFactura.RowHeadersVisible = false;
            dataGridViewBuscarFactura.AllowUserToAddRows = false;


            comboBoxEmpresa.SelectedIndex = -1;
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxNroFactura_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void comboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void buttonNuevoCliente_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new AbmFactura.NuevaFactura();
            nuevoForm.Show(this);
            this.Hide();
        }

        private void buttonModificarEliminar_Click(object sender, EventArgs e)
        {                       

            salir = false;
            Form nuevoForm = null;
            
            DataGridViewCellCollection cell;
            if (dataGridViewBuscarFactura.SelectedRows.Count > 0)
            {

                // CONTROLAR ACA SI SE PUEDE MODIFICAR LA FACTURA
                // SOLO SE PUEDE MODIFICAR SI NO SE PAGARON Y/O RENDIDA
                // CON Convert.ToDecimal(cell["idFactura"].Value) HAGO UN JOIN A LA
                // TABLA DE PAGOS Y TABLA RENDICIONES Y VERIFICO

                cell = dataGridViewBuscarFactura.SelectedRows[0].Cells;
                nuevoForm = new AbmFactura.ModificarEliminarFactura();
                ModificarEliminarFactura nuevo = (ModificarEliminarFactura)nuevoForm;
                nuevo.recibirDatos(cell);
                nuevo.Show(this);
                dataGridViewBuscarFactura.DataSource = null;
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
