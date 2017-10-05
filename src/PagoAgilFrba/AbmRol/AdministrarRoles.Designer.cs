namespace PagoAgilFrba.AbmRol
{
    partial class AdministrarRoles
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
            this.labelSeleccionarRol = new System.Windows.Forms.Label();
            this.comboBoxSeleccionarRol = new System.Windows.Forms.ComboBox();
            this.labelEstadoDelRol = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.buttonNuevoRol = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.checkedListBoxFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeleccionarRol
            // 
            this.labelSeleccionarRol.AutoSize = true;
            this.labelSeleccionarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionarRol.Location = new System.Drawing.Point(12, 19);
            this.labelSeleccionarRol.Name = "labelSeleccionarRol";
            this.labelSeleccionarRol.Size = new System.Drawing.Size(109, 15);
            this.labelSeleccionarRol.TabIndex = 0;
            this.labelSeleccionarRol.Text = "Seleccionar Rol";
            // 
            // comboBoxSeleccionarRol
            // 
            this.comboBoxSeleccionarRol.FormattingEnabled = true;
            this.comboBoxSeleccionarRol.Location = new System.Drawing.Point(138, 18);
            this.comboBoxSeleccionarRol.Name = "comboBoxSeleccionarRol";
            this.comboBoxSeleccionarRol.Size = new System.Drawing.Size(231, 21);
            this.comboBoxSeleccionarRol.TabIndex = 1;
            this.comboBoxSeleccionarRol.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSeleccionarRol_SelectionChangeCommitted);
            // 
            // labelEstadoDelRol
            // 
            this.labelEstadoDelRol.AutoSize = true;
            this.labelEstadoDelRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoDelRol.Location = new System.Drawing.Point(20, 58);
            this.labelEstadoDelRol.Name = "labelEstadoDelRol";
            this.labelEstadoDelRol.Size = new System.Drawing.Size(101, 15);
            this.labelEstadoDelRol.TabIndex = 2;
            this.labelEstadoDelRol.Text = "Estado del Rol";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(138, 59);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstado.TabIndex = 3;
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // buttonNuevoRol
            // 
            this.buttonNuevoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoRol.Location = new System.Drawing.Point(15, 96);
            this.buttonNuevoRol.Name = "buttonNuevoRol";
            this.buttonNuevoRol.Size = new System.Drawing.Size(97, 29);
            this.buttonNuevoRol.TabIndex = 6;
            this.buttonNuevoRol.Text = "Nuevo Rol";
            this.buttonNuevoRol.UseVisualStyleBackColor = true;
            this.buttonNuevoRol.Click += new System.EventHandler(this.buttonNuevoRol_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(15, 131);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(97, 29);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(15, 221);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "<< Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxFuncionalidades
            // 
            this.checkedListBoxFuncionalidades.FormattingEnabled = true;
            this.checkedListBoxFuncionalidades.Location = new System.Drawing.Point(138, 96);
            this.checkedListBoxFuncionalidades.Name = "checkedListBoxFuncionalidades";
            this.checkedListBoxFuncionalidades.Size = new System.Drawing.Size(231, 154);
            this.checkedListBoxFuncionalidades.TabIndex = 9;
            this.checkedListBoxFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFuncionalidades_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdministrarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(391, 262);
            this.Controls.Add(this.checkedListBoxFuncionalidades);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevoRol);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.labelEstadoDelRol);
            this.Controls.Add(this.comboBoxSeleccionarRol);
            this.Controls.Add(this.labelSeleccionarRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdministrarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministrarRoles_FormClosing);
            this.Load += new System.EventHandler(this.AdministrarRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccionarRol;
        private System.Windows.Forms.ComboBox comboBoxSeleccionarRol;
        private System.Windows.Forms.Label labelEstadoDelRol;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button buttonNuevoRol;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.CheckedListBox checkedListBoxFuncionalidades;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        
    }
}