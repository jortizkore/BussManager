namespace BussManager.Inventario.Accesorios
{
    partial class frmCompraAccesorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompraAccesorio = new System.Windows.Forms.TextBox();
            this.numCostoAccesorio = new System.Windows.Forms.NumericUpDown();
            this.numPrecioAccesorio = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCapitalInventario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCantidadInventario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertarAccesorios = new System.Windows.Forms.Button();
            this.btnBuscarComprasAccesorios = new System.Windows.Forms.Button();
            this.txtBuscarComprasAccesorios = new System.Windows.Forms.TextBox();
            this.numCantidadAccesorio = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.grdCompraAccesorios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoAccesorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioAccesorio)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAccesorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompraAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accesorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Precio venta";
            // 
            // txtCompraAccesorio
            // 
            this.txtCompraAccesorio.Location = new System.Drawing.Point(9, 45);
            this.txtCompraAccesorio.Name = "txtCompraAccesorio";
            this.txtCompraAccesorio.Size = new System.Drawing.Size(223, 20);
            this.txtCompraAccesorio.TabIndex = 0;
            // 
            // numCostoAccesorio
            // 
            this.numCostoAccesorio.Location = new System.Drawing.Point(9, 100);
            this.numCostoAccesorio.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numCostoAccesorio.Name = "numCostoAccesorio";
            this.numCostoAccesorio.Size = new System.Drawing.Size(100, 20);
            this.numCostoAccesorio.TabIndex = 2;
            // 
            // numPrecioAccesorio
            // 
            this.numPrecioAccesorio.Location = new System.Drawing.Point(138, 100);
            this.numPrecioAccesorio.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numPrecioAccesorio.Name = "numPrecioAccesorio";
            this.numPrecioAccesorio.Size = new System.Drawing.Size(94, 20);
            this.numPrecioAccesorio.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblCapitalInventario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbCantidadInventario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnInsertarAccesorios);
            this.groupBox1.Controls.Add(this.btnBuscarComprasAccesorios);
            this.groupBox1.Controls.Add(this.txtBuscarComprasAccesorios);
            this.groupBox1.Controls.Add(this.numCantidadAccesorio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numPrecioAccesorio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numCostoAccesorio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCompraAccesorio);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la compra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCapitalInventario
            // 
            this.lblCapitalInventario.AutoSize = true;
            this.lblCapitalInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalInventario.Location = new System.Drawing.Point(497, 112);
            this.lblCapitalInventario.Name = "lblCapitalInventario";
            this.lblCapitalInventario.Size = new System.Drawing.Size(14, 13);
            this.lblCapitalInventario.TabIndex = 8;
            this.lblCapitalInventario.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Capital en inventario:";
            // 
            // lbCantidadInventario
            // 
            this.lbCantidadInventario.AutoSize = true;
            this.lbCantidadInventario.Location = new System.Drawing.Point(365, 112);
            this.lbCantidadInventario.Name = "lbCantidadInventario";
            this.lbCantidadInventario.Size = new System.Drawing.Size(13, 13);
            this.lbCantidadInventario.TabIndex = 8;
            this.lbCantidadInventario.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cant. en inventario:";
            // 
            // btnInsertarAccesorios
            // 
            this.btnInsertarAccesorios.Location = new System.Drawing.Point(258, 92);
            this.btnInsertarAccesorios.Name = "btnInsertarAccesorios";
            this.btnInsertarAccesorios.Size = new System.Drawing.Size(89, 33);
            this.btnInsertarAccesorios.TabIndex = 7;
            this.btnInsertarAccesorios.Text = "Insertar";
            this.btnInsertarAccesorios.UseVisualStyleBackColor = true;
            this.btnInsertarAccesorios.Click += new System.EventHandler(this.btnInsertarAccesorios_Click);
            // 
            // btnBuscarComprasAccesorios
            // 
            this.btnBuscarComprasAccesorios.Location = new System.Drawing.Point(10, 133);
            this.btnBuscarComprasAccesorios.Name = "btnBuscarComprasAccesorios";
            this.btnBuscarComprasAccesorios.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarComprasAccesorios.TabIndex = 6;
            this.btnBuscarComprasAccesorios.Text = "Buscar";
            this.btnBuscarComprasAccesorios.UseVisualStyleBackColor = true;
            this.btnBuscarComprasAccesorios.Click += new System.EventHandler(this.btnBuscarComprasAccesorios_Click);
            // 
            // txtBuscarComprasAccesorios
            // 
            this.txtBuscarComprasAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarComprasAccesorios.Location = new System.Drawing.Point(106, 136);
            this.txtBuscarComprasAccesorios.Name = "txtBuscarComprasAccesorios";
            this.txtBuscarComprasAccesorios.Size = new System.Drawing.Size(553, 20);
            this.txtBuscarComprasAccesorios.TabIndex = 5;
            this.txtBuscarComprasAccesorios.TextChanged += new System.EventHandler(this.txtBuscarComprasAccesorios_TextChanged);
            // 
            // numCantidadAccesorio
            // 
            this.numCantidadAccesorio.Location = new System.Drawing.Point(258, 45);
            this.numCantidadAccesorio.Name = "numCantidadAccesorio";
            this.numCantidadAccesorio.Size = new System.Drawing.Size(120, 20);
            this.numCantidadAccesorio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // grdCompraAccesorios
            // 
            this.grdCompraAccesorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCompraAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompraAccesorios.Location = new System.Drawing.Point(2, 169);
            this.grdCompraAccesorios.Name = "grdCompraAccesorios";
            this.grdCompraAccesorios.ReadOnly = true;
            this.grdCompraAccesorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCompraAccesorios.Size = new System.Drawing.Size(665, 144);
            this.grdCompraAccesorios.TabIndex = 5;
            this.grdCompraAccesorios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdCompraAccesorios_CellMouseDoubleClick);
            // 
            // frmCompraAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 317);
            this.Controls.Add(this.grdCompraAccesorios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompraAccesorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Accesorios";
            this.Load += new System.EventHandler(this.frmCompraAccesorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCostoAccesorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioAccesorio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadAccesorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompraAccesorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompraAccesorio;
        private System.Windows.Forms.NumericUpDown numCostoAccesorio;
        private System.Windows.Forms.NumericUpDown numPrecioAccesorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numCantidadAccesorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdCompraAccesorios;
        private System.Windows.Forms.Button btnBuscarComprasAccesorios;
        private System.Windows.Forms.TextBox txtBuscarComprasAccesorios;
        private System.Windows.Forms.Button btnInsertarAccesorios;
        private System.Windows.Forms.Label lblCapitalInventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCantidadInventario;
        private System.Windows.Forms.Label label5;
    }
}