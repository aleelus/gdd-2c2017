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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
                
            // ACA SE REALIZAN LAS VALIDACIONES DEL LOGIN Y EL HASHEO
            new SeleccionarRol().Show(this);
            this.Hide();
        }
    }
}
