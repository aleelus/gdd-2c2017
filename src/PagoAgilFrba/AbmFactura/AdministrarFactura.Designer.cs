namespace PagoAgilFrba.AbmFactura
{
    partial class AdministrarFactura
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonModificarEliminar = new System.Windows.Forms.Button();
            this.buttonNuevoCliente = new System.Windows.Forms.Button();
            this.dataGridViewBuscarFactura = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNroFactura = new System.Windows.Forms.TextBox();
            this.labelNroFactura = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(489, 361);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "<< Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonModificarEliminar
            // 
            this.buttonModificarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEliminar.Location = new System.Drawing.Point(896, 18);
            this.buttonModificarEliminar.Name = "buttonModificarEliminar";
            this.buttonModificarEliminar.Size = new System.Drawing.Size(144, 52);
            this.buttonModificarEliminar.TabIndex = 13;
            this.buttonModificarEliminar.Text = "Modificar / Eliminar";
            this.buttonModificarEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevoCliente
            // 
            this.buttonNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoCliente.Location = new System.Drawing.Point(725, 18);
            this.buttonNuevoCliente.Name = "buttonNuevoCliente";
            this.buttonNuevoCliente.Size = new System.Drawing.Size(144, 52);
            this.buttonNuevoCliente.TabIndex = 12;
            this.buttonNuevoCliente.Text = "Nueva Factura";
            this.buttonNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonNuevoCliente.Click += new System.EventHandler(this.buttonNuevoCliente_Click);
            // 
            // dataGridViewBuscarFactura
            // 
            this.dataGridViewBuscarFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarFactura.Location = new System.Drawing.Point(12, 81);
            this.dataGridViewBuscarFactura.Name = "dataGridViewBuscarFactura";
            this.dataGridViewBuscarFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarFactura.Size = new System.Drawing.Size(1028, 274);
            this.dataGridViewBuscarFactura.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.textBoxNroFactura);
            this.groupBox1.Controls.Add(this.labelNroFactura);
            this.groupBox1.Controls.Add(this.labelEmpresa);
            this.groupBox1.Controls.Add(this.textBoxDni);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Facturas";
            // 
            // textBoxNroFactura
            // 
            this.textBoxNroFactura.Location = new System.Drawing.Point(533, 28);
            this.textBoxNroFactura.Name = "textBoxNroFactura";
            this.textBoxNroFactura.Size = new System.Drawing.Size(149, 20);
            this.textBoxNroFactura.TabIndex = 6;
            this.textBoxNroFactura.TextChanged += new System.EventHandler(this.textBoxNroFactura_TextChanged);
            // 
            // labelNroFactura
            // 
            this.labelNroFactura.AutoSize = true;
            this.labelNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroFactura.Location = new System.Drawing.Point(445, 29);
            this.labelNroFactura.Name = "labelNroFactura";
            this.labelNroFactura.Size = new System.Drawing.Size(82, 15);
            this.labelNroFactura.TabIndex = 5;
            this.labelNroFactura.Text = "Nro Factura";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(214, 29);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(64, 15);
            this.labelEmpresa.TabIndex = 3;
            this.labelEmpresa.Text = "Empresa";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(59, 27);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(149, 20);
            this.textBoxDni.TabIndex = 2;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(22, 29);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(31, 15);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(284, 28);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(149, 21);
            this.comboBoxEmpresa.TabIndex = 7;
            this.comboBoxEmpresa.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmpresa_SelectionChangeCommitted);
            // 
            // AdministrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1053, 401);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificarEliminar);
            this.Controls.Add(this.buttonNuevoCliente);
            this.Controls.Add(this.dataGridViewBuscarFactura);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonModificarEliminar;
        private System.Windows.Forms.Button buttonNuevoCliente;
        private System.Windows.Forms.DataGridView dataGridViewBuscarFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNroFactura;
        private System.Windows.Forms.Label labelNroFactura;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
    }
}