﻿namespace PagoAgilFrba.Login
{
    partial class SeleccionarRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRol = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonSalirRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(12, 41);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(33, 15);
            this.labelRol.TabIndex = 0;
            this.labelRol.Text = "Rol:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionar.Location = new System.Drawing.Point(67, 83);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(97, 29);
            this.buttonSeleccionar.TabIndex = 5;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            // 
            // buttonSalirRol
            // 
            this.buttonSalirRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirRol.Location = new System.Drawing.Point(222, 83);
            this.buttonSalirRol.Name = "buttonSalirRol";
            this.buttonSalirRol.Size = new System.Drawing.Size(97, 29);
            this.buttonSalirRol.TabIndex = 6;
            this.buttonSalirRol.Text = "Salir";
            this.buttonSalirRol.UseVisualStyleBackColor = true;
            this.buttonSalirRol.Click += new System.EventHandler(this.buttonVolverALogin_Click);
            // 
            // SeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(379, 136);
            this.Controls.Add(this.buttonSalirRol);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelRol);
            this.Name = "SeleccionarRol";
            this.Text = "SeleccionarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonSalirRol;
    }
}