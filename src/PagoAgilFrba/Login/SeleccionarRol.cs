﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Login
{
    public partial class SeleccionarRol : Form
    {
        public SeleccionarRol()
        {
            InitializeComponent();
        }

        private void buttonVolverALogin_Click(object sender, EventArgs e)
        {
            
            Owner.Show();
            this.Close();
        }
    }
}
