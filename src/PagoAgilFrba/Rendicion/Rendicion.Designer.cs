namespace PagoAgilFrba.Rendicion
{
    partial class Rendicion
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
            this.groupBoxListaRendiciones = new System.Windows.Forms.GroupBox();
            this.dataGridViewListaRendiciones = new System.Windows.Forms.DataGridView();
            this.groupBoxDetalleRendicion = new System.Windows.Forms.GroupBox();
            this.buttonEfectuarRendicion = new System.Windows.Forms.Button();
            this.labelImpTotal = new System.Windows.Forms.Label();
            this.labelImporteTotal = new System.Windows.Forms.Label();
            this.labelImporteComision = new System.Windows.Forms.Label();
            this.labelImpCom = new System.Windows.Forms.Label();
            this.labelCantFacRen = new System.Windows.Forms.Label();
            this.labelCantFactRend = new System.Windows.Forms.Label();
            this.dataGridViewListaFacturas = new System.Windows.Forms.DataGridView();
            this.textBoxPorcentajeComision = new System.Windows.Forms.TextBox();
            this.labelPorcCom = new System.Windows.Forms.Label();
            this.labelEmpresaNombre = new System.Windows.Forms.Label();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelFechaDeRendicion = new System.Windows.Forms.Label();
            this.labelFechaRendicion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxListaRendiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaRendiciones)).BeginInit();
            this.groupBoxDetalleRendicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListaRendiciones
            // 
            this.groupBoxListaRendiciones.Controls.Add(this.dataGridViewListaRendiciones);
            this.groupBoxListaRendiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListaRendiciones.Location = new System.Drawing.Point(12, 12);
            this.groupBoxListaRendiciones.Name = "groupBoxListaRendiciones";
            this.groupBoxListaRendiciones.Size = new System.Drawing.Size(255, 472);
            this.groupBoxListaRendiciones.TabIndex = 0;
            this.groupBoxListaRendiciones.TabStop = false;
            this.groupBoxListaRendiciones.Text = "Rendiciones";
            // 
            // dataGridViewListaRendiciones
            // 
            this.dataGridViewListaRendiciones.AllowUserToAddRows = false;
            this.dataGridViewListaRendiciones.AllowUserToDeleteRows = false;
            this.dataGridViewListaRendiciones.AllowUserToResizeColumns = false;
            this.dataGridViewListaRendiciones.AllowUserToResizeRows = false;
            this.dataGridViewListaRendiciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewListaRendiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewListaRendiciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewListaRendiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListaRendiciones.Location = new System.Drawing.Point(10, 24);
            this.dataGridViewListaRendiciones.MultiSelect = false;
            this.dataGridViewListaRendiciones.Name = "dataGridViewListaRendiciones";
            this.dataGridViewListaRendiciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewListaRendiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaRendiciones.Size = new System.Drawing.Size(232, 428);
            this.dataGridViewListaRendiciones.TabIndex = 0;
            this.dataGridViewListaRendiciones.Click += new System.EventHandler(this.dataGridViewListaRendiciones_Click);
            // 
            // groupBoxDetalleRendicion
            // 
            this.groupBoxDetalleRendicion.Controls.Add(this.buttonEfectuarRendicion);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelImpTotal);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelImporteTotal);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelImporteComision);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelImpCom);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelCantFacRen);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelCantFactRend);
            this.groupBoxDetalleRendicion.Controls.Add(this.dataGridViewListaFacturas);
            this.groupBoxDetalleRendicion.Controls.Add(this.textBoxPorcentajeComision);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelPorcCom);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelEmpresaNombre);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelEmpresa);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelFechaDeRendicion);
            this.groupBoxDetalleRendicion.Controls.Add(this.labelFechaRendicion);
            this.groupBoxDetalleRendicion.Controls.Add(this.label1);
            this.groupBoxDetalleRendicion.Controls.Add(this.label2);
            this.groupBoxDetalleRendicion.Controls.Add(this.label3);
            this.groupBoxDetalleRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetalleRendicion.Location = new System.Drawing.Point(284, 12);
            this.groupBoxDetalleRendicion.Name = "groupBoxDetalleRendicion";
            this.groupBoxDetalleRendicion.Size = new System.Drawing.Size(772, 472);
            this.groupBoxDetalleRendicion.TabIndex = 1;
            this.groupBoxDetalleRendicion.TabStop = false;
            this.groupBoxDetalleRendicion.Text = "Detalles de rendiciones";
            // 
            // buttonEfectuarRendicion
            // 
            this.buttonEfectuarRendicion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEfectuarRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEfectuarRendicion.Location = new System.Drawing.Point(293, 405);
            this.buttonEfectuarRendicion.Name = "buttonEfectuarRendicion";
            this.buttonEfectuarRendicion.Size = new System.Drawing.Size(144, 52);
            this.buttonEfectuarRendicion.TabIndex = 13;
            this.buttonEfectuarRendicion.Text = "Efectuar rendición";
            this.buttonEfectuarRendicion.UseVisualStyleBackColor = true;
            this.buttonEfectuarRendicion.Click += new System.EventHandler(this.buttonEfectuarRendicion_Click);
            // 
            // labelImpTotal
            // 
            this.labelImpTotal.AutoSize = true;
            this.labelImpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpTotal.Location = new System.Drawing.Point(617, 376);
            this.labelImpTotal.Name = "labelImpTotal";
            this.labelImpTotal.Size = new System.Drawing.Size(12, 15);
            this.labelImpTotal.TabIndex = 12;
            this.labelImpTotal.Text = "-";
            // 
            // labelImporteTotal
            // 
            this.labelImporteTotal.AutoSize = true;
            this.labelImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporteTotal.Location = new System.Drawing.Point(522, 376);
            this.labelImporteTotal.Name = "labelImporteTotal";
            this.labelImporteTotal.Size = new System.Drawing.Size(78, 15);
            this.labelImporteTotal.TabIndex = 11;
            this.labelImporteTotal.Text = "Importe total:";
            // 
            // labelImporteComision
            // 
            this.labelImporteComision.AutoSize = true;
            this.labelImporteComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporteComision.Location = new System.Drawing.Point(401, 376);
            this.labelImporteComision.Name = "labelImporteComision";
            this.labelImporteComision.Size = new System.Drawing.Size(12, 15);
            this.labelImporteComision.TabIndex = 10;
            this.labelImporteComision.Text = "-";
            // 
            // labelImpCom
            // 
            this.labelImpCom.AutoSize = true;
            this.labelImpCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpCom.Location = new System.Drawing.Point(271, 376);
            this.labelImpCom.Name = "labelImpCom";
            this.labelImpCom.Size = new System.Drawing.Size(122, 15);
            this.labelImpCom.TabIndex = 9;
            this.labelImpCom.Text = "Importe de comisión:";
            // 
            // labelCantFacRen
            // 
            this.labelCantFacRen.AutoSize = true;
            this.labelCantFacRen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantFacRen.Location = new System.Drawing.Point(207, 376);
            this.labelCantFacRen.Name = "labelCantFacRen";
            this.labelCantFacRen.Size = new System.Drawing.Size(12, 15);
            this.labelCantFacRen.TabIndex = 8;
            this.labelCantFacRen.Text = "-";
            // 
            // labelCantFactRend
            // 
            this.labelCantFactRend.AutoSize = true;
            this.labelCantFactRend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantFactRend.Location = new System.Drawing.Point(28, 376);
            this.labelCantFactRend.Name = "labelCantFactRend";
            this.labelCantFactRend.Size = new System.Drawing.Size(173, 15);
            this.labelCantFactRend.TabIndex = 7;
            this.labelCantFactRend.Text = "Cantidad de facturas rendidas:";
            // 
            // dataGridViewListaFacturas
            // 
            this.dataGridViewListaFacturas.AllowUserToResizeColumns = false;
            this.dataGridViewListaFacturas.AllowUserToResizeRows = false;
            this.dataGridViewListaFacturas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewListaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewListaFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewListaFacturas.Location = new System.Drawing.Point(16, 58);
            this.dataGridViewListaFacturas.MultiSelect = false;
            this.dataGridViewListaFacturas.Name = "dataGridViewListaFacturas";
            this.dataGridViewListaFacturas.ReadOnly = true;
            this.dataGridViewListaFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewListaFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaFacturas.Size = new System.Drawing.Size(742, 305);
            this.dataGridViewListaFacturas.TabIndex = 1;
            // 
            // textBoxPorcentajeComision
            // 
            this.textBoxPorcentajeComision.Location = new System.Drawing.Point(676, 26);
            this.textBoxPorcentajeComision.Name = "textBoxPorcentajeComision";
            this.textBoxPorcentajeComision.Size = new System.Drawing.Size(36, 23);
            this.textBoxPorcentajeComision.TabIndex = 6;
            this.textBoxPorcentajeComision.TextChanged += new System.EventHandler(this.textBoxPorcentajeComision_TextChanged);
            // 
            // labelPorcCom
            // 
            this.labelPorcCom.AutoSize = true;
            this.labelPorcCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcCom.Location = new System.Drawing.Point(522, 29);
            this.labelPorcCom.Name = "labelPorcCom";
            this.labelPorcCom.Size = new System.Drawing.Size(139, 15);
            this.labelPorcCom.TabIndex = 5;
            this.labelPorcCom.Text = "Porcentaje de comisión:";
            // 
            // labelEmpresaNombre
            // 
            this.labelEmpresaNombre.AutoSize = true;
            this.labelEmpresaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresaNombre.Location = new System.Drawing.Point(337, 29);
            this.labelEmpresaNombre.Name = "labelEmpresaNombre";
            this.labelEmpresaNombre.Size = new System.Drawing.Size(12, 15);
            this.labelEmpresaNombre.TabIndex = 4;
            this.labelEmpresaNombre.Text = "-";
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.Location = new System.Drawing.Point(271, 29);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(60, 15);
            this.labelEmpresa.TabIndex = 3;
            this.labelEmpresa.Text = "Empresa:";
            // 
            // labelFechaDeRendicion
            // 
            this.labelFechaDeRendicion.AutoSize = true;
            this.labelFechaDeRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDeRendicion.Location = new System.Drawing.Point(149, 29);
            this.labelFechaDeRendicion.Name = "labelFechaDeRendicion";
            this.labelFechaDeRendicion.Size = new System.Drawing.Size(12, 15);
            this.labelFechaDeRendicion.TabIndex = 2;
            this.labelFechaDeRendicion.Text = "-";
            // 
            // labelFechaRendicion
            // 
            this.labelFechaRendicion.AutoSize = true;
            this.labelFechaRendicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRendicion.Location = new System.Drawing.Point(28, 29);
            this.labelFechaRendicion.Name = "labelFechaRendicion";
            this.labelFechaRendicion.Size = new System.Drawing.Size(115, 15);
            this.labelFechaRendicion.TabIndex = 1;
            this.labelFechaRendicion.Text = "Fecha de rendición:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "%";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1077, 494);
            this.Controls.Add(this.groupBoxDetalleRendicion);
            this.Controls.Add(this.groupBoxListaRendiciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rendicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendiciones de Facturas";
            this.groupBoxListaRendiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaRendiciones)).EndInit();
            this.groupBoxDetalleRendicion.ResumeLayout(false);
            this.groupBoxDetalleRendicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListaRendiciones;
        private System.Windows.Forms.DataGridView dataGridViewListaRendiciones;
        private System.Windows.Forms.GroupBox groupBoxDetalleRendicion;
        private System.Windows.Forms.Label labelFechaRendicion;
        private System.Windows.Forms.Label labelFechaDeRendicion;
        private System.Windows.Forms.Label labelEmpresaNombre;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelPorcCom;
        private System.Windows.Forms.TextBox textBoxPorcentajeComision;
        private System.Windows.Forms.Label labelCantFactRend;
        private System.Windows.Forms.DataGridView dataGridViewListaFacturas;
        private System.Windows.Forms.Label labelCantFacRen;
        private System.Windows.Forms.Label labelImpCom;
        private System.Windows.Forms.Label labelImporteComision;
        private System.Windows.Forms.Label labelImpTotal;
        private System.Windows.Forms.Label labelImporteTotal;
        private System.Windows.Forms.Button buttonEfectuarRendicion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}