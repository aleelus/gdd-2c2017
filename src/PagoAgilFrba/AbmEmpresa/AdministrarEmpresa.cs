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
    
            }

        }


        private void ActulizarResultados()
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@nombre", textBoxNombre.Text);
            parametros.add("@cuit", textBoxApellido.Text);
            parametros.add("@rubro", comboBoxRubro.SelectedText);



            DataTable empresasEncontradas;

            if (ConexionDB.Procedure("buscarEmpresa", parametros.get(), out empresasEncontradas))
            {
                dataGridViewBuscarEmpresa.DataSource = empresasEncontradas;
                dataGridViewBuscarEmpresa.Columns[0].Visible = false;
            }


            dataGridViewBuscarEmpresa.AutoResizeColumns();
            dataGridViewBuscarEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBuscarEmpresa.RowHeadersVisible = false;
            dataGridViewBuscarEmpresa.AllowUserToAddRows = false;



        }



    }
}
