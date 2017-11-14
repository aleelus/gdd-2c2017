namespace PagoAgilFrba.RegistroPago
{
    partial class RegistrarPago
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
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.comboBoxNroFactura = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCobro = new System.Windows.Forms.DateTimePicker();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxSucursal = new System.Windows.Forms.TextBox();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelVto = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.dateTimePickerVto = new System.Windows.Forms.DateTimePicker();
            this.labelCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNroFactura = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistrarPago = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewListaFacturas = new System.Windows.Forms.DataGridView();
            this.EmpresaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaFacturas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFormaPago);
            this.groupBox1.Controls.Add(this.labelFormaPago);
            this.groupBox1.Controls.Add(this.comboBoxNroFactura);
            this.groupBox1.Controls.Add(this.dateTimePickerCobro);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.textBoxSucursal);
            this.groupBox1.Controls.Add(this.labelSucursal);
            this.groupBox1.Controls.Add(this.textBoxImporte);
            this.groupBox1.Controls.Add(this.labelImporte);
            this.groupBox1.Controls.Add(this.labelVto);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.dateTimePickerVto);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNroFactura);
            this.groupBox1.Controls.Add(this.comboBoxEmpresa);
            this.groupBox1.Controls.Add(this.labelEmpresa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 146);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Factura a Pagar";
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(398, 62);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(149, 23);
            this.comboBoxFormaPago.TabIndex = 54;
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaPago.Location = new System.Drawing.Point(288, 65);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(104, 15);
            this.labelFormaPago.TabIndex = 53;
            this.labelFormaPago.Text = "Forma de pago";
            this.labelFormaPago.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxNroFactura
            // 
            this.comboBoxNroFactura.FormattingEnabled = true;
            this.comboBoxNroFactura.Location = new System.Drawing.Point(121, 91);
            this.comboBoxNroFactura.Name = "comboBoxNroFactura";
            this.comboBoxNroFactura.Size = new System.Drawing.Size(149, 23);
            this.comboBoxNroFactura.TabIndex = 52;
            this.comboBoxNroFactura.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNroFactura_SelectionChangeCommitted);
            // 
            // dateTimePickerCobro
            // 
            this.dateTimePickerCobro.Enabled = false;
            this.dateTimePickerCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCobro.Location = new System.Drawing.Point(398, 93);
            this.dateTimePickerCobro.Name = "dateTimePickerCobro";
            this.dateTimePickerCobro.Size = new System.Drawing.Size(149, 21);
            this.dateTimePickerCobro.TabIndex = 51;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(634, 91);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(149, 36);
            this.buttonAgregar.TabIndex = 43;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxSucursal
            // 
            this.textBoxSucursal.Enabled = false;
            this.textBoxSucursal.Location = new System.Drawing.Point(634, 62);
            this.textBoxSucursal.Name = "textBoxSucursal";
            this.textBoxSucursal.Size = new System.Drawing.Size(149, 21);
            this.textBoxSucursal.TabIndex = 50;
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucursal.Location = new System.Drawing.Point(565, 64);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(63, 15);
            this.labelSucursal.TabIndex = 49;
            this.labelSucursal.Text = "Sucursal";
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Enabled = false;
            this.textBoxImporte.Location = new System.Drawing.Point(634, 33);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.Size = new System.Drawing.Size(149, 21);
            this.textBoxImporte.TabIndex = 48;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.Location = new System.Drawing.Point(569, 35);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(56, 15);
            this.labelImporte.TabIndex = 47;
            this.labelImporte.Text = "Importe";
            // 
            // labelVto
            // 
            this.labelVto.AutoSize = true;
            this.labelVto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVto.Location = new System.Drawing.Point(322, 36);
            this.labelVto.Name = "labelVto";
            this.labelVto.Size = new System.Drawing.Size(70, 15);
            this.labelVto.TabIndex = 44;
            this.labelVto.Text = "Fecha Vto";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(121, 62);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(149, 23);
            this.comboBoxCliente.TabIndex = 46;
            this.comboBoxCliente.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCliente_SelectionChangeCommitted);
            // 
            // dateTimePickerVto
            // 
            this.dateTimePickerVto.Enabled = false;
            this.dateTimePickerVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVto.Location = new System.Drawing.Point(398, 33);
            this.dateTimePickerVto.Name = "dateTimePickerVto";
            this.dateTimePickerVto.Size = new System.Drawing.Size(149, 21);
            this.dateTimePickerVto.TabIndex = 43;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(63, 65);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(52, 15);
            this.labelCliente.TabIndex = 45;
            this.labelCliente.Text = "Cliente";
            this.labelCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Fecha de cobro";
            // 
            // labelNroFactura
            // 
            this.labelNroFactura.AutoSize = true;
            this.labelNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroFactura.Location = new System.Drawing.Point(33, 94);
            this.labelNroFactura.Name = "labelNroFactura";
            this.labelNroFactura.Size = new System.Drawing.Size(82, 15);
            this.labelNroFactura.TabIndex = 5;
            this.labelNroFactura.Text = "Nro Factura";
            this.labelNroFactura.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(121, 33);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(149, 23);
            this.comboBoxEmpresa.TabIndex = 31;
            this.comboBoxEmpresa.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmpresa_SelectionChangeCommitted);
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(51, 36);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(64, 15);
            this.labelEmpresa.TabIndex = 7;
            this.labelEmpresa.Text = "Empresa";
            this.labelEmpresa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(623, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "$";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(442, 356);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(147, 45);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRegistrarPago
            // 
            this.buttonRegistrarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarPago.Location = new System.Drawing.Point(275, 356);
            this.buttonRegistrarPago.Name = "buttonRegistrarPago";
            this.buttonRegistrarPago.Size = new System.Drawing.Size(149, 45);
            this.buttonRegistrarPago.TabIndex = 32;
            this.buttonRegistrarPago.Text = "Registrar Pago de Factura/s";
            this.buttonRegistrarPago.UseVisualStyleBackColor = true;
            this.buttonRegistrarPago.Click += new System.EventHandler(this.buttonRegistrarPago_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewListaFacturas
            // 
            this.dataGridViewListaFacturas.AllowUserToAddRows = false;
            this.dataGridViewListaFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewListaFacturas.AllowUserToResizeColumns = false;
            this.dataGridViewListaFacturas.AllowUserToResizeRows = false;
            this.dataGridViewListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpresaId,
            this.ClienteId,
            this.Datos,
            this.Empresa,
            this.NroFactura,
            this.Importe,
            this.FormaPago,
            this.FechaVto});
            this.dataGridViewListaFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListaFacturas.Location = new System.Drawing.Point(17, 19);
            this.dataGridViewListaFacturas.Name = "dataGridViewListaFacturas";
            this.dataGridViewListaFacturas.ReadOnly = true;
            this.dataGridViewListaFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaFacturas.Size = new System.Drawing.Size(781, 126);
            this.dataGridViewListaFacturas.TabIndex = 34;
            // 
            // EmpresaId
            // 
            this.EmpresaId.HeaderText = "EmpresaId";
            this.EmpresaId.Name = "EmpresaId";
            this.EmpresaId.ReadOnly = true;
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Datos";
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "Nro Factura";
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // FormaPago
            // 
            this.FormaPago.HeaderText = "Forma de Pago";
            this.FormaPago.Name = "FormaPago";
            this.FormaPago.ReadOnly = true;
            // 
            // FechaVto
            // 
            this.FechaVto.HeaderText = "Fecha Vto";
            this.FechaVto.Name = "FechaVto";
            this.FechaVto.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLimpiar);
            this.groupBox2.Controls.Add(this.dataGridViewListaFacturas);
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 183);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Facturas a Pagar";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(368, 148);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(97, 29);
            this.buttonLimpiar.TabIndex = 51;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // RegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(837, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrarPago);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrarPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaFacturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelNroFactura;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegistrarPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label labelVto;
        private System.Windows.Forms.DateTimePicker dateTimePickerVto;
        private System.Windows.Forms.TextBox textBoxSucursal;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridViewListaFacturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DateTimePicker dateTimePickerCobro;
        private System.Windows.Forms.ComboBox comboBoxNroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVto;
    }
}