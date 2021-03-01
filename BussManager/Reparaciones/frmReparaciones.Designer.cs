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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReparaciones));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabRegistroReparaciones = new System.Windows.Forms.TabPage();
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
            this.TabReparacionesPendientes = new System.Windows.Forms.TabPage();
            this.txtFiltroReparaciones = new System.Windows.Forms.TextBox();
            this.gridReparacionesPendientes = new System.Windows.Forms.DataGridView();
            this.cmdEntregar = new System.Windows.Forms.Button();
            this.cmdCompletar = new System.Windows.Forms.Button();
            this.TabReparacionesEntregadas = new System.Windows.Forms.TabPage();
            this.txtFiltroGridCompletadas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gridReparacionesCompletadas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabRegistroReparaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunmIdCompraReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoReparacion)).BeginInit();
            this.TabReparacionesPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesPendientes)).BeginInit();
            this.TabReparacionesEntregadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesCompletadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.TabRegistroReparaciones);
            this.tabControl1.Controls.Add(this.TabReparacionesPendientes);
            this.tabControl1.Controls.Add(this.TabReparacionesEntregadas);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // TabRegistroReparaciones
            // 
            this.TabRegistroReparaciones.BackColor = System.Drawing.Color.PeachPuff;
            this.TabRegistroReparaciones.Controls.Add(this.txtIMEIReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.txtComentarioReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.btnGuardarReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.nunmIdCompraReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.cmbTecnicoReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.dtFechaReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.numPrecioReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.numCostoReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.cmbTipoReparacion);
            this.TabRegistroReparaciones.Controls.Add(this.cmbReparacionMarcaEquipo);
            this.TabRegistroReparaciones.Controls.Add(this.label7);
            this.TabRegistroReparaciones.Controls.Add(this.label6);
            this.TabRegistroReparaciones.Controls.Add(this.label5);
            this.TabRegistroReparaciones.Controls.Add(this.label8);
            this.TabRegistroReparaciones.Controls.Add(this.label9);
            this.TabRegistroReparaciones.Controls.Add(this.label4);
            this.TabRegistroReparaciones.Controls.Add(this.label3);
            this.TabRegistroReparaciones.Controls.Add(this.label2);
            this.TabRegistroReparaciones.Controls.Add(this.label1);
            this.TabRegistroReparaciones.Location = new System.Drawing.Point(4, 36);
            this.TabRegistroReparaciones.Name = "TabRegistroReparaciones";
            this.TabRegistroReparaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TabRegistroReparaciones.Size = new System.Drawing.Size(886, 429);
            this.TabRegistroReparaciones.TabIndex = 0;
            this.TabRegistroReparaciones.Text = "Registro";
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
            this.btnGuardarReparacion.Click += new System.EventHandler(this.btnGuardarReparacion_Click);
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
            // TabReparacionesPendientes
            // 
            this.TabReparacionesPendientes.BackColor = System.Drawing.Color.PeachPuff;
            this.TabReparacionesPendientes.Controls.Add(this.txtFiltroReparaciones);
            this.TabReparacionesPendientes.Controls.Add(this.gridReparacionesPendientes);
            this.TabReparacionesPendientes.Controls.Add(this.cmdEntregar);
            this.TabReparacionesPendientes.Controls.Add(this.cmdCompletar);
            this.TabReparacionesPendientes.Location = new System.Drawing.Point(4, 36);
            this.TabReparacionesPendientes.Name = "TabReparacionesPendientes";
            this.TabReparacionesPendientes.Padding = new System.Windows.Forms.Padding(3);
            this.TabReparacionesPendientes.Size = new System.Drawing.Size(886, 429);
            this.TabReparacionesPendientes.TabIndex = 1;
            this.TabReparacionesPendientes.Text = "Pendientes";
            // 
            // txtFiltroReparaciones
            // 
            this.txtFiltroReparaciones.Location = new System.Drawing.Point(7, 103);
            this.txtFiltroReparaciones.Name = "txtFiltroReparaciones";
            this.txtFiltroReparaciones.Size = new System.Drawing.Size(517, 29);
            this.txtFiltroReparaciones.TabIndex = 2;
            this.txtFiltroReparaciones.TextChanged += new System.EventHandler(this.txtFiltroReparaciones_TextChanged);
            // 
            // gridReparacionesPendientes
            // 
            this.gridReparacionesPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReparacionesPendientes.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridReparacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReparacionesPendientes.Location = new System.Drawing.Point(6, 138);
            this.gridReparacionesPendientes.MultiSelect = false;
            this.gridReparacionesPendientes.Name = "gridReparacionesPendientes";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridReparacionesPendientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
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
            this.cmdEntregar.Click += new System.EventHandler(this.cmdEntregar_Click);
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
            // TabReparacionesEntregadas
            // 
            this.TabReparacionesEntregadas.BackColor = System.Drawing.Color.PeachPuff;
            this.TabReparacionesEntregadas.Controls.Add(this.txtFiltroGridCompletadas);
            this.TabReparacionesEntregadas.Controls.Add(this.label10);
            this.TabReparacionesEntregadas.Controls.Add(this.gridReparacionesCompletadas);
            this.TabReparacionesEntregadas.Location = new System.Drawing.Point(4, 36);
            this.TabReparacionesEntregadas.Name = "TabReparacionesEntregadas";
            this.TabReparacionesEntregadas.Size = new System.Drawing.Size(886, 429);
            this.TabReparacionesEntregadas.TabIndex = 2;
            this.TabReparacionesEntregadas.Text = "Entregadas";
            this.TabReparacionesEntregadas.Click += new System.EventHandler(this.TabReparacionesEntregadas_Click);
            // 
            // txtFiltroGridCompletadas
            // 
            this.txtFiltroGridCompletadas.Location = new System.Drawing.Point(65, 42);
            this.txtFiltroGridCompletadas.Name = "txtFiltroGridCompletadas";
            this.txtFiltroGridCompletadas.Size = new System.Drawing.Size(436, 29);
            this.txtFiltroGridCompletadas.TabIndex = 2;
            this.txtFiltroGridCompletadas.TextChanged += new System.EventHandler(this.txtFiltroGridCompletadas_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Filtro";
            // 
            // gridReparacionesCompletadas
            // 
            this.gridReparacionesCompletadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReparacionesCompletadas.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridReparacionesCompletadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReparacionesCompletadas.Location = new System.Drawing.Point(3, 77);
            this.gridReparacionesCompletadas.Name = "gridReparacionesCompletadas";
            this.gridReparacionesCompletadas.Size = new System.Drawing.Size(874, 347);
            this.gridReparacionesCompletadas.TabIndex = 0;
            this.gridReparacionesCompletadas.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gridReparacionesCompletadas_RowPrePaint);
            // 
            // frmReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 484);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(705, 523);
            this.Name = "frmReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Reparaciones";
            this.Load += new System.EventHandler(this.frmReparaciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabRegistroReparaciones.ResumeLayout(false);
            this.TabRegistroReparaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunmIdCompraReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoReparacion)).EndInit();
            this.TabReparacionesPendientes.ResumeLayout(false);
            this.TabReparacionesPendientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesPendientes)).EndInit();
            this.TabReparacionesEntregadas.ResumeLayout(false);
            this.TabReparacionesEntregadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReparacionesCompletadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabRegistroReparaciones;
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
        private System.Windows.Forms.TabPage TabReparacionesPendientes;
        private System.Windows.Forms.TextBox txtFiltroReparaciones;
        private System.Windows.Forms.DataGridView gridReparacionesPendientes;
        private System.Windows.Forms.Button cmdEntregar;
        private System.Windows.Forms.Button cmdCompletar;
        private System.Windows.Forms.TabPage TabReparacionesEntregadas;
        private System.Windows.Forms.DataGridView gridReparacionesCompletadas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiltroGridCompletadas;
    }
}