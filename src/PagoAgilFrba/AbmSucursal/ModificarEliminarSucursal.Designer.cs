namespace PagoAgilFrba.AbmSucursal
{
    partial class ModificarEliminarSucursal
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(301, 105);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 33;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.labelEstado);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.textBoxCodigoPostal);
            this.groupBox1.Controls.Add(this.labelCodigoPostal);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 84);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Sucursal";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(343, 59);
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
            this.labelEstado.Location = new System.Drawing.Point(286, 58);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(51, 15);
            this.labelEstado.TabIndex = 27;
            this.labelEstado.Text = "Estado";
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
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(87, 52);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(149, 21);
            this.textBoxCodigoPostal.TabIndex = 6;
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoPostal.Location = new System.Drawing.Point(5, 52);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(76, 15);
            this.labelCodigoPostal.TabIndex = 5;
            this.labelCodigoPostal.Text = "Cod Postal";
            this.labelCodigoPostal.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.labelNombre.Location = new System.Drawing.Point(23, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 15);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(161, 105);
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
            // ModificarEliminarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(564, 143);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarEliminarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar / Eliminar Sucursal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}