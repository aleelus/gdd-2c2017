namespace PagoAgilFrba.Devoluciones
{
    partial class DevolverRendicion
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
            this.buttonEfectuarDevolucion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.textBoxNroFactura = new System.Windows.Forms.TextBox();
            this.labelNroFactura = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuscarFactura = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMotivo = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarFactura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(569, 396);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(144, 52);
            this.buttonVolver.TabIndex = 20;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonEfectuarDevolucion
            // 
            this.buttonEfectuarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEfectuarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEfectuarDevolucion.Location = new System.Drawing.Point(387, 396);
            this.buttonEfectuarDevolucion.Name = "buttonEfectuarDevolucion";
            this.buttonEfectuarDevolucion.Size = new System.Drawing.Size(144, 52);
            this.buttonEfectuarDevolucion.TabIndex = 19;
            this.buttonEfectuarDevolucion.Text = "Efectuar devolución";
            this.buttonEfectuarDevolucion.UseVisualStyleBackColor = true;
            this.buttonEfectuarDevolucion.Click += new System.EventHandler(this.buttonEfectuarDevolucion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxEmpresa);
            this.groupBox2.Controls.Add(this.textBoxNroFactura);
            this.groupBox2.Controls.Add(this.labelNroFactura);
            this.groupBox2.Controls.Add(this.labelEmpresa);
            this.groupBox2.Controls.Add(this.textBoxDni);
            this.groupBox2.Controls.Add(this.labelDni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 66);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar facturas";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(273, 28);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(149, 23);
            this.comboBoxEmpresa.TabIndex = 7;
            this.comboBoxEmpresa.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmpresa_SelectionChangeCommitted);
            // 
            // textBoxNroFactura
            // 
            this.textBoxNroFactura.Location = new System.Drawing.Point(516, 28);
            this.textBoxNroFactura.Name = "textBoxNroFactura";
            this.textBoxNroFactura.Size = new System.Drawing.Size(149, 21);
            this.textBoxNroFactura.TabIndex = 6;
            this.textBoxNroFactura.TextChanged += new System.EventHandler(this.textBoxNroFactura_TextChanged);
            // 
            // labelNroFactura
            // 
            this.labelNroFactura.AutoSize = true;
            this.labelNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroFactura.Location = new System.Drawing.Point(428, 29);
            this.labelNroFactura.Name = "labelNroFactura";
            this.labelNroFactura.Size = new System.Drawing.Size(82, 15);
            this.labelNroFactura.TabIndex = 5;
            this.labelNroFactura.Text = "Nro Factura";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(203, 28);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(64, 15);
            this.labelEmpresa.TabIndex = 3;
            this.labelEmpresa.Text = "Empresa";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(48, 26);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(149, 21);
            this.textBoxDni.TabIndex = 2;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(11, 29);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(31, 15);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewBuscarFactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 294);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de facturas";
            // 
            // dataGridViewBuscarFactura
            // 
            this.dataGridViewBuscarFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarFactura.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewBuscarFactura.Name = "dataGridViewBuscarFactura";
            this.dataGridViewBuscarFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarFactura.Size = new System.Drawing.Size(1033, 258);
            this.dataGridViewBuscarFactura.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxMotivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(698, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 65);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivo";
            // 
            // textBoxMotivo
            // 
            this.textBoxMotivo.Location = new System.Drawing.Point(9, 17);
            this.textBoxMotivo.Multiline = true;
            this.textBoxMotivo.Name = "textBoxMotivo";
            this.textBoxMotivo.Size = new System.Drawing.Size(350, 41);
            this.textBoxMotivo.TabIndex = 15;
            // 
            // DevolverRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1091, 462);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonEfectuarDevolucion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DevolverRendicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Rendicion";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarFactura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonEfectuarDevolucion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.TextBox textBoxNroFactura;
        private System.Windows.Forms.Label labelNroFactura;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewBuscarFactura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMotivo;
    }
}