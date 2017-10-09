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
    public partial class AdministrarSucursal : Form
    {

        private bool salir = true;

        public AdministrarSucursal()
        {
            InitializeComponent();
            dataGridViewBuscarSucursal.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewBuscarSucursal.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewBuscarSucursal.EnableHeadersVisualStyles = false; 
        }

        private void ActulizarResultados()
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@nombre", textBoxNombre.Text);
            parametros.add("@direccion", textBoxDireccion.Text);
            parametros.add("@codPostal", textBoxCodigoPostal.Text);



            DataTable sucursalesEncontradas;

            if (ConexionDB.Procedure("buscarSucursal", parametros.get(), out sucursalesEncontradas))
            {
                dataGridViewBuscarSucursal.DataSource = sucursalesEncontradas;
                dataGridViewBuscarSucursal.Columns[0].Visible = false;
            }


            dataGridViewBuscarSucursal.AutoResizeColumns();
            dataGridViewBuscarSucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBuscarSucursal.RowHeadersVisible = false;
            dataGridViewBuscarSucursal.AllowUserToAddRows = false;



        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void buttonNuevaSucursal_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new AbmSucursal.NuevaSucursal();
            nuevoForm.Show(this);
            dataGridViewBuscarSucursal.DataSource = null;
            this.Hide();
        }

        private void buttonModificarEliminar_Click(object sender, EventArgs e)
        {
            salir = false;
            Form nuevoForm = null;

            DataGridViewCellCollection cell;
            if (dataGridViewBuscarSucursal.SelectedRows.Count > 0)
            {
                cell = dataGridViewBuscarSucursal.SelectedRows[0].Cells;
                nuevoForm = new AbmSucursal.ModificarEliminarSucursal();
                ModificarEliminarSucursal nuevo = (ModificarEliminarSucursal)nuevoForm;
                nuevo.recibirDatos(cell);
                nuevo.Show(this);
                dataGridViewBuscarSucursal.DataSource = null;
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
