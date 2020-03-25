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
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPerdidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaEqioposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claseDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdLlamarVentaAcc = new System.Windows.Forms.Button();
            this.cmdLlamarVentaEquios = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
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
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem,
            this.registrarPerdidaToolStripMenuItem,
            this.inventarioToolStripMenuItem});
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registrarCompraToolStripMenuItem.Text = "Registrar compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // registrarPerdidaToolStripMenuItem
            // 
            this.registrarPerdidaToolStripMenuItem.Name = "registrarPerdidaToolStripMenuItem";
            this.registrarPerdidaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registrarPerdidaToolStripMenuItem.Text = "Registrar perdida";
            this.registrarPerdidaToolStripMenuItem.Click += new System.EventHandler(this.registrarPerdidaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
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
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
            // claseDeEquiposToolStripMenuItem
            // 
            this.claseDeEquiposToolStripMenuItem.Name = "claseDeEquiposToolStripMenuItem";
            this.claseDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.claseDeEquiposToolStripMenuItem.Text = "Clase de Equipos";
            this.claseDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.claseDeEquiposToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cmdLlamarVentaAcc
            // 
            this.cmdLlamarVentaAcc.Location = new System.Drawing.Point(23, 62);
            this.cmdLlamarVentaAcc.Name = "cmdLlamarVentaAcc";
            this.cmdLlamarVentaAcc.Size = new System.Drawing.Size(143, 98);
            this.cmdLlamarVentaAcc.TabIndex = 1;
            this.cmdLlamarVentaAcc.Text = "Venta accesorios";
            this.cmdLlamarVentaAcc.UseVisualStyleBackColor = true;
            this.cmdLlamarVentaAcc.Click += new System.EventHandler(this.cmdLlamarVentaAcc_Click);
            // 
            // cmdLlamarVentaEquios
            // 
            this.cmdLlamarVentaEquios.Location = new System.Drawing.Point(223, 62);
            this.cmdLlamarVentaEquios.Name = "cmdLlamarVentaEquios";
            this.cmdLlamarVentaEquios.Size = new System.Drawing.Size(143, 98);
            this.cmdLlamarVentaEquios.TabIndex = 2;
            this.cmdLlamarVentaEquios.Text = "Venta Celulares";
            this.cmdLlamarVentaEquios.UseVisualStyleBackColor = true;
            this.cmdLlamarVentaEquios.Click += new System.EventHandler(this.cmdLlamarVentaEquios_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 204);
            this.Controls.Add(this.cmdLlamarVentaEquios);
            this.Controls.Add(this.cmdLlamarVentaAcc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claseDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPerdidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Button cmdLlamarVentaAcc;
        private System.Windows.Forms.Button cmdLlamarVentaEquios;
    }
}

