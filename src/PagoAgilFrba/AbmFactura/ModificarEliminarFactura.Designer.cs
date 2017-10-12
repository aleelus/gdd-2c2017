namespace PagoAgilFrba.AbmFactura
{
    partial class ModificarEliminarFactura
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonSacarItem = new System.Windows.Forms.Button();
            this.buttonAgregarItem = new System.Windows.Forms.Button();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePickerFechaVto = new System.Windows.Forms.DateTimePicker();
            this.labelFechaAlta = new System.Windows.Forms.Label();
            this.dateTimePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxNroFactura = new System.Windows.Forms.TextBox();
            this.labelNroFactura = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewItems);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.buttonSacarItem);
            this.groupBox1.Controls.Add(this.buttonAgregarItem);
            this.groupBox1.Controls.Add(this.labelItems);
            this.groupBox1.Controls.Add(this.labelFechaVencimiento);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaVto);
            this.groupBox1.Controls.Add(this.labelFechaAlta);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaAlta);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.labelEmpresa);
            this.groupBox1.Controls.Add(this.textBoxNroFactura);
            this.groupBox1.Controls.Add(this.labelNroFactura);
            this.groupBox1.Controls.Add(this.textBoxDni);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 208);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Factura";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(386, 25);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(351, 131);
            this.dataGridViewItems.TabIndex = 43;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(386, 164);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(149, 21);
            this.textBoxTotal.TabIndex = 41;
            // 
            // buttonSacarItem
            // 
            this.buttonSacarItem.Location = new System.Drawing.Point(352, 76);
            this.buttonSacarItem.Name = "buttonSacarItem";
            this.buttonSacarItem.Size = new System.Drawing.Size(20, 23);
            this.buttonSacarItem.TabIndex = 39;
            this.buttonSacarItem.Text = "-";
            this.buttonSacarItem.UseVisualStyleBackColor = true;
            this.buttonSacarItem.Click += new System.EventHandler(this.buttonSacarItem_Click);
            // 
            // buttonAgregarItem
            // 
            this.buttonAgregarItem.Location = new System.Drawing.Point(352, 47);
            this.buttonAgregarItem.Name = "buttonAgregarItem";
            this.buttonAgregarItem.Size = new System.Drawing.Size(20, 23);
            this.buttonAgregarItem.TabIndex = 38;
            this.buttonAgregarItem.Text = "+";
            this.buttonAgregarItem.UseVisualStyleBackColor = true;
            this.buttonAgregarItem.Click += new System.EventHandler(this.buttonAgregarItem_Click);
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.Location = new System.Drawing.Point(330, 25);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(42, 15);
            this.labelItems.TabIndex = 36;
            this.labelItems.Text = "Items";
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVencimiento.Location = new System.Drawing.Point(35, 140);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(127, 15);
            this.labelFechaVencimiento.TabIndex = 35;
            this.labelFechaVencimiento.Text = "Fecha vencimiento";
            // 
            // dateTimePickerFechaVto
            // 
            this.dateTimePickerFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaVto.Location = new System.Drawing.Point(168, 135);
            this.dateTimePickerFechaVto.Name = "dateTimePickerFechaVto";
            this.dateTimePickerFechaVto.Size = new System.Drawing.Size(149, 21);
            this.dateTimePickerFechaVto.TabIndex = 34;
            // 
            // labelFechaAlta
            // 
            this.labelFechaAlta.AutoSize = true;
            this.labelFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaAlta.Location = new System.Drawing.Point(20, 113);
            this.labelFechaAlta.Name = "labelFechaAlta";
            this.labelFechaAlta.Size = new System.Drawing.Size(142, 15);
            this.labelFechaAlta.TabIndex = 33;
            this.labelFechaAlta.Text = "Fecha alta de factura";
            // 
            // dateTimePickerFechaAlta
            // 
            this.dateTimePickerFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaAlta.Location = new System.Drawing.Point(168, 108);
            this.dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
            this.dateTimePickerFechaAlta.Size = new System.Drawing.Size(149, 21);
            this.dateTimePickerFechaAlta.TabIndex = 32;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(168, 52);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(149, 23);
            this.comboBoxEmpresa.TabIndex = 31;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(168, 167);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstado.TabIndex = 28;
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(111, 166);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(51, 15);
            this.labelEstado.TabIndex = 27;
            this.labelEstado.Text = "Estado";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(98, 55);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(64, 15);
            this.labelEmpresa.TabIndex = 7;
            this.labelEmpresa.Text = "Empresa";
            this.labelEmpresa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNroFactura
            // 
            this.textBoxNroFactura.Location = new System.Drawing.Point(168, 81);
            this.textBoxNroFactura.Name = "textBoxNroFactura";
            this.textBoxNroFactura.Size = new System.Drawing.Size(149, 21);
            this.textBoxNroFactura.TabIndex = 6;
            // 
            // labelNroFactura
            // 
            this.labelNroFactura.AutoSize = true;
            this.labelNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroFactura.Location = new System.Drawing.Point(80, 84);
            this.labelNroFactura.Name = "labelNroFactura";
            this.labelNroFactura.Size = new System.Drawing.Size(82, 15);
            this.labelNroFactura.TabIndex = 5;
            this.labelNroFactura.Text = "Nro Factura";
            this.labelNroFactura.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(168, 25);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(149, 21);
            this.textBoxDni.TabIndex = 4;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(62, 28);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(100, 15);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "Dni del cliente";
            this.labelDni.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "$";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(333, 166);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(39, 15);
            this.labelTotal.TabIndex = 40;
            this.labelTotal.Text = "Total";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(386, 226);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(97, 29);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(271, 226);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(97, 29);
            this.buttonGuardar.TabIndex = 32;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificarEliminarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(778, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarEliminarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar / Eliminar Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonSacarItem;
        private System.Windows.Forms.Button buttonAgregarItem;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVto;
        private System.Windows.Forms.Label labelFechaAlta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAlta;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox textBoxNroFactura;
        private System.Windows.Forms.Label labelNroFactura;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}