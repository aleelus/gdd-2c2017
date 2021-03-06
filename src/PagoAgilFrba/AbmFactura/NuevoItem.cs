﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmFactura
{
    public partial class NuevoItem : Form
    {

        Form nuevaFac = new NuevaFactura();
        Form modFac = new ModificarEliminarFactura();
        public int estado = 0 ; // 1 = nuevaFactura : 2 = ModificarEliminarFactura

        public NuevoItem()
        {
            InitializeComponent();
        }

        private bool salir = true;

        private bool validar()
        {
            bool correcto = true;

            if (!Validaciones.ValidarFrase(textBoxNombre.Text))
            {
                errorProvider1.SetError(textBoxNombre, "Nombre no válido");
                correcto = false;
            }
            if (!Validaciones.validarMonto(textBoxMonto.Text))
            {
                errorProvider1.SetError(textBoxMonto, "Monto no válido");
                correcto = false;
            }
            if (!Validaciones.validarSoloNumeros(textBoxCantidad.Text))
            {
                errorProvider1.SetError(textBoxCantidad, "Cantidad no válida");
                correcto = false;
            }
            if (textBoxCantidad.Text == "0" || textBoxMonto.Text == "0" ) {
                errorProvider1.SetError(textBoxCantidad, "Numero no valido");
                correcto = false;
            }

            return correcto;
        }

        public void enviarFormItem(NuevaFactura nuevaFacturaForm,ModificarEliminarFactura modFacturaForm, int est)
        {
            nuevaFac = nuevaFacturaForm;
            modFac = modFacturaForm;
            estado = est;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                salir = false; 
               
                Item nuevoItem = new Item(textBoxNombre.Text, Convert.ToDecimal(textBoxMonto.Text), Convert.ToInt16(textBoxCantidad.Text));
                
                if(estado == 1){
                    NuevaFactura nuevo = (NuevaFactura)nuevaFac;
                    nuevo.recibirItems(nuevoItem);
                }
                else if (estado == 2)
                {
                    ModificarEliminarFactura nuevo = (ModificarEliminarFactura)modFac;
                    nuevo.recibirItems(nuevoItem);
                }

                
                this.Close();

            }

            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            salir = false;            
            this.Close();
        }
    }
}
