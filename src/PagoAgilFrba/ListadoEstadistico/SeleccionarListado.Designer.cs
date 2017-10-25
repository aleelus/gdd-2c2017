namespace PagoAgilFrba.ListadoEstadistico
{
    partial class SeleccionarListado
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
            this.labelAnio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAnio = new System.Windows.Forms.TextBox();
            this.labelTrimestre = new System.Windows.Forms.Label();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.labelTipoListado = new System.Windows.Forms.Label();
            this.comboBoxTipoListado = new System.Windows.Forms.ComboBox();
            this.buttonGenerarListado = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnio.Location = new System.Drawing.Point(15, 31);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(110, 15);
            this.labelAnio.TabIndex = 1;
            this.labelAnio.Text = "Año a consultar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTipoListado);
            this.groupBox1.Controls.Add(this.labelTipoListado);
            this.groupBox1.Controls.Add(this.comboBoxTrimestre);
            this.groupBox1.Controls.Add(this.labelTrimestre);
            this.groupBox1.Controls.Add(this.textBoxAnio);
            this.groupBox1.Controls.Add(this.labelAnio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del listado";
            // 
            // textBoxAnio
            // 
            this.textBoxAnio.Location = new System.Drawing.Point(131, 28);
            this.textBoxAnio.Name = "textBoxAnio";
            this.textBoxAnio.Size = new System.Drawing.Size(95, 21);
            this.textBoxAnio.TabIndex = 2;
            this.textBoxAnio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTrimestre
            // 
            this.labelTrimestre.AutoSize = true;
            this.labelTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrimestre.Location = new System.Drawing.Point(53, 65);
            this.labelTrimestre.Name = "labelTrimestre";
            this.labelTrimestre.Size = new System.Drawing.Size(72, 15);
            this.labelTrimestre.TabIndex = 3;
            this.labelTrimestre.Text = "Trimestre:";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Location = new System.Drawing.Point(131, 62);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(182, 23);
            this.comboBoxTrimestre.TabIndex = 4;
            this.comboBoxTrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrimestre_SelectedIndexChanged);
            // 
            // labelTipoListado
            // 
            this.labelTipoListado.AutoSize = true;
            this.labelTipoListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoListado.Location = new System.Drawing.Point(19, 99);
            this.labelTipoListado.Name = "labelTipoListado";
            this.labelTipoListado.Size = new System.Drawing.Size(106, 15);
            this.labelTipoListado.TabIndex = 5;
            this.labelTipoListado.Text = "Tipo de listado:";
            // 
            // comboBoxTipoListado
            // 
            this.comboBoxTipoListado.FormattingEnabled = true;
            this.comboBoxTipoListado.Location = new System.Drawing.Point(131, 96);
            this.comboBoxTipoListado.Name = "comboBoxTipoListado";
            this.comboBoxTipoListado.Size = new System.Drawing.Size(294, 23);
            this.comboBoxTipoListado.TabIndex = 6;
            this.comboBoxTipoListado.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoListado_SelectedIndexChanged);
            // 
            // buttonGenerarListado
            // 
            this.buttonGenerarListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarListado.Location = new System.Drawing.Point(126, 154);
            this.buttonGenerarListado.Name = "buttonGenerarListado";
            this.buttonGenerarListado.Size = new System.Drawing.Size(97, 41);
            this.buttonGenerarListado.TabIndex = 33;
            this.buttonGenerarListado.Text = "Generar listado";
            this.buttonGenerarListado.UseVisualStyleBackColor = true;
            this.buttonGenerarListado.Click += new System.EventHandler(this.buttonGenerarListado_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(242, 154);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 41);
            this.buttonVolver.TabIndex = 34;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SeleccionarListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(468, 207);
            this.Controls.Add(this.buttonGenerarListado);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionarListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de listado estadístico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTrimestre;
        private System.Windows.Forms.TextBox textBoxAnio;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label labelTipoListado;
        private System.Windows.Forms.ComboBox comboBoxTipoListado;
        private System.Windows.Forms.Button buttonGenerarListado;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}