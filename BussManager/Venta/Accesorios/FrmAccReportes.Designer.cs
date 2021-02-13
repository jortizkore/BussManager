namespace BussManager.Venta.Accesorios
{
    partial class FrmAccReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccReportes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeGanancias = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chUsarFiltro = new System.Windows.Forms.CheckBox();
            this.txtFiltroReporteAccesorio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalGanancias = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblTotalAccVendios = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.grdReporteDeVentasAcc = new System.Windows.Forms.DataGridView();
            this.cmdCargarReporteVentasAcc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteDeVentasAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmdCargarReporteVentasAcc);
            this.groupBox1.Controls.Add(this.lblPorcentajeGanancias);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.chUsarFiltro);
            this.groupBox1.Controls.Add(this.txtFiltroReporteAccesorio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTotalGanancias);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalVentas);
            this.groupBox1.Controls.Add(this.lblTotalAccVendios);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información y filtros";
            // 
            // lblPorcentajeGanancias
            // 
            this.lblPorcentajeGanancias.AutoSize = true;
            this.lblPorcentajeGanancias.Location = new System.Drawing.Point(525, 131);
            this.lblPorcentajeGanancias.Name = "lblPorcentajeGanancias";
            this.lblPorcentajeGanancias.Size = new System.Drawing.Size(20, 22);
            this.lblPorcentajeGanancias.TabIndex = 15;
            this.lblPorcentajeGanancias.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Porcentaje de ganancias:";
            // 
            // chUsarFiltro
            // 
            this.chUsarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chUsarFiltro.AutoSize = true;
            this.chUsarFiltro.Location = new System.Drawing.Point(641, 20);
            this.chUsarFiltro.Name = "chUsarFiltro";
            this.chUsarFiltro.Size = new System.Drawing.Size(116, 26);
            this.chUsarFiltro.TabIndex = 12;
            this.chUsarFiltro.Text = "Usar filtro?";
            this.chUsarFiltro.UseVisualStyleBackColor = true;
            // 
            // txtFiltroReporteAccesorio
            // 
            this.txtFiltroReporteAccesorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroReporteAccesorio.Location = new System.Drawing.Point(706, 48);
            this.txtFiltroReporteAccesorio.Name = "txtFiltroReporteAccesorio";
            this.txtFiltroReporteAccesorio.Size = new System.Drawing.Size(266, 27);
            this.txtFiltroReporteAccesorio.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(655, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Filtro:";
            // 
            // lblTotalGanancias
            // 
            this.lblTotalGanancias.AutoSize = true;
            this.lblTotalGanancias.Location = new System.Drawing.Point(525, 88);
            this.lblTotalGanancias.Name = "lblTotalGanancias";
            this.lblTotalGanancias.Size = new System.Drawing.Size(20, 22);
            this.lblTotalGanancias.TabIndex = 9;
            this.lblTotalGanancias.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ganancias generadas:";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(208, 131);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(20, 22);
            this.lblTotalVentas.TabIndex = 7;
            this.lblTotalVentas.Text = "0";
            // 
            // lblTotalAccVendios
            // 
            this.lblTotalAccVendios.AutoSize = true;
            this.lblTotalAccVendios.Location = new System.Drawing.Point(217, 88);
            this.lblTotalAccVendios.Name = "lblTotalAccVendios";
            this.lblTotalAccVendios.Size = new System.Drawing.Size(20, 22);
            this.lblTotalAccVendios.TabIndex = 6;
            this.lblTotalAccVendios.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total en ventas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total articulos vendidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha inicio";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(310, 58);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(309, 27);
            this.dtFechaFin.TabIndex = 1;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(10, 58);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(294, 27);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // grdReporteDeVentasAcc
            // 
            this.grdReporteDeVentasAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReporteDeVentasAcc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdReporteDeVentasAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReporteDeVentasAcc.Location = new System.Drawing.Point(12, 216);
            this.grdReporteDeVentasAcc.Name = "grdReporteDeVentasAcc";
            this.grdReporteDeVentasAcc.Size = new System.Drawing.Size(1005, 266);
            this.grdReporteDeVentasAcc.TabIndex = 1;
            this.grdReporteDeVentasAcc.Resize += new System.EventHandler(this.grdReporteDeVentasAcc_Resize);
            // 
            // cmdCargarReporteVentasAcc
            // 
            this.cmdCargarReporteVentasAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCargarReporteVentasAcc.Image = global::BussManager.Properties.Resources.signal_bars;
            this.cmdCargarReporteVentasAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCargarReporteVentasAcc.Location = new System.Drawing.Point(824, 107);
            this.cmdCargarReporteVentasAcc.Name = "cmdCargarReporteVentasAcc";
            this.cmdCargarReporteVentasAcc.Size = new System.Drawing.Size(175, 69);
            this.cmdCargarReporteVentasAcc.TabIndex = 16;
            this.cmdCargarReporteVentasAcc.Text = "Cargar Reporte";
            this.cmdCargarReporteVentasAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargarReporteVentasAcc.UseVisualStyleBackColor = true;
            this.cmdCargarReporteVentasAcc.Click += new System.EventHandler(this.cmdCargarReporteVentasAcc_Click);
            // 
            // FrmAccReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1029, 494);
            this.Controls.Add(this.grdReporteDeVentasAcc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1045, 533);
            this.Name = "FrmAccReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas de accesorios";
            this.Load += new System.EventHandler(this.FrmAccReportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteDeVentasAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DataGridView grdReporteDeVentasAcc;
        private System.Windows.Forms.Label lblTotalGanancias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblTotalAccVendios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chUsarFiltro;
        private System.Windows.Forms.TextBox txtFiltroReporteAccesorio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPorcentajeGanancias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdCargarReporteVentasAcc;
    }
}