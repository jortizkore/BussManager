namespace BussManager.Settings.modelo_equipos
{
    partial class frmModeloEquipos
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
            this.tabInsertarModeloEquipo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdInsertarModelo = new System.Windows.Forms.Button();
            this.txtInsertarModelo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdEditarModelo = new System.Windows.Forms.Button();
            this.txtEditarModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIDModificar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFiltrarModelo = new System.Windows.Forms.TextBox();
            this.gridModeloEquipos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabInsertarModeloEquipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModeloEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabInsertarModeloEquipo);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 129);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInsertarModeloEquipo
            // 
            this.tabInsertarModeloEquipo.Controls.Add(this.groupBox1);
            this.tabInsertarModeloEquipo.Location = new System.Drawing.Point(4, 22);
            this.tabInsertarModeloEquipo.Name = "tabInsertarModeloEquipo";
            this.tabInsertarModeloEquipo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertarModeloEquipo.Size = new System.Drawing.Size(401, 103);
            this.tabInsertarModeloEquipo.TabIndex = 0;
            this.tabInsertarModeloEquipo.Text = "Modelos";
            this.tabInsertarModeloEquipo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdInsertarModelo);
            this.groupBox1.Controls.Add(this.txtInsertarModelo);
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo";
            // 
            // cmdInsertarModelo
            // 
            this.cmdInsertarModelo.Location = new System.Drawing.Point(291, 26);
            this.cmdInsertarModelo.Name = "cmdInsertarModelo";
            this.cmdInsertarModelo.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertarModelo.TabIndex = 1;
            this.cmdInsertarModelo.Text = "Insertar";
            this.cmdInsertarModelo.UseVisualStyleBackColor = true;
            this.cmdInsertarModelo.Click += new System.EventHandler(this.cmdInsertarModelo_Click);
            // 
            // txtInsertarModelo
            // 
            this.txtInsertarModelo.Location = new System.Drawing.Point(44, 29);
            this.txtInsertarModelo.Name = "txtInsertarModelo";
            this.txtInsertarModelo.Size = new System.Drawing.Size(241, 20);
            this.txtInsertarModelo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdEditarModelo);
            this.tabPage2.Controls.Add(this.txtEditarModelo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblIDModificar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 103);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Modelo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdEditarModelo
            // 
            this.cmdEditarModelo.Location = new System.Drawing.Point(300, 43);
            this.cmdEditarModelo.Name = "cmdEditarModelo";
            this.cmdEditarModelo.Size = new System.Drawing.Size(75, 23);
            this.cmdEditarModelo.TabIndex = 5;
            this.cmdEditarModelo.Text = "Editar";
            this.cmdEditarModelo.UseVisualStyleBackColor = true;
            this.cmdEditarModelo.Click += new System.EventHandler(this.cmdEditarModelo_Click);
            // 
            // txtEditarModelo
            // 
            this.txtEditarModelo.Location = new System.Drawing.Point(80, 45);
            this.txtEditarModelo.Name = "txtEditarModelo";
            this.txtEditarModelo.Size = new System.Drawing.Size(211, 20);
            this.txtEditarModelo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // lblIDModificar
            // 
            this.lblIDModificar.AutoSize = true;
            this.lblIDModificar.Location = new System.Drawing.Point(35, 24);
            this.lblIDModificar.Name = "lblIDModificar";
            this.lblIDModificar.Size = new System.Drawing.Size(13, 13);
            this.lblIDModificar.TabIndex = 2;
            this.lblIDModificar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtFiltrarModelo);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // txtFiltrarModelo
            // 
            this.txtFiltrarModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarModelo.Location = new System.Drawing.Point(6, 19);
            this.txtFiltrarModelo.Name = "txtFiltrarModelo";
            this.txtFiltrarModelo.Size = new System.Drawing.Size(357, 20);
            this.txtFiltrarModelo.TabIndex = 0;
            this.txtFiltrarModelo.TextChanged += new System.EventHandler(this.txtFiltrarModelo_TextChanged);
            // 
            // gridModeloEquipos
            // 
            this.gridModeloEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridModeloEquipos.BackgroundColor = System.Drawing.Color.White;
            this.gridModeloEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridModeloEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModeloEquipos.Location = new System.Drawing.Point(9, 228);
            this.gridModeloEquipos.Name = "gridModeloEquipos";
            this.gridModeloEquipos.Size = new System.Drawing.Size(385, 138);
            this.gridModeloEquipos.TabIndex = 3;
            this.gridModeloEquipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridModeloEquipos_CellDoubleClick);
            // 
            // frmModeloEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gridModeloEquipos);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmModeloEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo De Equipos";
            this.Load += new System.EventHandler(this.frmModeloEquipos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInsertarModeloEquipo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModeloEquipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInsertarModeloEquipo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdInsertarModelo;
        private System.Windows.Forms.TextBox txtInsertarModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIDModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditarModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltrarModelo;
        private System.Windows.Forms.DataGridView gridModeloEquipos;
        private System.Windows.Forms.Button cmdEditarModelo;
    }
}