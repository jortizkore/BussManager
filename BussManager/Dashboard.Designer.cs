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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnReporteAcc = new System.Windows.Forms.Button();
            this.cmdLlamarVentaAcc = new System.Windows.Forms.Button();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentaEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentaEquiposToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPerdidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasAccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaEqioposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claseDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reportes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Configuración";
            // 
            // btnInventario
            // 
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Image = global::BussManager.Properties.Resources.box__1_;
            this.btnInventario.Location = new System.Drawing.Point(508, 116);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(143, 98);
            this.btnInventario.TabIndex = 6;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnReporteAcc
            // 
            this.btnReporteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteAcc.Image = global::BussManager.Properties.Resources.trade_report_reports_documents_2351;
            this.btnReporteAcc.Location = new System.Drawing.Point(259, 116);
            this.btnReporteAcc.Name = "btnReporteAcc";
            this.btnReporteAcc.Size = new System.Drawing.Size(143, 98);
            this.btnReporteAcc.TabIndex = 5;
            this.btnReporteAcc.Text = "Reporte";
            this.btnReporteAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteAcc.UseVisualStyleBackColor = true;
            this.btnReporteAcc.Click += new System.EventHandler(this.btnReporteAcc_Click);
            // 
            // cmdLlamarVentaAcc
            // 
            this.cmdLlamarVentaAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLlamarVentaAcc.Image = global::BussManager.Properties.Resources.money_finance_business_coin_dollar_icon_1759301;
            this.cmdLlamarVentaAcc.Location = new System.Drawing.Point(18, 116);
            this.cmdLlamarVentaAcc.Name = "cmdLlamarVentaAcc";
            this.cmdLlamarVentaAcc.Size = new System.Drawing.Size(143, 98);
            this.cmdLlamarVentaAcc.TabIndex = 1;
            this.cmdLlamarVentaAcc.Text = "Ventas";
            this.cmdLlamarVentaAcc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLlamarVentaAcc.UseVisualStyleBackColor = true;
            this.cmdLlamarVentaAcc.Click += new System.EventHandler(this.cmdLlamarVentaAcc_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.accesoriosToolStripMenuItem});
            this.inventoryToolStripMenuItem.Image = global::BussManager.Properties.Resources.box1;
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.inventoryToolStripMenuItem.Text = "Inventario";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaEquiposToolStripMenuItem,
            this.reporteVentaEquiposToolStripMenuItem,
            this.reporteVentaEquiposToolStripMenuItem1});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Visible = false;
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // ventaEquiposToolStripMenuItem
            // 
            this.ventaEquiposToolStripMenuItem.Name = "ventaEquiposToolStripMenuItem";
            this.ventaEquiposToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.ventaEquiposToolStripMenuItem.Text = "Inventario equipos";
            this.ventaEquiposToolStripMenuItem.Click += new System.EventHandler(this.ventaEquiposToolStripMenuItem_Click);
            // 
            // reporteVentaEquiposToolStripMenuItem
            // 
            this.reporteVentaEquiposToolStripMenuItem.Name = "reporteVentaEquiposToolStripMenuItem";
            this.reporteVentaEquiposToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.reporteVentaEquiposToolStripMenuItem.Text = "Venta equipos";
            this.reporteVentaEquiposToolStripMenuItem.Click += new System.EventHandler(this.reporteVentaEquiposToolStripMenuItem_Click);
            // 
            // reporteVentaEquiposToolStripMenuItem1
            // 
            this.reporteVentaEquiposToolStripMenuItem1.Name = "reporteVentaEquiposToolStripMenuItem1";
            this.reporteVentaEquiposToolStripMenuItem1.Size = new System.Drawing.Size(263, 30);
            this.reporteVentaEquiposToolStripMenuItem1.Text = "Reporte venta equipos";
            this.reporteVentaEquiposToolStripMenuItem1.Click += new System.EventHandler(this.reporteVentaEquiposToolStripMenuItem1_Click);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompraToolStripMenuItem,
            this.registrarPerdidaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.reporteDeVentasAccToolStripMenuItem});
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            // 
            // registrarCompraToolStripMenuItem
            // 
            this.registrarCompraToolStripMenuItem.Name = "registrarCompraToolStripMenuItem";
            this.registrarCompraToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.registrarCompraToolStripMenuItem.Text = "Registrar compra";
            this.registrarCompraToolStripMenuItem.Click += new System.EventHandler(this.registrarCompraToolStripMenuItem_Click);
            // 
            // registrarPerdidaToolStripMenuItem
            // 
            this.registrarPerdidaToolStripMenuItem.Name = "registrarPerdidaToolStripMenuItem";
            this.registrarPerdidaToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.registrarPerdidaToolStripMenuItem.Text = "Registrar perdida";
            this.registrarPerdidaToolStripMenuItem.Click += new System.EventHandler(this.registrarPerdidaToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // reporteDeVentasAccToolStripMenuItem
            // 
            this.reporteDeVentasAccToolStripMenuItem.Name = "reporteDeVentasAccToolStripMenuItem";
            this.reporteDeVentasAccToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.reporteDeVentasAccToolStripMenuItem.Text = "Reporte de ventas Acc";
            this.reporteDeVentasAccToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasAccToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Image = global::BussManager.Properties.Resources.settings;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Visible = false;
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaEqioposToolStripMenuItem,
            this.tipoReparacionesToolStripMenuItem,
            this.claseDeEquiposToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // marcaEqioposToolStripMenuItem
            // 
            this.marcaEqioposToolStripMenuItem.Name = "marcaEqioposToolStripMenuItem";
            this.marcaEqioposToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.marcaEqioposToolStripMenuItem.Text = "Modelos de equipos";
            this.marcaEqioposToolStripMenuItem.Click += new System.EventHandler(this.marcaEqioposToolStripMenuItem_Click);
            // 
            // tipoReparacionesToolStripMenuItem
            // 
            this.tipoReparacionesToolStripMenuItem.Name = "tipoReparacionesToolStripMenuItem";
            this.tipoReparacionesToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.tipoReparacionesToolStripMenuItem.Text = "Tipo reparaciones";
            this.tipoReparacionesToolStripMenuItem.Click += new System.EventHandler(this.tipoReparacionesToolStripMenuItem_Click);
            // 
            // claseDeEquiposToolStripMenuItem
            // 
            this.claseDeEquiposToolStripMenuItem.Name = "claseDeEquiposToolStripMenuItem";
            this.claseDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.claseDeEquiposToolStripMenuItem.Text = "Clase de Equipos";
            this.claseDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.claseDeEquiposToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = global::BussManager.Properties.Resources.userImage;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.loginToolStripMenuItem.Text = "Cerrar session";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(696, 297);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnReporteAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdLlamarVentaAcc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
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
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasAccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentaEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentaEquiposToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReporteAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInventario;
    }
}

