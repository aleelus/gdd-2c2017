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

namespace PagoAgilFrba.Rendicion
{
    public partial class Rendicion : Form
    {

        public decimal idEmpresa;

        public Rendicion()
        {
            InitializeComponent();

            dataGridViewListaRendiciones.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewListaRendiciones.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewListaRendiciones.EnableHeadersVisualStyles = false;

            dataGridViewListaFacturas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewListaFacturas.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewListaFacturas.EnableHeadersVisualStyles = false;


            actualizarRendiciones();
            buttonEfectuarRendicion.Enabled = false;

        }

        private void actualizarRendiciones() {

            SQLParametros parametros = new SQLParametros();

            DataTable rendiciones;

            if (ConexionDB.Procedure("obtenerListaRendiciones", parametros.get(), out rendiciones))
            {
                dataGridViewListaRendiciones.DataSource = rendiciones;
                dataGridViewListaRendiciones.Columns[0].Visible = false;
                dataGridViewListaRendiciones.ColumnHeadersVisible = false;

            }

            dataGridViewListaRendiciones.AutoResizeColumns();
            dataGridViewListaRendiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaRendiciones.RowHeadersVisible = false;
            dataGridViewListaRendiciones.AllowUserToAddRows = false;
        
        }

        private void dataGridViewListaRendiciones_Click(object sender, EventArgs e)
        {

            if (dataGridViewListaRendiciones.Rows.Count > 0) {

                idEmpresa = Convert.ToDecimal(dataGridViewListaRendiciones.CurrentRow.Cells["idEmpresa"].Value);

                if (idEmpresa > 0)
                {

                    string fecha = dataGridViewListaRendiciones.CurrentRow.Cells["fechaRendicionEmpresa"].Value.ToString();
                    string fechaPosta = Convert.ToDateTime(fecha).ToShortDateString().ToString();

                    labelFechaDeRendicion.Text = fechaPosta;
                    labelEmpresaNombre.Text = dataGridViewListaRendiciones.CurrentRow.Cells["nombreEmpresa"].Value.ToString();

                    SQLParametros parametros = new SQLParametros();

                    DataTable rendiciones;

                    parametros.add("@id_empresa", idEmpresa);

                    if (ConexionDB.Procedure("obtenerDetalleRendicion", parametros.get(), out rendiciones))
                    {
                        dataGridViewListaFacturas.DataSource = rendiciones;
                        dataGridViewListaFacturas.Columns[0].Visible = false;


                    }

                    dataGridViewListaFacturas.AutoResizeColumns();
                    dataGridViewListaFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewListaFacturas.RowHeadersVisible = false;
                    dataGridViewListaFacturas.AllowUserToAddRows = false;

                    labelCantFacRen.Text = dataGridViewListaFacturas.Rows.Count.ToString();

                }
            }
            
            

        }

        private void textBoxPorcentajeComision_TextChanged(object sender, EventArgs e)
        {

            if (dataGridViewListaFacturas.Rows.Count > 0) {

                if (textBoxPorcentajeComision.Text != "")
                {
                    if (Convert.ToDecimal(textBoxPorcentajeComision.Text) > 0 && Convert.ToDecimal(textBoxPorcentajeComision.Text) < 101)
                    {

                        decimal total = 0;
                        foreach (DataGridViewRow r in dataGridViewListaFacturas.Rows)
                        {
                            total = total + Convert.ToDecimal(r.Cells["Importe Total"].Value);
                        }

                        labelImpTotal.Text = total.ToString();
                        labelImporteComision.Text = (total * (Convert.ToDecimal(textBoxPorcentajeComision.Text) / 100)).ToString();

                        errorProvider1.Clear();
                        buttonEfectuarRendicion.Enabled = true;

                    }
                    else
                    {
                        errorProvider1.SetError(textBoxPorcentajeComision, "Porcentaje invalido");
                        buttonEfectuarRendicion.Enabled = false;
                    }

                }
            }
       
            
           

        }

        private void buttonEfectuarRendicion_Click(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();
                      
            
            parametros.add("@id_empresa", idEmpresa);
            parametros.add("@cant_facturas_rendidas", Convert.ToDecimal(labelCantFacRen.Text));
            parametros.add("@importe_rendicion", Convert.ToDecimal(labelImporteComision.Text));
            parametros.add("@porcentaje_comision", Convert.ToDecimal(textBoxPorcentajeComision.Text));
            parametros.add("@importe_total", Convert.ToDecimal(labelImpTotal.Text));

            if (ConexionDB.Procedure("efectuarRendicion", parametros.get()))
            {
                MessageBox.Show("La rendicion  se ha efectuado");

            }

            actualizarRendiciones();
            dataGridViewListaFacturas.DataSource = null;
            labelCantFacRen.Text = "";
            labelImporteComision.Text = "";
            textBoxPorcentajeComision.Text = "";
            labelImpTotal.Text = "";    
            

        }

              
       

    }
}
