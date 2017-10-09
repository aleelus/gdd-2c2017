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

namespace PagoAgilFrba.AbmCliente
{
    public partial class AdministrarCliente : Form
    {

        private bool salir = true;

        

        public AdministrarCliente()
        {
            InitializeComponent();
            dataGridViewBuscarCliente.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewBuscarCliente.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewBuscarCliente.EnableHeadersVisualStyles = false;           
        }

        private void ActulizarResultados()
        {
       
            SQLParametros parametros = new SQLParametros();

            parametros.add("@nombre", textBoxNombre.Text);
            parametros.add("@apellido", textBoxApellido.Text); 
            parametros.add("@dni", textBoxDni.Text);

        

            DataTable clientesEncontrados;

            if (ConexionDB.Procedure("buscarCliente", parametros.get(), out clientesEncontrados))
            {
                dataGridViewBuscarCliente.DataSource = clientesEncontrados;
                dataGridViewBuscarCliente.Columns[0].Visible = false;
            }

           
            dataGridViewBuscarCliente.AutoResizeColumns();
            dataGridViewBuscarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBuscarCliente.RowHeadersVisible = false;
            dataGridViewBuscarCliente.AllowUserToAddRows = false;          
           
            

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

       private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

       private void buttonVolver_Click(object sender, EventArgs e)
       {
                   
            salir = false;
            Owner.Show();
            this.Close();
        
       }

       private void buttonModificarEliminar_Click(object sender, EventArgs e)
       {
           salir = false;
           Form nuevoForm = null;

           DataGridViewCellCollection cell;
           if (dataGridViewBuscarCliente.SelectedRows.Count > 0)
           {
               cell = dataGridViewBuscarCliente.SelectedRows[0].Cells;
               nuevoForm = new AbmCliente.ModificarEliminarCliente();
               ModificarEliminarCliente nuevo = (ModificarEliminarCliente)nuevoForm;
               nuevo.recibirDatos(cell);
               nuevo.Show(this);
               dataGridViewBuscarCliente.DataSource = null;
               this.Hide();
           }
           else
               MessageBox.Show("Debe seleccionar una fila antes");
       }

       private void buttonNuevoCliente_Click(object sender, EventArgs e)
       {
           Form nuevoForm = new AbmCliente.NuevoCliente();
           nuevoForm.Show(this);
           dataGridViewBuscarCliente.DataSource = null;
           this.Hide();
       }
    }
}
