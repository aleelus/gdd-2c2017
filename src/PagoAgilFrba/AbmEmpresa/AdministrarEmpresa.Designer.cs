namespace PagoAgilFrba.AbmEmpresa
{
    partial class AdministrarEmpresa
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
            this.buttonNuevaEmpresa = new System.Windows.Forms.Button();
            this.dataGridViewBuscarEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBoxBuscarEmpresas = new System.Windows.Forms.GroupBox();
            this.labelRubro = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelCuit = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarEmpresa)).BeginInit();
            this.groupBoxBuscarEmpresas.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(489, 364);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "<< Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // buttonModificarEliminar
            // 
            this.buttonModificarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEliminar.Location = new System.Drawing.Point(896, 21);
            this.buttonModificarEliminar.Name = "buttonModificarEliminar";
            this.buttonModificarEliminar.Size = new System.Drawing.Size(144, 52);
            this.buttonModificarEliminar.TabIndex = 13;
            this.buttonModificarEliminar.Text = "Modificar / Eliminar";
            this.buttonModificarEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevaEmpresa
            // 
            this.buttonNuevaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaEmpresa.Location = new System.Drawing.Point(725, 21);
            this.buttonNuevaEmpresa.Name = "buttonNuevaEmpresa";
            this.buttonNuevaEmpresa.Size = new System.Drawing.Size(144, 52);
            this.buttonNuevaEmpresa.TabIndex = 12;
            this.buttonNuevaEmpresa.Text = "Nueva Empresa";
            this.buttonNuevaEmpresa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuscarEmpresa
            // 
            this.dataGridViewBuscarEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarEmpresa.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewBuscarEmpresa.Name = "dataGridViewBuscarEmpresa";
            this.dataGridViewBuscarEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarEmpresa.Size = new System.Drawing.Size(1028, 274);
            this.dataGridViewBuscarEmpresa.TabIndex = 11;
            // 
            // groupBoxBuscarEmpresas
            // 
            this.groupBoxBuscarEmpresas.Controls.Add(this.comboBoxRubro);
            this.groupBoxBuscarEmpresas.Controls.Add(this.labelRubro);
            this.groupBoxBuscarEmpresas.Controls.Add(this.textBoxApellido);
            this.groupBoxBuscarEmpresas.Controls.Add(this.labelCuit);
            this.groupBoxBuscarEmpresas.Controls.Add(this.textBoxNombre);
            this.groupBoxBuscarEmpresas.Controls.Add(this.labelNombre);
            this.groupBoxBuscarEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscarEmpresas.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBuscarEmpresas.Name = "groupBoxBuscarEmpresas";
            this.groupBoxBuscarEmpresas.Size = new System.Drawing.Size(688, 66);
            this.groupBoxBuscarEmpresas.TabIndex = 10;
            this.groupBoxBuscarEmpresas.TabStop = false;
            this.groupBoxBuscarEmpresas.Text = "Buscar Empresas";
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRubro.Location = new System.Drawing.Point(459, 28);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(46, 15);
            this.labelRubro.TabIndex = 5;
            this.labelRubro.Text = "Rubro";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(287, 27);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(149, 20);
            this.textBoxApellido.TabIndex = 4;
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuit.Location = new System.Drawing.Point(249, 28);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(32, 15);
            this.labelCuit.TabIndex = 3;
            this.labelCuit.Text = "Cuit";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(149, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(15, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(512, 25);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(149, 21);
            this.comboBoxRubro.TabIndex = 6;

            // 
            // AdministrarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1056, 403);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificarEliminar);
            this.Controls.Add(this.buttonNuevaEmpresa);
            this.Controls.Add(this.dataGridViewBuscarEmpresa);
            this.Controls.Add(this.groupBoxBuscarEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarEmpresa)).EndInit();
            this.groupBoxBuscarEmpresas.ResumeLayout(false);
            this.groupBoxBuscarEmpresas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonModificarEliminar;
        private System.Windows.Forms.Button buttonNuevaEmpresa;
        private System.Windows.Forms.DataGridView dataGridViewBuscarEmpresa;
        private System.Windows.Forms.GroupBox groupBoxBuscarEmpresas;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelCuit;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxRubro;
    }
}