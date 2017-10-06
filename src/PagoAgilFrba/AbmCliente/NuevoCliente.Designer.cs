namespace PagoAgilFrba.AbmCliente
{
    partial class NuevoCliente
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodPostal = new System.Windows.Forms.TextBox();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.textBoxDpto = new System.Windows.Forms.TextBox();
            this.labelDpto = new System.Windows.Forms.Label();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.labelPiso = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.buttonCrear);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.dateTimePickerFecha);
            this.groupBox1.Controls.Add(this.textBoxCodPostal);
            this.groupBox1.Controls.Add(this.labelCodPostal);
            this.groupBox1.Controls.Add(this.textBoxLocalidad);
            this.groupBox1.Controls.Add(this.labelLocalidad);
            this.groupBox1.Controls.Add(this.textBoxDpto);
            this.groupBox1.Controls.Add(this.labelDpto);
            this.groupBox1.Controls.Add(this.textBoxPiso);
            this.groupBox1.Controls.Add(this.labelPiso);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.textBoxDni);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(139, 168);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(97, 29);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(17, 168);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(97, 29);
            this.buttonCrear.TabIndex = 29;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(343, 168);
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
            this.labelEstado.Location = new System.Drawing.Point(286, 167);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(51, 15);
            this.labelEstado.TabIndex = 27;
            this.labelEstado.Text = "Estado";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(242, 136);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(95, 15);
            this.labelFecha.TabIndex = 26;
            this.labelFecha.Text = "Fecha de Nac";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(343, 133);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(149, 21);
            this.dateTimePickerFecha.TabIndex = 25;
            // 
            // textBoxCodPostal
            // 
            this.textBoxCodPostal.Location = new System.Drawing.Point(343, 107);
            this.textBoxCodPostal.Name = "textBoxCodPostal";
            this.textBoxCodPostal.Size = new System.Drawing.Size(149, 21);
            this.textBoxCodPostal.TabIndex = 24;
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodPostal.Location = new System.Drawing.Point(261, 109);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(76, 15);
            this.labelCodPostal.TabIndex = 23;
            this.labelCodPostal.Text = "Cod Postal";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(343, 80);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(149, 21);
            this.textBoxLocalidad.TabIndex = 22;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalidad.Location = new System.Drawing.Point(267, 82);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(70, 15);
            this.labelLocalidad.TabIndex = 21;
            this.labelLocalidad.Text = "Localidad";
            // 
            // textBoxDpto
            // 
            this.textBoxDpto.Location = new System.Drawing.Point(456, 53);
            this.textBoxDpto.Name = "textBoxDpto";
            this.textBoxDpto.Size = new System.Drawing.Size(36, 21);
            this.textBoxDpto.TabIndex = 20;
            // 
            // labelDpto
            // 
            this.labelDpto.AutoSize = true;
            this.labelDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDpto.Location = new System.Drawing.Point(406, 55);
            this.labelDpto.Name = "labelDpto";
            this.labelDpto.Size = new System.Drawing.Size(37, 15);
            this.labelDpto.TabIndex = 19;
            this.labelDpto.Text = "Dpto";
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.Location = new System.Drawing.Point(343, 52);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(36, 21);
            this.textBoxPiso.TabIndex = 18;
            // 
            // labelPiso
            // 
            this.labelPiso.AutoSize = true;
            this.labelPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiso.Location = new System.Drawing.Point(302, 55);
            this.labelPiso.Name = "labelPiso";
            this.labelPiso.Size = new System.Drawing.Size(35, 15);
            this.labelPiso.TabIndex = 17;
            this.labelPiso.Text = "Piso";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(343, 25);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(149, 21);
            this.textBoxDireccion.TabIndex = 16;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(269, 28);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(68, 15);
            this.labelDireccion.TabIndex = 15;
            this.labelDireccion.Text = "Dirección";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(87, 133);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(149, 21);
            this.textBoxTelefono.TabIndex = 12;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(14, 133);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(63, 15);
            this.labelTelefono.TabIndex = 11;
            this.labelTelefono.Text = "Telefono";
            this.labelTelefono.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(87, 106);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(149, 21);
            this.textBoxEmail.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(27, 106);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 15);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "E-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(87, 79);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(149, 21);
            this.textBoxDni.TabIndex = 8;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(45, 79);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(31, 15);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "DNI";
            this.labelDni.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(87, 52);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(149, 21);
            this.textBoxApellido.TabIndex = 6;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(18, 53);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 15);
            this.labelApellido.TabIndex = 5;
            this.labelApellido.Text = "Apellido";
            this.labelApellido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(87, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(149, 21);
            this.textBoxNombre.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(18, 26);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(567, 238);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxPiso;
        private System.Windows.Forms.Label labelPiso;
        private System.Windows.Forms.TextBox textBoxDpto;
        private System.Windows.Forms.Label labelDpto;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox textBoxCodPostal;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}