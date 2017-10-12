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
    public partial class NuevaFactura : Form
    {

        private bool salir = true;

        public NuevaFactura()
        {
            InitializeComponent();

            dataGridViewItems.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewItems.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewItems.AllowUserToAddRows = false;

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

        private void buttonAgregarItem_Click(object sender, EventArgs e)
        {
            Form nuevoForm = new AbmFactura.NuevoItem();
            NuevoItem nueva = (NuevoItem)nuevoForm;
            nueva.enviarFormItem(this,null,1);
            nuevoForm.Show(this);           
        }

        private bool validar()
        {
            bool correcto = true;

            if (!Validaciones.validarSoloNumeros(textBoxDni.Text))
            {
                errorProvider1.SetError(textBoxDni, "Dni no válido");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxNroFactura.Text))
            {
                errorProvider1.SetError(textBoxNroFactura, "Nro de Factura no válido");
                correcto = false;
            }
            if (dateTimePickerFechaAlta.Value >= dateTimePickerFechaVto.Value) {
                errorProvider1.SetError(dateTimePickerFechaVto, "Fecha no válida");
                errorProvider1.SetError(dateTimePickerFechaAlta, "Fecha no válida");
                correcto = false;
            }
            if (dataGridViewItems.Rows.Count == 0) {
                errorProvider1.SetError(textBoxNroFactura, "Por favor Agregue Items");
                correcto = false;
            }
 
            return correcto;
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEstado.Checked)
            {
                checkBoxEstado.Text = "Activo";
            }
            else
            {
                checkBoxEstado.Text = "Inactivo";
            }
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {

            if (validar())
            {

                string listaItems = "";

                SQLParametros parametros = new SQLParametros();

                foreach (DataGridViewRow r in dataGridViewItems.Rows)
                {
                    listaItems = listaItems + r.Cells["Nombre"].Value + "," + r.Cells["Monto"].Value + "," + r.Cells["Cantidad"].Value + ",";
                }

                parametros.add("@dni", Convert.ToDecimal(textBoxDni.Text));
                parametros.add("@id_empresa", comboBoxEmpresa.SelectedValue);
                parametros.add("@nroFactura", Convert.ToDecimal(textBoxNroFactura.Text));
                parametros.add("@fechaAlta", dateTimePickerFechaAlta.Value);
                parametros.add("@fechaVto", dateTimePickerFechaVto.Value);
                parametros.add("@listaItems", listaItems); 
                parametros.add("@estado", checkBoxEstado.Text);
                parametros.add("@total", Convert.ToDecimal(textBoxTotal.Text));

                if (ConexionDB.Procedure("nuevaFactura", parametros.get()))
                {
                    MessageBox.Show("La factura " + textBoxNroFactura.Text + " se ha creado");

                }
            }

        }

        public void recibirItems(Item nuevoItem) {
                        
            int rowIndex = this.dataGridViewItems.Rows.Add();            
            var row = this.dataGridViewItems.Rows[rowIndex];
            
            row.Cells["Nombre"].Value = nuevoItem.nombreItem;
            row.Cells["Monto"].Value = nuevoItem.montoItem;
            row.Cells["Cantidad"].Value = nuevoItem.cantidadItem;

            actualizarTotal();
        
        }

        private void buttonSacarItem_Click(object sender, EventArgs e)
        {

            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridViewItems.SelectedRows)
                {
                    dataGridViewItems.Rows.RemoveAt(item.Index);
                }

                actualizarTotal();

            }
            else
                MessageBox.Show("Debe seleccionar una fila antes");

            
        }

        public void actualizarTotal() {

            if (dataGridViewItems.Rows.Count > 0)
            {
                Decimal sum = 0;               

                foreach (DataGridViewRow r in dataGridViewItems.Rows)
                {
                    sum = sum + ( Convert.ToDecimal(r.Cells["Monto"].Value) * Convert.ToDecimal(r.Cells["Cantidad"].Value) );
                }
                textBoxTotal.Text = sum.ToString();

            }
            else
                textBoxTotal.Text = "0";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            salir = false;
            Owner.Show();
            this.Close();
        }
           
             

    }
}
