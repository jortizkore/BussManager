namespace BussManager.Venta.Accesorios
{
    partial class frmVentasAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasAcc));
            this.cmbArticuloSeleccionado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadArticulos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.dtFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadEnInventario = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstVentas = new System.Windows.Forms.ListView();
            this.Accesorio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnAgregarALaLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbArticuloSeleccionado
            // 
            this.cmbArticuloSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticuloSeleccionado.FormattingEnabled = true;
            this.cmbArticuloSeleccionado.Location = new System.Drawing.Point(12, 56);
            this.cmbArticuloSeleccionado.Name = "cmbArticuloSeleccionado";
            this.cmbArticuloSeleccionado.Size = new System.Drawing.Size(288, 28);
            this.cmbArticuloSeleccionado.TabIndex = 0;
            this.cmbArticuloSeleccionado.SelectedIndexChanged += new System.EventHandler(this.cmbArticuloSeleccionado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Productos:";
            // 
            // lblCantidadArticulos
            // 
            this.lblCantidadArticulos.AutoSize = true;
            this.lblCantidadArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadArticulos.Location = new System.Drawing.Point(102, 21);
            this.lblCantidadArticulos.Name = "lblCantidadArticulos";
            this.lblCantidadArticulos.Size = new System.Drawing.Size(20, 22);
            this.lblCantidadArticulos.TabIndex = 3;
            this.lblCantidadArticulos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "A pagar:";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(309, 18);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(20, 22);
            this.lblTotalAPagar.TabIndex = 3;
            this.lblTotalAPagar.Text = "0";
            // 
            // dtFechaFactura
            // 
            this.dtFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFactura.Location = new System.Drawing.Point(399, 2);
            this.dtFechaFactura.Name = "dtFechaFactura";
            this.dtFechaFactura.Size = new System.Drawing.Size(298, 26);
            this.dtFechaFactura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio:";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioArticulo.Location = new System.Drawing.Point(83, 30);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(20, 24);
            this.lblPrecioArticulo.TabIndex = 3;
            this.lblPrecioArticulo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "En inventario:";
            // 
            // lblCantidadEnInventario
            // 
            this.lblCantidadEnInventario.AutoSize = true;
            this.lblCantidadEnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEnInventario.Location = new System.Drawing.Point(143, 88);
            this.lblCantidadEnInventario.Name = "lblCantidadEnInventario";
            this.lblCantidadEnInventario.Size = new System.Drawing.Size(20, 24);
            this.lblCantidadEnInventario.TabIndex = 3;
            this.lblCantidadEnInventario.Text = "0";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(305, 26);
            this.numCantidad.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(76, 27);
            this.numCantidad.TabIndex = 5;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCantidadArticulos);
            this.groupBox1.Controls.Add(this.lblTotalAPagar);
            this.groupBox1.Controls.Add(this.btnFacturar);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // lstVentas
            // 
            this.lstVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Accesorio,
            this.Cantidad,
            this.Precio,
            this.Total});
            this.lstVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVentas.HideSelection = false;
            this.lstVentas.Location = new System.Drawing.Point(15, 208);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(681, 168);
            this.lstVentas.TabIndex = 8;
            this.lstVentas.UseCompatibleStateImageBehavior = false;
            this.lstVentas.View = System.Windows.Forms.View.Details;
            // 
            // Accesorio
            // 
            this.Accesorio.Text = "Accesorio";
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::BussManager.Properties.Resources.wastebasket;
            this.button1.Location = new System.Drawing.Point(621, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 49);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Image = global::BussManager.Properties.Resources.money_finance_business_coin_dollar_icon_1759301;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(483, 11);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(132, 49);
            this.btnFacturar.TabIndex = 2;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnAgregarALaLista
            // 
            this.btnAgregarALaLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarALaLista.Image = global::BussManager.Properties.Resources.arrow_pointing_down__1_;
            this.btnAgregarALaLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarALaLista.Location = new System.Drawing.Point(306, 56);
            this.btnAgregarALaLista.Name = "btnAgregarALaLista";
            this.btnAgregarALaLista.Size = new System.Drawing.Size(113, 35);
            this.btnAgregarALaLista.TabIndex = 2;
            this.btnAgregarALaLista.Text = "Insertar";
            this.btnAgregarALaLista.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregarALaLista.UseVisualStyleBackColor = true;
            this.btnAgregarALaLista.Click += new System.EventHandler(this.btnAgregarALaLista_Click);
            // 
            // frmVentasAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(709, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.dtFechaFactura);
            this.Controls.Add(this.lblCantidadEnInventario);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarALaLista);
            this.Controls.Add(this.cmbArticuloSeleccionado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(725, 419);
            this.MinimumSize = new System.Drawing.Size(725, 419);
            this.Name = "frmVentasAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accesorios";
            this.Load += new System.EventHandler(this.frmVentasAcc_Load);
            this.SizeChanged += new System.EventHandler(this.frmVentasAcc_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArticuloSeleccionado;
        private System.Windows.Forms.Button btnAgregarALaLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.DateTimePicker dtFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadEnInventario;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstVentas;
        private System.Windows.Forms.ColumnHeader Accesorio;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}