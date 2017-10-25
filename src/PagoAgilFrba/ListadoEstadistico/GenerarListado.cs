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

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class GenerarListado : Form
    {

        private bool salir = true;

        public GenerarListado(int anioIngresado, int listadoIndex, int trimestreIndex)
        {
            InitializeComponent();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;

            SQLParametros parametros = new SQLParametros();

            parametros.add("@anio", anioIngresado);
            parametros.add("@primerMes", 1 + (trimestreIndex * 3));
            parametros.add("@ultimoMes", 3 + (trimestreIndex * 3));

            string procToCall = "generarListado" + listadoIndex.ToString();
            DataTable listado;

            if (ConexionDB.Procedure(procToCall, parametros.get(), out listado))
            {
                dataGridView1.DataSource = listado;
            }

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }
    }
}
