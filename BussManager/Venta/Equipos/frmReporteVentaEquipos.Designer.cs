namespace BussManager.Venta.Equipos
{
    partial class frmReporteVentaEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVentaEquipos));
            this.grdReporteVentasEquipos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltroIMEIReporteVenta = new System.Windows.Forms.TextBox();
            this.txtFiltroModeloReporteVenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.chFiltroReporteVentaEquipos = new System.Windows.Forms.CheckBox();
            this.lblGananciasReporteVentaEquipos = new System.Windows.Forms.Label();
            this.lblPorcentajeGananciasEquipos = new System.Windows.Forms.Label();
            this.lblTotalVentasEquios = new System.Windows.Forms.Label();
            this.lblReporteCantidadEquiposVendidos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCargarReporteVentasEquipo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteVentasEquipos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReporteVentasEquipos
            // 
            this.grdReporteVentasEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReporteVentasEquipos.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.grdReporteVentasEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReporteVentasEquipos.Location = new System.Drawing.Point(0, 250);
            this.grdReporteVentasEquipos.MultiSelect = false;
            this.grdReporteVentasEquipos.Name = "grdReporteVentasEquipos";
            this.grdReporteVentasEquipos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReporteVentasEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReporteVentasEquipos.Size = new System.Drawing.Size(1070, 225);
            this.grdReporteVentasEquipos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFiltroIMEIReporteVenta);
            this.groupBox1.Controls.Add(this.txtFiltroModeloReporteVenta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.cmdCargarReporteVentasEquipo);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Controls.Add(this.chFiltroReporteVentaEquipos);
            this.groupBox1.Controls.Add(this.lblGananciasReporteVentaEquipos);
            this.groupBox1.Controls.Add(this.lblPorcentajeGananciasEquipos);
            this.groupBox1.Controls.Add(this.lblTotalVentasEquios);
            this.groupBox1.Controls.Add(this.lblReporteCantidadEquiposVendidos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 232);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información y filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFiltroIMEIReporteVenta
            // 
            this.txtFiltroIMEIReporteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroIMEIReporteVenta.Location = new System.Drawing.Point(767, 137);
            this.txtFiltroIMEIReporteVenta.Name = "txtFiltroIMEIReporteVenta";
            this.txtFiltroIMEIReporteVenta.Size = new System.Drawing.Size(274, 27);
            this.txtFiltroIMEIReporteVenta.TabIndex = 15;
            this.txtFiltroIMEIReporteVenta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtFiltroModeloReporteVenta
            // 
            this.txtFiltroModeloReporteVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroModeloReporteVenta.Location = new System.Drawing.Point(767, 82);
            this.txtFiltroModeloReporteVenta.Name = "txtFiltroModeloReporteVenta";
            this.txtFiltroModeloReporteVenta.Size = new System.Drawing.Size(274, 27);
            this.txtFiltroModeloReporteVenta.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(763, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "IMEI:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Marca/Modelo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha inicio";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(437, 63);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(286, 27);
            this.dtFechaFin.TabIndex = 9;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(12, 63);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(290, 27);
            this.dtFechaInicio.TabIndex = 7;
            // 
            // chFiltroReporteVentaEquipos
            // 
            this.chFiltroReporteVentaEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chFiltroReporteVentaEquipos.AutoSize = true;
            this.chFiltroReporteVentaEquipos.Location = new System.Drawing.Point(764, 18);
            this.chFiltroReporteVentaEquipos.Name = "chFiltroReporteVentaEquipos";
            this.chFiltroReporteVentaEquipos.Size = new System.Drawing.Size(115, 26);
            this.chFiltroReporteVentaEquipos.TabIndex = 6;
            this.chFiltroReporteVentaEquipos.Text = "Usar filtros";
            this.chFiltroReporteVentaEquipos.UseVisualStyleBackColor = true;
            this.chFiltroReporteVentaEquipos.CheckedChanged += new System.EventHandler(this.chFiltroReporteVentaEquipos_CheckedChanged);
            // 
            // lblGananciasReporteVentaEquipos
            // 
            this.lblGananciasReporteVentaEquipos.AutoSize = true;
            this.lblGananciasReporteVentaEquipos.Location = new System.Drawing.Point(595, 127);
            this.lblGananciasReporteVentaEquipos.Name = "lblGananciasReporteVentaEquipos";
            this.lblGananciasReporteVentaEquipos.Size = new System.Drawing.Size(20, 22);
            this.lblGananciasReporteVentaEquipos.TabIndex = 4;
            this.lblGananciasReporteVentaEquipos.Text = "0";
            // 
            // lblPorcentajeGananciasEquipos
            // 
            this.lblPorcentajeGananciasEquipos.AutoSize = true;
            this.lblPorcentajeGananciasEquipos.Location = new System.Drawing.Point(595, 176);
            this.lblPorcentajeGananciasEquipos.Name = "lblPorcentajeGananciasEquipos";
            this.lblPorcentajeGananciasEquipos.Size = new System.Drawing.Size(20, 22);
            this.lblPorcentajeGananciasEquipos.TabIndex = 4;
            this.lblPorcentajeGananciasEquipos.Text = "0";
            // 
            // lblTotalVentasEquios
            // 
            this.lblTotalVentasEquios.AutoSize = true;
            this.lblTotalVentasEquios.Location = new System.Drawing.Point(149, 177);
            this.lblTotalVentasEquios.Name = "lblTotalVentasEquios";
            this.lblTotalVentasEquios.Size = new System.Drawing.Size(20, 22);
            this.lblTotalVentasEquios.TabIndex = 4;
            this.lblTotalVentasEquios.Text = "0";
            // 
            // lblReporteCantidadEquiposVendidos
            // 
            this.lblReporteCantidadEquiposVendidos.AutoSize = true;
            this.lblReporteCantidadEquiposVendidos.Location = new System.Drawing.Point(149, 127);
            this.lblReporteCantidadEquiposVendidos.Name = "lblReporteCantidadEquiposVendidos";
            this.lblReporteCantidadEquiposVendidos.Size = new System.Drawing.Size(20, 22);
            this.lblReporteCantidadEquiposVendidos.TabIndex = 4;
            this.lblReporteCantidadEquiposVendidos.Text = "0";
            this.lblReporteCantidadEquiposVendidos.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porcentaje de ganancias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ganancias generadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total ventas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cant. vendidos:";
            // 
            // cmdCargarReporteVentasEquipo
            // 
            this.cmdCargarReporteVentasEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCargarReporteVentasEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarReporteVentasEquipo.Image = global::BussManager.Properties.Resources.trade_report_reports_documents_2351;
            this.cmdCargarReporteVentasEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCargarReporteVentasEquipo.Location = new System.Drawing.Point(855, 183);
            this.cmdCargarReporteVentasEquipo.Name = "cmdCargarReporteVentasEquipo";
            this.cmdCargarReporteVentasEquipo.Size = new System.Drawing.Size(186, 43);
            this.cmdCargarReporteVentasEquipo.TabIndex = 2;
            this.cmdCargarReporteVentasEquipo.Text = "Cargar reporte";
            this.cmdCargarReporteVentasEquipo.UseVisualStyleBackColor = true;
            this.cmdCargarReporteVentasEquipo.Click += new System.EventHandler(this.cmdCargarReporteVentasEquipo_Click);
            // 
            // frmReporteVentaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1077, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdReporteVentasEquipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteVentaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte venta celulares";
            this.Load += new System.EventHandler(this.frmReporteVentaEquipos_Load);
            this.Resize += new System.EventHandler(this.frmReporteVentaEquipos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteVentasEquipos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReporteVentasEquipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGananciasReporteVentaEquipos;
        private System.Windows.Forms.Label lblPorcentajeGananciasEquipos;
        private System.Windows.Forms.Label lblTotalVentasEquios;
        private System.Windows.Forms.Label lblReporteCantidadEquiposVendidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chFiltroReporteVentaEquipos;
        private System.Windows.Forms.Button cmdCargarReporteVentasEquipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.TextBox txtFiltroIMEIReporteVenta;
        private System.Windows.Forms.TextBox txtFiltroModeloReporteVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}