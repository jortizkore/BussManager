﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Login;
using BussManager.Settings.clase_equipos;
using BussManager.Settings.modelo_equipos;
using BussManager.Settings.Tipo_reparaciones;
using BussManager.Inventario.Equipos;
using BussManager.Venta.Equipos;
using BussManager.Venta.Accesorios;
using BussManager.Reparaciones;
using BussManager.Inventario.Accesorios;
using BussManager.Reportes;
using BussManager.Settings;

namespace BussManager
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ManejadorDePermisos.ComprobarPermisos(this);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            UsuarioLogueado.CerrarSession();
            UsuarioLogueado.frm.Show();
        }

        private void tipoReparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTipoReparaciones = new frmTipoReparaciones();
            frmTipoReparaciones.ShowDialog();
        }

        private void marcaEqioposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeloEquipos frmModeloEquipos = new frmModeloEquipos();
            frmModeloEquipos.ShowDialog();
        }

        private void claseDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClases frmClaseEquipos = new frmClases();
            frmClaseEquipos.ShowDialog();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraAccesorio frmCompraAcc = new frmCompraAccesorio();
            frmCompraAcc.ShowDialog();
        }

        private void registrarPerdidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerdidaAccesorio frm = new frmPerdidaAccesorio();
            frm.ShowDialog();
        }

        private void cmdLlamarVentaAcc_Click(object sender, EventArgs e)
        {
            frmVentasAcc frm = new Venta.Accesorios.frmVentasAcc();
            frm.ShowDialog();
        }

        private void cmdLlamarVentaEquios_Click(object sender, EventArgs e)
        {
            frmVentaEquipos frm = new Venta.Equipos.frmVentaEquipos();
            frm.ShowDialog();

        }

        private void reporteDeVentasAccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta.Accesorios.FrmAccReportes frm = new Venta.Accesorios.FrmAccReportes();
            frm.Show();
        }

        private void ventaEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipos frmEquipo = new frmEquipos();
            frmEquipo.ShowDialog();
        }

        private void reporteVentaEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta.Equipos.frmVentaEquipos frm = new Venta.Equipos.frmVentaEquipos();
            frm.ShowDialog();
        }

        private void reporteVentaEquiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venta.Equipos.frmReporteVentaEquipos frm = new Venta.Equipos.frmReporteVentaEquipos();
            frm.ShowDialog();
        }

        private void btnCargarFrmReparaciones_Click(object sender, EventArgs e)
        {
            frmReparaciones frmReparaciones = new frmReparaciones();
            frmReparaciones.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReporteEquipos_Click(object sender, EventArgs e)
        {
            Venta.Equipos.frmReporteVentaEquipos frm = new Venta.Equipos.frmReporteVentaEquipos();
            frm.ShowDialog();
        }

        private void btnReporteAcc_Click(object sender, EventArgs e)
        {
            Venta.Accesorios.FrmAccReportes frm = new Venta.Accesorios.FrmAccReportes();
            frm.ShowDialog();
        }

        private void btnReporteReparaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracionModeloEquipos_Click(object sender, EventArgs e)
        {
            frmModeloEquipos frmModeloEquipos = new frmModeloEquipos();
            frmModeloEquipos.ShowDialog();
        }

        private void btnConfiguracionTipoReparacion_Click(object sender, EventArgs e)
        {
            var frmTipoReparaciones = new frmTipoReparaciones();
            frmTipoReparaciones.ShowDialog();
        }

        private void btnConfiguracionClaseEquipos_Click(object sender, EventArgs e)
        {
            frmClases frmClaseEquipos = new frmClases();
            frmClaseEquipos.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmCompraAccesorio frm = new frmCompraAccesorio();
            frm.ShowDialog();
        }

        private void btnVerReporteGeneralMensual_Click(object sender, EventArgs e)
        {
            frmReporteGeneralMensual frm = new frmReporteGeneralMensual();
            frm.ShowDialog();
        }

        private void btnVerReportePerdida_Click(object sender, EventArgs e)
        {
            frmPerdidaAccesorio frm = new frmPerdidaAccesorio();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            UsuarioLogueado.frm.Show();
        }

        private void cmdInventarioCelulares_Click(object sender, EventArgs e)
        {
            frmEquipos frm = new frmEquipos();
            frm.ShowDialog();
        }

        private void cmdVentaCelulares_Click(object sender, EventArgs e)
        {
            frmVentaEquipos frm = new Venta.Equipos.frmVentaEquipos();
            frm.ShowDialog();

        }

        private void cmdVerReporteCelulares_Click(object sender, EventArgs e)
        {
            frmReporteVentaEquipos frm = new frmReporteVentaEquipos();
            frm.ShowDialog();
        }

        private void cmdVerReparaciones_Click(object sender, EventArgs e)
        {
            frmReparaciones frm = new frmReparaciones();
            frm.ShowDialog();
        }

        private void cmdReporteReparaciones_Click(object sender, EventArgs e)
        {
            frmReporteReparaciones frm = new frmReporteReparaciones();
            frm.ShowDialog();
        }
    }
}
