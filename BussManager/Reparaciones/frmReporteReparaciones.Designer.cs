namespace BussManager.Reparaciones
{
    partial class frmReporteReparaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteReparaciones));
            this.grdReporteReparaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFiltroReparaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalReparaciones = new System.Windows.Forms.Label();
            this.lblTotalCosto = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.lblTotalGanancias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteReparaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReporteReparaciones
            // 
            this.grdReporteReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdReporteReparaciones.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.grdReporteReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReporteReparaciones.Location = new System.Drawing.Point(14, 307);
            this.grdReporteReparaciones.Margin = new System.Windows.Forms.Padding(5);
            this.grdReporteReparaciones.Name = "grdReporteReparaciones";
            this.grdReporteReparaciones.Size = new System.Drawing.Size(918, 292);
            this.grdReporteReparaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(912, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros y parametros";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha inicio";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Location = new System.Drawing.Point(494, 88);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(5);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(399, 29);
            this.dtFechaFin.TabIndex = 0;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaFin_ValueChanged);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Location = new System.Drawing.Point(10, 88);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(5);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(454, 29);
            this.dtFechaInicio.TabIndex = 0;
            // 
            // txtFiltroReparaciones
            // 
            this.txtFiltroReparaciones.Location = new System.Drawing.Point(90, 273);
            this.txtFiltroReparaciones.Name = "txtFiltroReparaciones";
            this.txtFiltroReparaciones.Size = new System.Drawing.Size(520, 27);
            this.txtFiltroReparaciones.TabIndex = 2;
            this.txtFiltroReparaciones.TextChanged += new System.EventHandler(this.txtFiltroReparaciones_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Reparaciones: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Buscar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Costo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(524, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total Ingresos: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Ganancia: ";
            // 
            // lblTotalReparaciones
            // 
            this.lblTotalReparaciones.AutoSize = true;
            this.lblTotalReparaciones.Location = new System.Drawing.Point(209, 175);
            this.lblTotalReparaciones.Name = "lblTotalReparaciones";
            this.lblTotalReparaciones.Size = new System.Drawing.Size(20, 22);
            this.lblTotalReparaciones.TabIndex = 7;
            this.lblTotalReparaciones.Text = "0";
            // 
            // lblTotalCosto
            // 
            this.lblTotalCosto.AutoSize = true;
            this.lblTotalCosto.Location = new System.Drawing.Point(149, 226);
            this.lblTotalCosto.Name = "lblTotalCosto";
            this.lblTotalCosto.Size = new System.Drawing.Size(20, 22);
            this.lblTotalCosto.TabIndex = 8;
            this.lblTotalCosto.Text = "0";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Location = new System.Drawing.Point(654, 175);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(20, 22);
            this.lblTotalIngresos.TabIndex = 9;
            this.lblTotalIngresos.Text = "0";
            // 
            // lblTotalGanancias
            // 
            this.lblTotalGanancias.AutoSize = true;
            this.lblTotalGanancias.Location = new System.Drawing.Point(673, 226);
            this.lblTotalGanancias.Name = "lblTotalGanancias";
            this.lblTotalGanancias.Size = new System.Drawing.Size(20, 22);
            this.lblTotalGanancias.TabIndex = 10;
            this.lblTotalGanancias.Text = "0";
            // 
            // frmReporteReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(939, 604);
            this.Controls.Add(this.lblTotalGanancias);
            this.Controls.Add(this.lblTotalIngresos);
            this.Controls.Add(this.lblTotalCosto);
            this.Controls.Add(this.lblTotalReparaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroReparaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdReporteReparaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(955, 465);
            this.Name = "frmReporteReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Reparaciones";
            this.Load += new System.EventHandler(this.frmReporteReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReporteReparaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReporteReparaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroReparaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalReparaciones;
        private System.Windows.Forms.Label lblTotalCosto;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label lblTotalGanancias;
    }
}