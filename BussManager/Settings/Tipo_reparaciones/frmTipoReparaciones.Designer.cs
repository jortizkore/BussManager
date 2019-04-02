namespace BussManager.Settings.Tipo_reparaciones
{
    partial class frmTipoReparaciones
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
            this.groupTipoReparaciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdModificarTipoReparacion = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.txtTipoReparacion = new System.Windows.Forms.TextBox();
            this.cmdInsertarTipoReparacion = new System.Windows.Forms.Button();
            this.gridTipoReparaciones = new System.Windows.Forms.DataGridView();
            this.groupTipoReparaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTipoReparaciones
            // 
            this.groupTipoReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTipoReparaciones.Controls.Add(this.cmdInsertarTipoReparacion);
            this.groupTipoReparaciones.Controls.Add(this.txtTipoReparacion);
            this.groupTipoReparaciones.Controls.Add(this.sd);
            this.groupTipoReparaciones.Controls.Add(this.lblIdModificarTipoReparacion);
            this.groupTipoReparaciones.Controls.Add(this.label1);
            this.groupTipoReparaciones.Location = new System.Drawing.Point(2, 3);
            this.groupTipoReparaciones.Name = "groupTipoReparaciones";
            this.groupTipoReparaciones.Size = new System.Drawing.Size(340, 100);
            this.groupTipoReparaciones.TabIndex = 0;
            this.groupTipoReparaciones.TabStop = false;
            this.groupTipoReparaciones.Text = "Campos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // lblIdModificarTipoReparacion
            // 
            this.lblIdModificarTipoReparacion.AutoSize = true;
            this.lblIdModificarTipoReparacion.Location = new System.Drawing.Point(40, 28);
            this.lblIdModificarTipoReparacion.Name = "lblIdModificarTipoReparacion";
            this.lblIdModificarTipoReparacion.Size = new System.Drawing.Size(13, 13);
            this.lblIdModificarTipoReparacion.TabIndex = 1;
            this.lblIdModificarTipoReparacion.Text = "0";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(10, 54);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(81, 13);
            this.sd.TabIndex = 2;
            this.sd.Text = "Tipo reparación";
            // 
            // txtTipoReparacion
            // 
            this.txtTipoReparacion.Location = new System.Drawing.Point(97, 51);
            this.txtTipoReparacion.Name = "txtTipoReparacion";
            this.txtTipoReparacion.Size = new System.Drawing.Size(159, 20);
            this.txtTipoReparacion.TabIndex = 3;
            // 
            // cmdInsertarTipoReparacion
            // 
            this.cmdInsertarTipoReparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInsertarTipoReparacion.Location = new System.Drawing.Point(263, 49);
            this.cmdInsertarTipoReparacion.Name = "cmdInsertarTipoReparacion";
            this.cmdInsertarTipoReparacion.Size = new System.Drawing.Size(69, 23);
            this.cmdInsertarTipoReparacion.TabIndex = 4;
            this.cmdInsertarTipoReparacion.Text = "Insertar";
            this.cmdInsertarTipoReparacion.UseVisualStyleBackColor = true;
            this.cmdInsertarTipoReparacion.Click += new System.EventHandler(this.cmdInsertarTipoReparacion_Click);
            // 
            // gridTipoReparaciones
            // 
            this.gridTipoReparaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTipoReparaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridTipoReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipoReparaciones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridTipoReparaciones.Location = new System.Drawing.Point(2, 145);
            this.gridTipoReparaciones.Name = "gridTipoReparaciones";
            this.gridTipoReparaciones.Size = new System.Drawing.Size(340, 154);
            this.gridTipoReparaciones.TabIndex = 1;
            this.gridTipoReparaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTipoReparaciones_CellDoubleClick);
            // 
            // frmTipoReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 311);
            this.Controls.Add(this.gridTipoReparaciones);
            this.Controls.Add(this.groupTipoReparaciones);
            this.MinimumSize = new System.Drawing.Size(362, 350);
            this.Name = "frmTipoReparaciones";
            this.Text = "Tipo reparaciones";
            this.Load += new System.EventHandler(this.frmTipoReparaciones_Load);
            this.groupTipoReparaciones.ResumeLayout(false);
            this.groupTipoReparaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoReparaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTipoReparaciones;
        private System.Windows.Forms.Button cmdInsertarTipoReparacion;
        private System.Windows.Forms.TextBox txtTipoReparacion;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.Label lblIdModificarTipoReparacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridTipoReparaciones;
    }
}