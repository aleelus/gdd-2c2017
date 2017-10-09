namespace PagoAgilFrba.AbmSucursal
{
    partial class AdministrarSucursal
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
            this.buttonNuevaSucursal = new System.Windows.Forms.Button();
            this.dataGridViewBuscarSucursal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarSucursal)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
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
            this.buttonModificarEliminar.Click += new System.EventHandler(this.buttonModificarEliminar_Click);
            // 
            // buttonNuevaSucursal
            // 
            this.buttonNuevaSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaSucursal.Location = new System.Drawing.Point(725, 21);
            this.buttonNuevaSucursal.Name = "buttonNuevaSucursal";
            this.buttonNuevaSucursal.Size = new System.Drawing.Size(144, 52);
            this.buttonNuevaSucursal.TabIndex = 12;
            this.buttonNuevaSucursal.Text = "Nueva Sucursal";
            this.buttonNuevaSucursal.UseVisualStyleBackColor = true;
            this.buttonNuevaSucursal.Click += new System.EventHandler(this.buttonNuevaSucursal_Click);
            // 
            // dataGridViewBuscarSucursal
            // 
            this.dataGridViewBuscarSucursal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuscarSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarSucursal.Location = new System.Drawing.Point(12, 84);
            this.dataGridViewBuscarSucursal.Name = "dataGridViewBuscarSucursal";
            this.dataGridViewBuscarSucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarSucursal.Size = new System.Drawing.Size(1028, 274);
            this.dataGridViewBuscarSucursal.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCodigoPostal);
            this.groupBox1.Controls.Add(this.labelCodigoPostal);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.labelDireccion);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Sucursales";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(536, 27);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(149, 20);
            this.textBoxCodigoPostal.TabIndex = 6;
            this.textBoxCodigoPostal.TextChanged += new System.EventHandler(this.textBoxCodigoPostal_TextChanged);
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoPostal.Location = new System.Drawing.Point(454, 28);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(76, 15);
            this.labelCodigoPostal.TabIndex = 5;
            this.labelCodigoPostal.Text = "Cod Postal";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(299, 27);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(149, 20);
            this.textBoxDireccion.TabIndex = 4;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(225, 28);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(68, 15);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(70, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(149, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(6, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 15);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // AdministrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1055, 403);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonModificarEliminar);
            this.Controls.Add(this.buttonNuevaSucursal);
            this.Controls.Add(this.dataGridViewBuscarSucursal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdministrarSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarSucursal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonModificarEliminar;
        private System.Windows.Forms.Button buttonNuevaSucursal;
        private System.Windows.Forms.DataGridView dataGridViewBuscarSucursal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCodigoPostal;
        private System.Windows.Forms.Label labelCodigoPostal;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
    }
}