namespace BussManager.Venta.Equipos
{
    partial class frmVentaEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaEquipos));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblClaseModelo = new System.Windows.Forms.Label();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVentaEquipos = new System.Windows.Forms.ListView();
            this.headEquipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headIMEI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headClase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headSerieModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addMovil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdFacturar = new System.Windows.Forms.Button();
            this.lblTotalApagar = new System.Windows.Forms.Label();
            this.lblCantidadEnLista = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo";
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(16, 51);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(416, 28);
            this.cmbEquipos.TabIndex = 1;
            this.cmbEquipos.SelectedIndexChanged += new System.EventHandler(this.cmbEquipos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPrecio);
            this.groupBox1.Controls.Add(this.lblClase);
            this.groupBox1.Controls.Add(this.lblClaseModelo);
            this.groupBox1.Controls.Add(this.lblIMEI);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del equipo";
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(83, 68);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(120, 27);
            this.numPrecio.TabIndex = 9;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(417, 66);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(16, 22);
            this.lblClase.TabIndex = 8;
            this.lblClase.Text = "-";
            // 
            // lblClaseModelo
            // 
            this.lblClaseModelo.AutoSize = true;
            this.lblClaseModelo.Location = new System.Drawing.Point(424, 32);
            this.lblClaseModelo.Name = "lblClaseModelo";
            this.lblClaseModelo.Size = new System.Drawing.Size(16, 22);
            this.lblClaseModelo.TabIndex = 7;
            this.lblClaseModelo.Text = "-";
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Location = new System.Drawing.Point(71, 32);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(16, 22);
            this.lblIMEI.TabIndex = 5;
            this.lblIMEI.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(352, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 22);
            this.label.TabIndex = 4;
            this.label.Text = "Clase: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMEI: ";
            // 
            // lstVentaEquipos
            // 
            this.lstVentaEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVentaEquipos.BackColor = System.Drawing.Color.PeachPuff;
            this.lstVentaEquipos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headEquipo,
            this.headIMEI,
            this.headPrecio,
            this.headClase,
            this.headSerieModelo});
            this.lstVentaEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVentaEquipos.FullRowSelect = true;
            this.lstVentaEquipos.HideSelection = false;
            this.lstVentaEquipos.Location = new System.Drawing.Point(2, 211);
            this.lstVentaEquipos.MultiSelect = false;
            this.lstVentaEquipos.Name = "lstVentaEquipos";
            this.lstVentaEquipos.Size = new System.Drawing.Size(763, 205);
            this.lstVentaEquipos.TabIndex = 3;
            this.lstVentaEquipos.UseCompatibleStateImageBehavior = false;
            this.lstVentaEquipos.View = System.Windows.Forms.View.Details;
            // 
            // headEquipo
            // 
            this.headEquipo.Text = "Dispositivo";
            // 
            // headIMEI
            // 
            this.headIMEI.Text = "IMEI";
            // 
            // headPrecio
            // 
            this.headPrecio.Text = "Precio";
            // 
            // headClase
            // 
            this.headClase.Text = "Clase";
            // 
            // headSerieModelo
            // 
            this.headSerieModelo.Text = "SerieModelo";
            // 
            // addMovil
            // 
            this.addMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovil.Image = global::BussManager.Properties.Resources.arrow_pointing_down__1_;
            this.addMovil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addMovil.Location = new System.Drawing.Point(446, 43);
            this.addMovil.Name = "addMovil";
            this.addMovil.Size = new System.Drawing.Size(110, 43);
            this.addMovil.TabIndex = 4;
            this.addMovil.Text = "Insertar";
            this.addMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addMovil.UseVisualStyleBackColor = true;
            this.addMovil.Click += new System.EventHandler(this.addMovil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmdFacturar);
            this.groupBox2.Controls.Add(this.lblTotalApagar);
            this.groupBox2.Controls.Add(this.lblCantidadEnLista);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(562, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 193);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // cmdFacturar
            // 
            this.cmdFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFacturar.Image = global::BussManager.Properties.Resources.dollar_symbol__2_;
            this.cmdFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdFacturar.Location = new System.Drawing.Point(29, 131);
            this.cmdFacturar.Name = "cmdFacturar";
            this.cmdFacturar.Size = new System.Drawing.Size(141, 52);
            this.cmdFacturar.TabIndex = 4;
            this.cmdFacturar.Text = "Facturar";
            this.cmdFacturar.UseVisualStyleBackColor = true;
            this.cmdFacturar.Click += new System.EventHandler(this.cmdFacturar_Click);
            // 
            // lblTotalApagar
            // 
            this.lblTotalApagar.AutoSize = true;
            this.lblTotalApagar.Location = new System.Drawing.Point(108, 68);
            this.lblTotalApagar.Name = "lblTotalApagar";
            this.lblTotalApagar.Size = new System.Drawing.Size(16, 18);
            this.lblTotalApagar.TabIndex = 3;
            this.lblTotalApagar.Text = "0";
            this.lblTotalApagar.Click += new System.EventHandler(this.lblTotalApagar_Click);
            // 
            // lblCantidadEnLista
            // 
            this.lblCantidadEnLista.AutoSize = true;
            this.lblCantidadEnLista.Location = new System.Drawing.Point(108, 31);
            this.lblCantidadEnLista.Name = "lblCantidadEnLista";
            this.lblCantidadEnLista.Size = new System.Drawing.Size(16, 18);
            this.lblCantidadEnLista.TabIndex = 2;
            this.lblCantidadEnLista.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total a pagar:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total equipos: ";
            // 
            // frmVentaEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(768, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addMovil);
            this.Controls.Add(this.lstVentaEquipos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(671, 382);
            this.Name = "frmVentaEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta Equipos celulares";
            this.Load += new System.EventHandler(this.frmVentaEquipos_Load);
            this.Resize += new System.EventHandler(this.frmVentaEquipos_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblClaseModelo;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstVentaEquipos;
        private System.Windows.Forms.ColumnHeader headEquipo;
        private System.Windows.Forms.ColumnHeader headIMEI;
        private System.Windows.Forms.ColumnHeader headPrecio;
        private System.Windows.Forms.ColumnHeader headClase;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button addMovil;
        private System.Windows.Forms.ColumnHeader headSerieModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCantidadEnLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalApagar;
        private System.Windows.Forms.Button cmdFacturar;
    }
}