namespace BussManager.Inventario.Equipos
{
    partial class frmEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipos));
            this.grpEquipos = new System.Windows.Forms.GroupBox();
            this.txtCodigoModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.btnCancelarEquipo = new System.Windows.Forms.Button();
            this.btnGuardarEquipo = new System.Windows.Forms.Button();
            this.cmbClaseEquipo = new System.Windows.Forms.ComboBox();
            this.cmbEquipoCelular = new System.Windows.Forms.ComboBox();
            this.txtPrecioEquipo = new System.Windows.Forms.TextBox();
            this.txtCostoEquipo = new System.Windows.Forms.TextBox();
            this.txtImeiEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdEquipos = new System.Windows.Forms.DataGridView();
            this.txtFiltrarEquipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCantidadEquipos = new System.Windows.Forms.Label();
            this.lblTotalEnEquipos = new System.Windows.Forms.Label();
            this.grpEquipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEquipos
            // 
            this.grpEquipos.Controls.Add(this.txtCodigoModelo);
            this.grpEquipos.Controls.Add(this.label10);
            this.grpEquipos.Controls.Add(this.label7);
            this.grpEquipos.Controls.Add(this.cmbProveedor);
            this.grpEquipos.Controls.Add(this.btnCancelarEquipo);
            this.grpEquipos.Controls.Add(this.btnGuardarEquipo);
            this.grpEquipos.Controls.Add(this.cmbClaseEquipo);
            this.grpEquipos.Controls.Add(this.cmbEquipoCelular);
            this.grpEquipos.Controls.Add(this.txtPrecioEquipo);
            this.grpEquipos.Controls.Add(this.txtCostoEquipo);
            this.grpEquipos.Controls.Add(this.txtImeiEquipo);
            this.grpEquipos.Controls.Add(this.label5);
            this.grpEquipos.Controls.Add(this.label3);
            this.grpEquipos.Controls.Add(this.label4);
            this.grpEquipos.Controls.Add(this.label2);
            this.grpEquipos.Controls.Add(this.label1);
            this.grpEquipos.Location = new System.Drawing.Point(4, 12);
            this.grpEquipos.Name = "grpEquipos";
            this.grpEquipos.Size = new System.Drawing.Size(736, 148);
            this.grpEquipos.TabIndex = 0;
            this.grpEquipos.TabStop = false;
            this.grpEquipos.Text = "Datos";
            // 
            // txtCodigoModelo
            // 
            this.txtCodigoModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoModelo.Location = new System.Drawing.Point(421, 119);
            this.txtCodigoModelo.Name = "txtCodigoModelo";
            this.txtCodigoModelo.Size = new System.Drawing.Size(127, 20);
            this.txtCodigoModelo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cod. Modelo:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(407, 89);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(141, 21);
            this.cmbProveedor.TabIndex = 7;
            // 
            // btnCancelarEquipo
            // 
            this.btnCancelarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEquipo.BackColor = System.Drawing.Color.Red;
            this.btnCancelarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEquipo.Location = new System.Drawing.Point(642, 10);
            this.btnCancelarEquipo.Name = "btnCancelarEquipo";
            this.btnCancelarEquipo.Size = new System.Drawing.Size(84, 30);
            this.btnCancelarEquipo.TabIndex = 6;
            this.btnCancelarEquipo.Text = "Cancelar";
            this.btnCancelarEquipo.UseVisualStyleBackColor = false;
            this.btnCancelarEquipo.Click += new System.EventHandler(this.btnCancelarEquipo_Click);
            // 
            // btnGuardarEquipo
            // 
            this.btnGuardarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEquipo.BackColor = System.Drawing.Color.Blue;
            this.btnGuardarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEquipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarEquipo.Location = new System.Drawing.Point(594, 71);
            this.btnGuardarEquipo.Name = "btnGuardarEquipo";
            this.btnGuardarEquipo.Size = new System.Drawing.Size(132, 68);
            this.btnGuardarEquipo.TabIndex = 5;
            this.btnGuardarEquipo.Text = "Guardar";
            this.btnGuardarEquipo.UseVisualStyleBackColor = false;
            this.btnGuardarEquipo.Click += new System.EventHandler(this.btnGuardarEquipo_Click);
            // 
            // cmbClaseEquipo
            // 
            this.cmbClaseEquipo.FormattingEnabled = true;
            this.cmbClaseEquipo.Location = new System.Drawing.Point(58, 118);
            this.cmbClaseEquipo.Name = "cmbClaseEquipo";
            this.cmbClaseEquipo.Size = new System.Drawing.Size(186, 21);
            this.cmbClaseEquipo.TabIndex = 2;
            // 
            // cmbEquipoCelular
            // 
            this.cmbEquipoCelular.FormattingEnabled = true;
            this.cmbEquipoCelular.Location = new System.Drawing.Point(58, 71);
            this.cmbEquipoCelular.Name = "cmbEquipoCelular";
            this.cmbEquipoCelular.Size = new System.Drawing.Size(186, 21);
            this.cmbEquipoCelular.TabIndex = 1;
            this.cmbEquipoCelular.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoCelular_SelectedIndexChanged);
            // 
            // txtPrecioEquipo
            // 
            this.txtPrecioEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioEquipo.Location = new System.Drawing.Point(388, 54);
            this.txtPrecioEquipo.Name = "txtPrecioEquipo";
            this.txtPrecioEquipo.Size = new System.Drawing.Size(160, 20);
            this.txtPrecioEquipo.TabIndex = 4;
            // 
            // txtCostoEquipo
            // 
            this.txtCostoEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoEquipo.Location = new System.Drawing.Point(388, 24);
            this.txtCostoEquipo.Name = "txtCostoEquipo";
            this.txtCostoEquipo.Size = new System.Drawing.Size(160, 20);
            this.txtCostoEquipo.TabIndex = 3;
            // 
            // txtImeiEquipo
            // 
            this.txtImeiEquipo.Location = new System.Drawing.Point(58, 24);
            this.txtImeiEquipo.Name = "txtImeiEquipo";
            this.txtImeiEquipo.Size = new System.Drawing.Size(186, 20);
            this.txtImeiEquipo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMEI:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clase:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo:";
            // 
            // grdEquipos
            // 
            this.grdEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipos.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEquipos.Location = new System.Drawing.Point(4, 226);
            this.grdEquipos.Name = "grdEquipos";
            this.grdEquipos.Size = new System.Drawing.Size(734, 221);
            this.grdEquipos.TabIndex = 14;
            this.grdEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEquipos_CellDoubleClick);
            this.grdEquipos.Resize += new System.EventHandler(this.grdEquipos_Resize);
            // 
            // txtFiltrarEquipo
            // 
            this.txtFiltrarEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarEquipo.Location = new System.Drawing.Point(58, 200);
            this.txtFiltrarEquipo.Name = "txtFiltrarEquipo";
            this.txtFiltrarEquipo.Size = new System.Drawing.Size(680, 20);
            this.txtFiltrarEquipo.TabIndex = 15;
            this.txtFiltrarEquipo.TextChanged += new System.EventHandler(this.txtFiltrarEquipo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total:";
            // 
            // lblCantidadEquipos
            // 
            this.lblCantidadEquipos.AutoSize = true;
            this.lblCantidadEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadEquipos.Location = new System.Drawing.Point(81, 173);
            this.lblCantidadEquipos.Name = "lblCantidadEquipos";
            this.lblCantidadEquipos.Size = new System.Drawing.Size(17, 17);
            this.lblCantidadEquipos.TabIndex = 19;
            this.lblCantidadEquipos.Text = "0";
            // 
            // lblTotalEnEquipos
            // 
            this.lblTotalEnEquipos.AutoSize = true;
            this.lblTotalEnEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnEquipos.Location = new System.Drawing.Point(312, 172);
            this.lblTotalEnEquipos.Name = "lblTotalEnEquipos";
            this.lblTotalEnEquipos.Size = new System.Drawing.Size(17, 17);
            this.lblTotalEnEquipos.TabIndex = 19;
            this.lblTotalEnEquipos.Text = "0";
            // 
            // frmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.lblTotalEnEquipos);
            this.Controls.Add(this.lblCantidadEquipos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiltrarEquipo);
            this.Controls.Add(this.grdEquipos);
            this.Controls.Add(this.grpEquipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.frmEquipos_Load);
            this.grpEquipos.ResumeLayout(false);
            this.grpEquipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImeiEquipo;
        private System.Windows.Forms.ComboBox cmbClaseEquipo;
        private System.Windows.Forms.ComboBox cmbEquipoCelular;
        private System.Windows.Forms.TextBox txtPrecioEquipo;
        private System.Windows.Forms.TextBox txtCostoEquipo;
        private System.Windows.Forms.Button btnCancelarEquipo;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.DataGridView grdEquipos;
        private System.Windows.Forms.TextBox txtFiltrarEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCantidadEquipos;
        private System.Windows.Forms.Label lblTotalEnEquipos;
        private System.Windows.Forms.TextBox txtCodigoModelo;
        private System.Windows.Forms.Label label10;
    }
}