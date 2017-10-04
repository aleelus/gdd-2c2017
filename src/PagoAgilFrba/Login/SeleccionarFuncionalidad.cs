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
using System.Data.SqlClient;

namespace PagoAgilFrba.Login
{
    public partial class SeleccionarFuncionalidad : Form
    {

        private bool salir = true;

        public SeleccionarFuncionalidad()
        {
            InitializeComponent();

            SQLParametros parametros = new SQLParametros();
            parametros.add("@id_rol", Sesion.rol_id);

            DataTable funcionalidadDeRol;

            if (ConexionDB.Procedure("obtenerFuncionalidadesDeRol", parametros.get(), out funcionalidadDeRol))
            {
                dataGridViewFuncionalidades.DataSource = funcionalidadDeRol;
                dataGridViewFuncionalidades.Columns[0].Visible = false;
                dataGridViewFuncionalidades.ColumnHeadersVisible = false;
            }

            int tam = (funcionalidadDeRol.Rows.Count * 22) + 3;
                         
            dataGridViewFuncionalidades.AutoResizeColumns();
            dataGridViewFuncionalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
         
           if (tam > 393)
            {
                dataGridViewFuncionalidades.Height = 393;
                this.Height = 393 + 150;
                buttonVolver.Top = 393 + 80;
            }
            else
            {
                dataGridViewFuncionalidades.Height = tam;
                this.Height = tam + 150;
                buttonVolver.Top = 70 + tam;
            }
        }
                

        private void buttonVolver_Click_1(object sender, EventArgs e)
        {
            ((DataTable)(dataGridViewFuncionalidades.DataSource)).Dispose();

            salir = false;
            Owner.Show();
            this.Close();
        }

        private void dataGridViewFuncionalidades_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
           dataGridViewFuncionalidades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.CadetBlue;
        }

        private void dataGridViewFuncionalidades_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewFuncionalidades.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
        }

        private void dataGridViewFuncionalidades_Click(object sender, EventArgs e)
        {
            Form nuevoForm = null;
            
            switch (dataGridViewFuncionalidades.CurrentCell.Value.ToString())
            {
                case "ABM Rol":
                    nuevoForm = new AbmRol.Form1();
                    break;
                case "Registro de Usuario":
                    nuevoForm = new Usuario.Form1();
                    break;
                case "ABM Cliente":
                    nuevoForm = new AbmCliente.Form1();
                    break;
                case "ABM Empresa":
                    nuevoForm = new AbmEmpresa.Form1();
                    break;
                case "ABM Sucursal":
                    nuevoForm = new AbmSucursal.Form1();
                    break;
                case "ABM Facturas":
                    nuevoForm = new AbmFactura.AbmFactura();
                    break;
                case "Registro de Pagos de Facturas":
                    nuevoForm = new AbmFactura.AbmFactura();
                    break;
                case "Rendicion de Facturas Cobradas":
                    nuevoForm = new AbmFactura.AbmFactura();
                    break; 
                case "Listado Estadistico":
                    nuevoForm = new ListadoEstadistico.Form1();
                    break;
            }

            nuevoForm.Show(this);
            this.Hide();

        }
        private void SeleccionarFuncionalidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salir)
            {
                Application.Exit();
            }
        }
              
    }
}