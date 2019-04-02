namespace BussManager
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaEqioposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.claseDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.accesoriosToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventoryToolStripMenuItem.Text = "Inventario";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaEqioposToolStripMenuItem,
            this.tipoReparacionesToolStripMenuItem,
            this.claseDeEquiposToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // marcaEqioposToolStripMenuItem
            // 
            this.marcaEqioposToolStripMenuItem.Name = "marcaEqioposToolStripMenuItem";
            this.marcaEqioposToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.marcaEqioposToolStripMenuItem.Text = "Modelos de equipos";
            this.marcaEqioposToolStripMenuItem.Click += new System.EventHandler(this.marcaEqioposToolStripMenuItem_Click);
            // 
            // tipoReparacionesToolStripMenuItem
            // 
            this.tipoReparacionesToolStripMenuItem.Name = "tipoReparacionesToolStripMenuItem";
            this.tipoReparacionesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tipoReparacionesToolStripMenuItem.Text = "Tipo reparaciones";
            this.tipoReparacionesToolStripMenuItem.Click += new System.EventHandler(this.tipoReparacionesToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // testGrid
            // 
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Location = new System.Drawing.Point(16, 84);
            this.testGrid.Name = "testGrid";
            this.testGrid.Size = new System.Drawing.Size(852, 150);
            this.testGrid.TabIndex = 1;
            // 
            // claseDeEquiposToolStripMenuItem
            // 
            this.claseDeEquiposToolStripMenuItem.Name = "claseDeEquiposToolStripMenuItem";
            this.claseDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.claseDeEquiposToolStripMenuItem.Text = "Clase de Equipos";
            this.claseDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.claseDeEquiposToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.testGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaEqioposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoReparacionesToolStripMenuItem;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claseDeEquiposToolStripMenuItem;
    }
}

