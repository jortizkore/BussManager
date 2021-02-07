namespace BussManager.Inventario.Accesorios
{
    partial class frmPerdidaAccesorio
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CmdReportarPerdida = new System.Windows.Forms.Button();
            this.numCostoUnidadPerdida = new System.Windows.Forms.NumericUpDown();
            this.numCantidadPerdida = new System.Windows.Forms.NumericUpDown();
            this.txtTipoPerdida = new System.Windows.Forms.TextBox();
            this.cmbResponsable = new System.Windows.Forms.ComboBox();
            this.CmbAccesorioPerdiada = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaPerdida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCostoPerdidas = new System.Windows.Forms.Label();
            this.lblCantidadPerdiads = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.txtFiltroPerdidas = new System.Windows.Forms.TextBox();
            this.gridPerdidas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnidadPerdida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPerdida)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerdidas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 340);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CmdReportarPerdida);
            this.tabPage1.Controls.Add(this.numCostoUnidadPerdida);
            this.tabPage1.Controls.Add(this.numCantidadPerdida);
            this.tabPage1.Controls.Add(this.txtTipoPerdida);
            this.tabPage1.Controls.Add(this.cmbResponsable);
            this.tabPage1.Controls.Add(this.CmbAccesorioPerdiada);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtFechaPerdida);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CmdReportarPerdida
            // 
            this.CmdReportarPerdida.Location = new System.Drawing.Point(418, 254);
            this.CmdReportarPerdida.Name = "CmdReportarPerdida";
            this.CmdReportarPerdida.Size = new System.Drawing.Size(93, 45);
            this.CmdReportarPerdida.TabIndex = 6;
            this.CmdReportarPerdida.Text = "Reportar";
            this.CmdReportarPerdida.UseVisualStyleBackColor = true;
            this.CmdReportarPerdida.Click += new System.EventHandler(this.CmdReportarPerdida_Click);
            // 
            // numCostoUnidadPerdida
            // 
            this.numCostoUnidadPerdida.Enabled = false;
            this.numCostoUnidadPerdida.Location = new System.Drawing.Point(71, 140);
            this.numCostoUnidadPerdida.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCostoUnidadPerdida.Name = "numCostoUnidadPerdida";
            this.numCostoUnidadPerdida.Size = new System.Drawing.Size(120, 20);
            this.numCostoUnidadPerdida.TabIndex = 5;
            // 
            // numCantidadPerdida
            // 
            this.numCantidadPerdida.Location = new System.Drawing.Point(71, 97);
            this.numCantidadPerdida.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCantidadPerdida.Name = "numCantidadPerdida";
            this.numCantidadPerdida.Size = new System.Drawing.Size(120, 20);
            this.numCantidadPerdida.TabIndex = 5;
            // 
            // txtTipoPerdida
            // 
            this.txtTipoPerdida.Location = new System.Drawing.Point(14, 200);
            this.txtTipoPerdida.Multiline = true;
            this.txtTipoPerdida.Name = "txtTipoPerdida";
            this.txtTipoPerdida.Size = new System.Drawing.Size(257, 99);
            this.txtTipoPerdida.TabIndex = 4;
            // 
            // cmbResponsable
            // 
            this.cmbResponsable.FormattingEnabled = true;
            this.cmbResponsable.Location = new System.Drawing.Point(358, 200);
            this.cmbResponsable.Name = "cmbResponsable";
            this.cmbResponsable.Size = new System.Drawing.Size(153, 21);
            this.cmbResponsable.TabIndex = 3;
            // 
            // CmbAccesorioPerdiada
            // 
            this.CmbAccesorioPerdiada.FormattingEnabled = true;
            this.CmbAccesorioPerdiada.Location = new System.Drawing.Point(71, 54);
            this.CmbAccesorioPerdiada.Name = "CmbAccesorioPerdiada";
            this.CmbAccesorioPerdiada.Size = new System.Drawing.Size(153, 21);
            this.CmbAccesorioPerdiada.TabIndex = 3;
            this.CmbAccesorioPerdiada.SelectedIndexChanged += new System.EventHandler(this.CmbAccesorioPerdiada_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Responsable";
            // 
            // dtFechaPerdida
            // 
            this.dtFechaPerdida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaPerdida.Location = new System.Drawing.Point(314, 17);
            this.dtFechaPerdida.Name = "dtFechaPerdida";
            this.dtFechaPerdida.Size = new System.Drawing.Size(200, 20);
            this.dtFechaPerdida.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo Perdida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Accesorio";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCostoPerdidas);
            this.tabPage2.Controls.Add(this.lblCantidadPerdiads);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lll);
            this.tabPage2.Controls.Add(this.txtFiltroPerdidas);
            this.tabPage2.Controls.Add(this.gridPerdidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCostoPerdidas
            // 
            this.lblCostoPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoPerdidas.AutoSize = true;
            this.lblCostoPerdidas.Location = new System.Drawing.Point(382, 51);
            this.lblCostoPerdidas.Name = "lblCostoPerdidas";
            this.lblCostoPerdidas.Size = new System.Drawing.Size(13, 13);
            this.lblCostoPerdidas.TabIndex = 4;
            this.lblCostoPerdidas.Text = "0";
            // 
            // lblCantidadPerdiads
            // 
            this.lblCantidadPerdiads.AutoSize = true;
            this.lblCantidadPerdiads.Location = new System.Drawing.Point(255, 51);
            this.lblCantidadPerdiads.Name = "lblCantidadPerdiads";
            this.lblCantidadPerdiads.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadPerdiads.TabIndex = 4;
            this.lblCantidadPerdiads.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Candidad";
            // 
            // lll
            // 
            this.lll.AutoSize = true;
            this.lll.Location = new System.Drawing.Point(4, 32);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(29, 13);
            this.lll.TabIndex = 2;
            this.lll.Text = "Filtro";
            // 
            // txtFiltroPerdidas
            // 
            this.txtFiltroPerdidas.Location = new System.Drawing.Point(7, 48);
            this.txtFiltroPerdidas.Name = "txtFiltroPerdidas";
            this.txtFiltroPerdidas.Size = new System.Drawing.Size(236, 20);
            this.txtFiltroPerdidas.TabIndex = 1;
            this.txtFiltroPerdidas.TextChanged += new System.EventHandler(this.txtFiltroPerdidas_TextChanged);
            // 
            // gridPerdidas
            // 
            this.gridPerdidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPerdidas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridPerdidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerdidas.Location = new System.Drawing.Point(7, 74);
            this.gridPerdidas.Name = "gridPerdidas";
            this.gridPerdidas.Size = new System.Drawing.Size(537, 233);
            this.gridPerdidas.TabIndex = 0;
            // 
            // frmPerdidaAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 353);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(576, 392);
            this.Name = "frmPerdidaAccesorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perdidas";
            this.Load += new System.EventHandler(this.frmPerdidaAccesorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoUnidadPerdida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadPerdida)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerdidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CmdReportarPerdida;
        private System.Windows.Forms.NumericUpDown numCostoUnidadPerdida;
        private System.Windows.Forms.NumericUpDown numCantidadPerdida;
        private System.Windows.Forms.TextBox txtTipoPerdida;
        private System.Windows.Forms.ComboBox cmbResponsable;
        private System.Windows.Forms.ComboBox CmbAccesorioPerdiada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtFechaPerdida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCostoPerdidas;
        private System.Windows.Forms.Label lblCantidadPerdiads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lll;
        private System.Windows.Forms.TextBox txtFiltroPerdidas;
        private System.Windows.Forms.DataGridView gridPerdidas;
    }
}