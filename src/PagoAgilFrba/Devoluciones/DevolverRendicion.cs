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

namespace PagoAgilFrba.Devoluciones
{
    public partial class DevolverRendicion : Form
    {

        private bool salir = true;

        public DevolverRendicion()
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
            parametros.add("@nroFactura", textBoxNroFactura.Text);



            DataTable facturasEncontradas;

            if (ConexionDB.Procedure("buscarFacturaRendicionADevolver", parametros.get(), out facturasEncontradas))
            {
                dataGridViewBuscarFactura.DataSource = facturasEncontradas;
                dataGridViewBuscarFactura.Columns[0].Visible = false;
                dataGridViewBuscarFactura.Columns[1].Visible = false;
                dataGridViewBuscarFactura.Columns[2].Visible = false;
                dataGridViewBuscarFactura.Columns[3].Visible = false;
                dataGridViewBuscarFactura.Columns[4].Visible = false;
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

        private void comboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void textBoxNroFactura_TextChanged(object sender, EventArgs e)
        {
            ActulizarResultados();
        }

        private void buttonEfectuarDevolucion_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuscarFactura.SelectedRows.Count > 0 && textBoxMotivo.Text != "")
            {

                SQLParametros parametros = new SQLParametros();

                parametros.add("@id_factura", dataGridViewBuscarFactura.CurrentRow.Cells["idFactura"].Value);
                parametros.add("@id_rendicion", dataGridViewBuscarFactura.CurrentRow.Cells["idRendicion"].Value);
                parametros.add("@nro_factura", dataGridViewBuscarFactura.CurrentRow.Cells["Nro Factura"].Value);
                parametros.add("@descripcionMotivo", textBoxMotivo.Text);
                parametros.add("@monto", dataGridViewBuscarFactura.CurrentRow.Cells["Total"].Value);

                if (ConexionDB.Procedure("devolverFacturaRendicion", parametros.get()))
                {
                    MessageBox.Show("Se devolvio la rendicion con factura nro: " + dataGridViewBuscarFactura.CurrentRow.Cells["Nro Factura"].Value.ToString());
                }

            }
            else
                MessageBox.Show("Debe seleccionar una fila antes y escribir un motivo de devolución");
        }





    }
}
