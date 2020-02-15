using System;
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
using BussManager.Inventario.Accesorios;

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
            BussManager.recursos_humanos.ServicioRecursoHumano rh = new recursos_humanos.ServicioRecursoHumano();

            // testGrid.DataSource = rh.TraerRecursosHumanos();
            // this.Enabled = false;
            // loginToolStripMenuItem_Click(null, null);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Enabled = true;
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
            frmEquipos frmEquipo = new frmEquipos();
            frmEquipo.ShowDialog();
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
    }
}
