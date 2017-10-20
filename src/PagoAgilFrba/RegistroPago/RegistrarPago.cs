﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.BaseDeDatos.ConexionDB;

namespace PagoAgilFrba.RegistroPago
{
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();

            dataGridViewListaFacturas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewListaFacturas.ColumnHeadersDefaultCellStyle.Font = new Font(" Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            dataGridViewListaFacturas.EnableHeadersVisualStyles = false;
            dataGridViewListaFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListaFacturas.RowHeadersVisible = false;
            dataGridViewListaFacturas.AllowUserToAddRows = false;
          


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

            DataTable formasDePago;

            if (ConexionDB.Procedure("obtenerFormasDePago", parametros.get(), out formasDePago))
            {
                comboBoxFormaPago.DisplayMember = "descripcionFormaPago";
                comboBoxFormaPago.ValueMember = "idFormaPago";
                comboBoxFormaPago.DataSource = formasDePago;
                comboBoxFormaPago.Update();
                comboBoxFormaPago.SelectedIndex = -1;
                comboBoxFormaPago.SelectedValue = -1;

            }

            

            dateTimePickerCobro.Value = Sesion.fechaActual;
            textBoxSucursal.Text = Sesion.sucursal_nombre;
            
        }

        private void comboBoxEmpresa_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@id_empresa", comboBoxEmpresa.SelectedValue);
            

            DataTable clientesEncontrados;

            if (ConexionDB.Procedure("buscarClientesDeEmpresas", parametros.get(), out clientesEncontrados))
            {
                comboBoxCliente.DisplayMember = "Datos";
                comboBoxCliente.ValueMember = "idCliente";
                comboBoxCliente.DataSource = clientesEncontrados;
                comboBoxCliente.Update();
                comboBoxCliente.SelectedIndex = -1;
                comboBoxCliente.SelectedValue = -1;
                                
            }


        }
        

        private void comboBoxCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@id_cliente", comboBoxCliente.SelectedValue);


            DataTable facturasEncontrados;

            if (ConexionDB.Procedure("buscarFacturasDeClientes", parametros.get(), out facturasEncontrados))
            {
                comboBoxNroFactura.DisplayMember = "numeroFactura";
                comboBoxNroFactura.ValueMember = "idFactura";
                comboBoxNroFactura.DataSource = facturasEncontrados;
                comboBoxNroFactura.Update();
                comboBoxNroFactura.SelectedIndex = -1;
                comboBoxNroFactura.SelectedValue = -1;

            }

        }

        private void comboBoxNroFactura_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SQLParametros parametros = new SQLParametros();

            parametros.add("@id_factura", comboBoxNroFactura.SelectedValue);


            DataTable facturaEncontrada;

            if (ConexionDB.Procedure("buscarDatosDeFactura", parametros.get(), out facturaEncontrada))
            {

                textBoxImporte.Text = facturaEncontrada.Rows[0]["Importe"].ToString();
                dateTimePickerVto.Value = (DateTime)facturaEncontrada.Rows[0]["Fecha Vto"];

            }

        }

        private bool validar() {

            bool correcto = true;

            foreach (DataGridViewRow fila in dataGridViewListaFacturas.Rows)
            {
                if (fila.Cells[2].Value.ToString() == comboBoxNroFactura.Text)
                {
                    correcto = false;
                    errorProvider1.SetError(comboBoxNroFactura, "Ya se agrego esa factura");
                    break;
                }
            }

            if (comboBoxEmpresa.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBoxEmpresa, "Elija una empresa");
                correcto = false;
            }
            if (comboBoxCliente.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBoxCliente, "Elija un cliente");
                correcto = false;
            }
            if (comboBoxNroFactura.SelectedIndex < 0)
            {
                errorProvider1.SetError(comboBoxNroFactura, "Elija una factura");
                correcto = false;
            }
            if (comboBoxFormaPago.SelectedIndex < 0) {
                errorProvider1.SetError(comboBoxFormaPago, "Elija una forma de pago");
                correcto = false;
            }


            return correcto;

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
          

            if (validar()) {

                int rowIndex = this.dataGridViewListaFacturas.Rows.Add();
                var row = this.dataGridViewListaFacturas.Rows[rowIndex];

                row.Cells["Datos"].Value = ((DataRowView)(comboBoxCliente.SelectedItem)).Row.ItemArray[1].ToString();
                row.Cells["Empresa"].Value = ((DataRowView)(comboBoxEmpresa.SelectedItem)).Row.ItemArray[1].ToString();
                row.Cells["NroFactura"].Value = comboBoxNroFactura.Text;
                row.Cells["Importe"].Value = textBoxImporte.Text;
                row.Cells["FormaPago"].Value = comboBoxFormaPago.Text;
                row.Cells["FechaVto"].Value = dateTimePickerVto.Value;
            
            }
     

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaFacturas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridViewListaFacturas.SelectedRows)
                {
                    dataGridViewListaFacturas.Rows.RemoveAt(item.Index);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una fila antes");
        }

        private void buttonRegistrarPago_Click(object sender, EventArgs e)
        {

            if (dataGridViewListaFacturas.Rows.Count > 0) {               

                SQLParametros parametros = new SQLParametros();
                int contador = 0;

                foreach (DataGridViewRow fila in dataGridViewListaFacturas.Rows)
                {
                    parametros.add("@nro_factura", fila.Cells["NroFactura"].Value);
                    parametros.add("@id_sucursal", Sesion.sucursal_id);                    
                    parametros.add("@fecha_cobro", dateTimePickerCobro.Value);
                    parametros.add("@fecha_vto", fila.Cells["FechaVto"].Value);
                    parametros.add("@importe", fila.Cells["Importe"].Value);
                    parametros.add("@forma_pago", fila.Cells["FormaPago"].Value);

                    if (ConexionDB.Procedure("nuevoPago", parametros.get()))                    
                        contador++;

                    parametros.Clear();
                }

                if (contador == 1)
                {
                    MessageBox.Show("La factura " + comboBoxNroFactura.Text + " se ha pagado");
                }
                else if (contador >1){
                    MessageBox.Show("Las " + contador.ToString() + " se han pagado");
                }
                      
            }

        }
    }
}