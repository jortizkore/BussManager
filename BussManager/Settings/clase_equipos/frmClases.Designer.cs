namespace BussManager.Settings.clase_equipos
{
    partial class frmClases
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
            this.tabControlClases = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInsertarClase = new System.Windows.Forms.TextBox();
            this.cmdInsertarClase = new System.Windows.Forms.Button();
            this.gridClases = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIDModificarClase = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.txtModificarClase = new System.Windows.Forms.TextBox();
            this.cmdModificarClase = new System.Windows.Forms.Button();
            this.txtInsertarComentarioClase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModificaComentarioClase = new System.Windows.Forms.TextBox();
            this.tabControlClases.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClases)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlClases
            // 
            this.tabControlClases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClases.Controls.Add(this.tabPage1);
            this.tabControlClases.Controls.Add(this.tabPage2);
            this.tabControlClases.Location = new System.Drawing.Point(12, 12);
            this.tabControlClases.Name = "tabControlClases";
            this.tabControlClases.SelectedIndex = 0;
            this.tabControlClases.Size = new System.Drawing.Size(628, 146);
            this.tabControlClases.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtInsertarComentarioClase);
            this.tabPage1.Controls.Add(this.cmdInsertarClase);
            this.tabPage1.Controls.Add(this.txtInsertarClase);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clases";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtModificaComentarioClase);
            this.tabPage2.Controls.Add(this.cmdModificarClase);
            this.tabPage2.Controls.Add(this.txtModificarClase);
            this.tabPage2.Controls.Add(this.lbld);
            this.tabPage2.Controls.Add(this.lblIDModificarClase);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(232, 120);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar clases";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clase";
            // 
            // txtInsertarClase
            // 
            this.txtInsertarClase.Location = new System.Drawing.Point(45, 20);
            this.txtInsertarClase.Name = "txtInsertarClase";
            this.txtInsertarClase.Size = new System.Drawing.Size(73, 20);
            this.txtInsertarClase.TabIndex = 1;
            // 
            // cmdInsertarClase
            // 
            this.cmdInsertarClase.Location = new System.Drawing.Point(134, 18);
            this.cmdInsertarClase.Name = "cmdInsertarClase";
            this.cmdInsertarClase.Size = new System.Drawing.Size(75, 23);
            this.cmdInsertarClase.TabIndex = 2;
            this.cmdInsertarClase.Text = "Insertar";
            this.cmdInsertarClase.UseVisualStyleBackColor = true;
            this.cmdInsertarClase.Click += new System.EventHandler(this.cmdInsertarClase_Click);
            // 
            // gridClases
            // 
            this.gridClases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClases.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClases.Location = new System.Drawing.Point(12, 164);
            this.gridClases.Name = "gridClases";
            this.gridClases.Size = new System.Drawing.Size(620, 110);
            this.gridClases.TabIndex = 1;
            this.gridClases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClases_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // lblIDModificarClase
            // 
            this.lblIDModificarClase.AutoSize = true;
            this.lblIDModificarClase.Location = new System.Drawing.Point(32, 10);
            this.lblIDModificarClase.Name = "lblIDModificarClase";
            this.lblIDModificarClase.Size = new System.Drawing.Size(13, 13);
            this.lblIDModificarClase.TabIndex = 1;
            this.lblIDModificarClase.Text = "0";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(6, 34);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(33, 13);
            this.lbld.TabIndex = 2;
            this.lbld.Text = "Clase";
            // 
            // txtModificarClase
            // 
            this.txtModificarClase.Location = new System.Drawing.Point(45, 31);
            this.txtModificarClase.Name = "txtModificarClase";
            this.txtModificarClase.Size = new System.Drawing.Size(87, 20);
            this.txtModificarClase.TabIndex = 3;
            // 
            // cmdModificarClase
            // 
            this.cmdModificarClase.Location = new System.Drawing.Point(138, 29);
            this.cmdModificarClase.Name = "cmdModificarClase";
            this.cmdModificarClase.Size = new System.Drawing.Size(75, 23);
            this.cmdModificarClase.TabIndex = 4;
            this.cmdModificarClase.Text = "Modificar";
            this.cmdModificarClase.UseVisualStyleBackColor = true;
            this.cmdModificarClase.Click += new System.EventHandler(this.cmdModificarClase_Click);
            // 
            // txtInsertarComentarioClase
            // 
            this.txtInsertarComentarioClase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertarComentarioClase.Location = new System.Drawing.Point(9, 66);
            this.txtInsertarComentarioClase.Multiline = true;
            this.txtInsertarComentarioClase.Name = "txtInsertarComentarioClase";
            this.txtInsertarComentarioClase.Size = new System.Drawing.Size(605, 48);
            this.txtInsertarComentarioClase.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentario";
            // 
            // txtModificaComentarioClase
            // 
            this.txtModificaComentarioClase.Location = new System.Drawing.Point(9, 70);
            this.txtModificaComentarioClase.Multiline = true;
            this.txtModificaComentarioClase.Name = "txtModificaComentarioClase";
            this.txtModificaComentarioClase.Size = new System.Drawing.Size(204, 44);
            this.txtModificaComentarioClase.TabIndex = 5;
            // 
            // frmClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 286);
            this.Controls.Add(this.gridClases);
            this.Controls.Add(this.tabControlClases);
            this.Name = "frmClases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.frmClases_Load);
            this.tabControlClases.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClases;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cmdInsertarClase;
        private System.Windows.Forms.TextBox txtInsertarClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridClases;
        private System.Windows.Forms.Button cmdModificarClase;
        private System.Windows.Forms.TextBox txtModificarClase;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblIDModificarClase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsertarComentarioClase;
        private System.Windows.Forms.TextBox txtModificaComentarioClase;
    }
}