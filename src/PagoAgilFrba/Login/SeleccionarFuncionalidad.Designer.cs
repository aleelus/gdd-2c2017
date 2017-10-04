namespace PagoAgilFrba.Login
{
    partial class SeleccionarFuncionalidad
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
            this.dataGridViewFuncionalidades = new System.Windows.Forms.DataGridView();
            this.groupBoxFuncionalidad = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(132, 91);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click_1);
            // 
            // dataGridViewFuncionalidades
            // 
            this.dataGridViewFuncionalidades.AllowUserToAddRows = false;
            this.dataGridViewFuncionalidades.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionalidades.AllowUserToResizeColumns = false;
            this.dataGridViewFuncionalidades.AllowUserToResizeRows = false;
            this.dataGridViewFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewFuncionalidades.Location = new System.Drawing.Point(30, 46);
            this.dataGridViewFuncionalidades.MultiSelect = false;
            this.dataGridViewFuncionalidades.Name = "dataGridViewFuncionalidades";
            this.dataGridViewFuncionalidades.ReadOnly = true;
            this.dataGridViewFuncionalidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewFuncionalidades.RowHeadersVisible = false;
            this.dataGridViewFuncionalidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFuncionalidades.RowTemplate.ReadOnly = true;
            this.dataGridViewFuncionalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFuncionalidades.Size = new System.Drawing.Size(297, 10);
            this.dataGridViewFuncionalidades.TabIndex = 8;
            this.dataGridViewFuncionalidades.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFuncionalidades_CellMouseLeave);
            this.dataGridViewFuncionalidades.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFuncionalidades_CellMouseMove);
            this.dataGridViewFuncionalidades.Click += new System.EventHandler(this.dataGridViewFuncionalidades_Click);
            // 
            // groupBoxFuncionalidad
            // 
            this.groupBoxFuncionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFuncionalidad.Location = new System.Drawing.Point(13, 11);
            this.groupBoxFuncionalidad.Name = "groupBoxFuncionalidad";
            this.groupBoxFuncionalidad.Size = new System.Drawing.Size(333, 62);
            this.groupBoxFuncionalidad.TabIndex = 9;
            this.groupBoxFuncionalidad.TabStop = false;
            this.groupBoxFuncionalidad.Text = "Seleccione una funcionalidad";
            // 
            // SeleccionarFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(358, 135);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewFuncionalidades);
            this.Controls.Add(this.groupBoxFuncionalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionarFuncionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridViewFuncionalidades;
        private System.Windows.Forms.GroupBox groupBoxFuncionalidad;
    }
}