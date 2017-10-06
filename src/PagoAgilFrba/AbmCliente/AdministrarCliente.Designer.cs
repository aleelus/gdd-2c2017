namespace PagoAgilFrba.AbmCliente
{
    partial class AdministrarCliente
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewBuscarCliente = new System.Windows.Forms.DataGridView();
            this.buttonNuevoCliente = new System.Windows.Forms.Button();
            this.buttonModificarEliminar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDni);
            this.groupBox1.Controls.Add(this.labelDni);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Clientes";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(511, 27);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(149, 20);
            this.textBoxDni.TabIndex = 6;
            this.textBoxDni.TextChanged += new System.EventHandler(this.textBoxDni_TextChanged);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(474, 28);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(31, 15);
            this.labelDni.TabIndex = 5;
            this.labelDni.Text = "DNI";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(310, 27);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(149, 20);
            this.textBoxApellido.TabIndex = 4;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(245, 28);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(59, 15);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(149, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // dataGridViewBuscarCliente
            // 
            this.dataGridViewBuscarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarCliente.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewBuscarCliente.Name = "dataGridViewBuscarCliente";
            this.dataGridViewBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarCliente.Size = new System.Drawing.Size(1028, 274);
            this.dataGridViewBuscarCliente.TabIndex = 2;
            // 
            // buttonNuevoCliente
            // 
            this.buttonNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoCliente.Location = new System.Drawing.Point(725, 21);
            this.buttonNuevoCliente.Name = "buttonNuevoCliente";
            this.buttonNuevoCliente.Size = new System.Drawing.Size(144, 52);
            this.buttonNuevoCliente.TabIndex = 7;
            this.buttonNuevoCliente.Text = "Nuevo Cliente";
            this.buttonNuevoCliente.UseVisualStyleBackColor = true;
            this.buttonNuevoCliente.Click += new System.EventHandler(this.buttonNuevoCliente_Click);
            // 
            // buttonModificarEliminar
            // 
            this.buttonModificarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarEliminar.Location = new System.Drawing.Point(896, 21);
            this.buttonModificarEliminar.Name = "buttonModificarEliminar";
            this.buttonModificarEliminar.Size = new System.Drawing.Size(144, 52);
            this.buttonModificarEliminar.TabIndex = 8;
            this.buttonModificarEliminar.Text = "Modificar / Eliminar";
            this.buttonModificarEliminar.UseVisualStyleBackColor = true;
            this.buttonModificarEliminar.Click += new System.EventHandler(this.buttonModificarEliminar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(489, 364);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 9;
            this.buttonVolver.Text = "<< Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdministrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1061, 418);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificarEliminar);
            this.Controls.Add(this.buttonNuevoCliente);
            this.Controls.Add(this.dataGridViewBuscarCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.DataGridView dataGridViewBuscarCliente;
        private System.Windows.Forms.Button buttonNuevoCliente;
        private System.Windows.Forms.Button buttonModificarEliminar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}