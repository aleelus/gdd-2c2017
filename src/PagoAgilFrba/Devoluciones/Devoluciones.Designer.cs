namespace PagoAgilFrba.Devoluciones
{
    partial class Devoluciones
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
            this.buttonDevolverFacturas = new System.Windows.Forms.Button();
            this.buttonDevolverRendiciones = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDevolverFacturas
            // 
            this.buttonDevolverFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolverFacturas.Location = new System.Drawing.Point(16, 19);
            this.buttonDevolverFacturas.Name = "buttonDevolverFacturas";
            this.buttonDevolverFacturas.Size = new System.Drawing.Size(140, 71);
            this.buttonDevolverFacturas.TabIndex = 8;
            this.buttonDevolverFacturas.Text = "Devolver FACTURAS";
            this.buttonDevolverFacturas.UseVisualStyleBackColor = true;
            this.buttonDevolverFacturas.Click += new System.EventHandler(this.buttonDevolverFacturas_Click);
            // 
            // buttonDevolverRendiciones
            // 
            this.buttonDevolverRendiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevolverRendiciones.Location = new System.Drawing.Point(172, 19);
            this.buttonDevolverRendiciones.Name = "buttonDevolverRendiciones";
            this.buttonDevolverRendiciones.Size = new System.Drawing.Size(140, 71);
            this.buttonDevolverRendiciones.TabIndex = 9;
            this.buttonDevolverRendiciones.Text = "Devolver RENDICIONES";
            this.buttonDevolverRendiciones.UseVisualStyleBackColor = true;
            this.buttonDevolverRendiciones.Click += new System.EventHandler(this.buttonDevolverRendiciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDevolverRendiciones);
            this.groupBox1.Controls.Add(this.buttonDevolverFacturas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devoluciones";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolver.Location = new System.Drawing.Point(129, 120);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(97, 29);
            this.buttonVolver.TabIndex = 11;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(362, 161);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Devoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDevolverFacturas;
        private System.Windows.Forms.Button buttonDevolverRendiciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonVolver;
    }
}