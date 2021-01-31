namespace BussManager.Reparaciones
{
    partial class frmReparaciones
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIMEIReparacion = new System.Windows.Forms.TextBox();
            this.txtComentarioReparacion = new System.Windows.Forms.TextBox();
            this.btnGuardarReparacion = new System.Windows.Forms.Button();
            this.nunmIdCompraReparacion = new System.Windows.Forms.NumericUpDown();
            this.cmbTecnicoReparacion = new System.Windows.Forms.ComboBox();
            this.dtFechaReparacion = new System.Windows.Forms.DateTimePicker();
            this.numPrecioReparacion = new System.Windows.Forms.NumericUpDown();
            this.numCostoReparacion = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoReparacion = new System.Windows.Forms.ComboBox();
            this.cmbReparacionMarcaEquipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFiltroReparaciones = new System.Windows.Forms.TextBox();
            this.gridReparacionesPendientes = new System.Windows.Forms.DataGridView();
            this.cmdEntregar = new System.Windows.Forms.Button();
            this.cmdCompletar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunmIdCompraReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoReparacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtIMEIReparacion);
            this.tabPage1.Controls.Add(this.txtComentarioReparacion);
            this.tabPage1.Controls.Add(this.btnGuardarReparacion);
            this.tabPage1.Controls.Add(this.nunmIdCompraReparacion);
            this.tabPage1.Controls.Add(this.cmbTecnicoReparacion);
            this.tabPage1.Controls.Add(this.dtFechaReparacion);
            this.tabPage1.Controls.Add(this.numPrecioReparacion);
            this.tabPage1.Controls.Add(this.numCostoReparacion);
            this.tabPage1.Controls.Add(this.cmbTipoReparacion);
            this.tabPage1.Controls.Add(this.cmbReparacionMarcaEquipo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtIMEIReparacion
            // 
            this.txtIMEIReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEIReparacion.Location = new System.Drawing.Point(371, 256);
            this.txtIMEIReparacion.Name = "txtIMEIReparacion";
            this.txtIMEIReparacion.Size = new System.Drawing.Size(238, 24);
            this.txtIMEIReparacion.TabIndex = 34;
            // 
            // txtComentarioReparacion
            // 
            this.txtComentarioReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioReparacion.Location = new System.Drawing.Point(371, 343);
            this.txtComentarioReparacion.Multiline = true;
            this.txtComentarioReparacion.Name = "txtComentarioReparacion";
            this.txtComentarioReparacion.Size = new System.Drawing.Size(238, 64);
            this.txtComentarioReparacion.TabIndex = 33;
            // 
            // btnGuardarReparacion
            // 
            this.btnGuardarReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReparacion.Location = new System.Drawing.Point(35, 322);
            this.btnGuardarReparacion.Name = "btnGuardarReparacion";
            this.btnGuardarReparacion.Size = new System.Drawing.Size(135, 44);
            this.btnGuardarReparacion.TabIndex = 32;
            this.btnGuardarReparacion.Text = "Guardar";
            this.btnGuardarReparacion.UseVisualStyleBackColor = true;
            // 
            // nunmIdCompraReparacion
            // 
            this.nunmIdCompraReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nunmIdCompraReparacion.Location = new System.Drawing.Point(371, 107);
            this.nunmIdCompraReparacion.Name = "nunmIdCompraReparacion";
            this.nunmIdCompraReparacion.Size = new System.Drawing.Size(59, 24);
            this.nunmIdCompraReparacion.TabIndex = 31;
            // 
            // cmbTecnicoReparacion
            // 
            this.cmbTecnicoReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTecnicoReparacion.FormattingEnabled = true;
            this.cmbTecnicoReparacion.Location = new System.Drawing.Point(371, 175);
            this.cmbTecnicoReparacion.Name = "cmbTecnicoReparacion";
            this.cmbTecnicoReparacion.Size = new System.Drawing.Size(238, 26);
            this.cmbTecnicoReparacion.TabIndex = 30;
            // 
            // dtFechaReparacion
            // 
            this.dtFechaReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaReparacion.Location = new System.Drawing.Point(371, 31);
            this.dtFechaReparacion.Name = "dtFechaReparacion";
            this.dtFechaReparacion.Size = new System.Drawing.Size(274, 24);
            this.dtFechaReparacion.TabIndex = 29;
            // 
            // numPrecioReparacion
            // 
            this.numPrecioReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecioReparacion.Location = new System.Drawing.Point(34, 255);
            this.numPrecioReparacion.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPrecioReparacion.Name = "numPrecioReparacion";
            this.numPrecioReparacion.Size = new System.Drawing.Size(120, 24);
            this.numPrecioReparacion.TabIndex = 28;
            // 
            // numCostoReparacion
            // 
            this.numCostoReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCostoReparacion.Location = new System.Drawing.Point(35, 174);
            this.numCostoReparacion.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCostoReparacion.Name = "numCostoReparacion";
            this.numCostoReparacion.Size = new System.Drawing.Size(120, 24);
            this.numCostoReparacion.TabIndex = 27;
            // 
            // cmbTipoReparacion
            // 
            this.cmbTipoReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoReparacion.FormattingEnabled = true;
            this.cmbTipoReparacion.Location = new System.Drawing.Point(34, 101);
            this.cmbTipoReparacion.Name = "cmbTipoReparacion";
            this.cmbTipoReparacion.Size = new System.Drawing.Size(268, 26);
            this.cmbTipoReparacion.TabIndex = 26;
            // 
            // cmbReparacionMarcaEquipo
            // 
            this.cmbReparacionMarcaEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReparacionMarcaEquipo.FormattingEnabled = true;
            this.cmbReparacionMarcaEquipo.Location = new System.Drawing.Point(34, 33);
            this.cmbReparacionMarcaEquipo.Name = "cmbReparacionMarcaEquipo";
            this.cmbReparacionMarcaEquipo.Size = new System.Drawing.Size(268, 26);
            this.cmbReparacionMarcaEquipo.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tecnico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Comentario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "IMEI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipo reparación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Marca - Modelo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtFiltroReparaciones);
            this.tabPage2.Controls.Add(this.gridReparacionesPendientes);
            this.tabPage2.Controls.Add(this.cmdEntregar);
            this.tabPage2.Controls.Add(this.cmdCompletar);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reparaciones pendientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFiltroReparaciones
            // 
            this.txtFiltroReparaciones.Location = new System.Drawing.Point(7, 103);
            this.txtFiltroReparaciones.Name = "txtFiltroReparaciones";
            this.txtFiltroReparaciones.Size = new System.Drawing.Size(517, 29);
            this.txtFiltroReparaciones.TabIndex = 2;
            // 
            // gridReparacionesPendientes
            // 
            this.gridReparacionesPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReparacionesPendientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridReparacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReparacionesPendientes.Location = new System.Drawing.Point(6, 138);
            this.gridReparacionesPendientes.MultiSelect = false;
            this.gridReparacionesPendientes.Name = "gridReparacionesPendientes";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridReparacionesPendientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridReparacionesPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReparacionesPendientes.Size = new System.Drawing.Size(873, 288);
            this.gridReparacionesPendientes.TabIndex = 1;
            this.gridReparacionesPendientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridReparacionesPendientes_CellMouseClick);
            this.gridReparacionesPendientes.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridReparacionesPendientes_RowPrePaint);
            // 
            // cmdEntregar
            // 
            this.cmdEntregar.Location = new System.Drawing.Point(144, 41);
            this.cmdEntregar.Name = "cmdEntregar";
            this.cmdEntregar.Size = new System.Drawing.Size(118, 46);
            this.cmdEntregar.TabIndex = 0;
            this.cmdEntregar.Text = "Entregar";
            this.cmdEntregar.UseVisualStyleBackColor = true;
            // 
            // cmdCompletar
            // 
            this.cmdCompletar.Location = new System.Drawing.Point(7, 41);
            this.cmdCompletar.Name = "cmdCompletar";
            this.cmdCompletar.Size = new System.Drawing.Size(118, 46);
            this.cmdCompletar.TabIndex = 0;
            this.cmdCompletar.Text = "Completar";
            this.cmdCompletar.UseVisualStyleBackColor = true;
            this.cmdCompletar.Click += new System.EventHandler(this.cmdCompletar_Click);
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 484);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(705, 523);
            this.Name = "frmReparaciones";
            this.Text = "Registro reparaciones";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunmIdCompraReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoReparacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtIMEIReparacion;
        private System.Windows.Forms.TextBox txtComentarioReparacion;
        private System.Windows.Forms.Button btnGuardarReparacion;
        private System.Windows.Forms.NumericUpDown nunmIdCompraReparacion;
        private System.Windows.Forms.ComboBox cmbTecnicoReparacion;
        private System.Windows.Forms.DateTimePicker dtFechaReparacion;
        private System.Windows.Forms.NumericUpDown numPrecioReparacion;
        private System.Windows.Forms.NumericUpDown numCostoReparacion;
        private System.Windows.Forms.ComboBox cmbTipoReparacion;
        private System.Windows.Forms.ComboBox cmbReparacionMarcaEquipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFiltroReparaciones;
        private System.Windows.Forms.DataGridView gridReparacionesPendientes;
        private System.Windows.Forms.Button cmdEntregar;
        private System.Windows.Forms.Button cmdCompletar;
    }
}