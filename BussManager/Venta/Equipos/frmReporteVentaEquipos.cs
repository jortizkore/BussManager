using BussManager.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussManager.Venta.Equipos
{
    public partial class frmReporteVentaEquipos : Form
    {

        Inventario.Equipos.EquipoMovil servEquipo = new Inventario.Equipos.EquipoMovil();

        public frmReporteVentaEquipos()
        {
            InitializeComponent();
        }

        void CargargridReporteVentasEquipos()
        {
            servEquipo = new Inventario.Equipos.EquipoMovil();
            var listaEquiposVendiods = servEquipo.TraerEquiposVendidos()
                .Where(x=>x.FechaVenta >= dtFechaInicio.Value && x.FechaVenta <=dtFechaFin.Value)
                .ToList();

            if (listaEquiposVendiods.Count < 1)
            {
                MessageManager.InfoMessage("No hay datos para mostrar en este lapso de tiempo");
                return;
            }

            if (chFiltroReporteVentaEquipos.Checked)
            {
                var listaFiltrada = listaEquiposVendiods.Where(c => c.modelo.Contains(txtFiltroModeloReporteVenta.Text)).ToList();
                listaEquiposVendiods = listaFiltrada;
            }

            grdReporteVentasEquipos.DataSource = listaEquiposVendiods;
            grdReporteVentasEquipos.Refresh();

            RefrescarTotales(listaEquiposVendiods);
            
        }

        void RefrescarTotales(List<Inventario.Equipos.EquipoVendido> equiposVendidos)
        {
            if (equiposVendidos.Count < 1)
                return;

            var ganancias = equiposVendidos.Sum(x => x.precio - x.costo);
            var totalVentas = equiposVendidos.Sum(x => x.precio);
            var totalcosto = equiposVendidos.Sum(x => x.costo);

            lblGananciasReporteVentaEquipos.Text = ganancias.ToString("c");
            lblPorcentajeGananciasEquipos.Text = ((ganancias / totalVentas) * 100).ToString("#.#") + "%";
            lblReporteCantidadEquiposVendidos.Text = equiposVendidos.Count.ToString();
            lblTotalVentasEquios.Text = totalVentas.ToString("c");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmReporteVentaEquipos_Load(object sender, EventArgs e)
        {
            FijarRangoDeMes(DateTime.Now.Month);
        }


        void FijarRangoDeMes(int month)
        {
            try
            {
                var esteMes = month;
                var esteAnio = DateTime.Now.Year;
                var diasDelMes = DateTime.DaysInMonth(esteAnio, esteMes);
                var primerDia = Convert.ToDateTime($"{esteAnio}-{esteMes.ToString()}-01");
                var ultimoDia = Convert.ToDateTime($"{esteAnio}-{esteMes}-{diasDelMes}");

                dtFechaInicio.Value = primerDia;
                dtFechaFin.Value = ultimoDia;
            }
            catch (Exception)
            {
                
            }

        }

        void FijarAnchoColumnasGridReporteVentasEquipos()
        {
            try
            {
                if (grdReporteVentasEquipos.Columns.Count > 0)
                {
                    foreach (DataGridViewColumn col in grdReporteVentasEquipos.Columns)
                    {
                        col.Width = (grdReporteVentasEquipos.Width / grdReporteVentasEquipos.Columns.Count);
                    }
                }
            }
            catch (Exception)
            {

            }
}
        private void chFiltroReporteVentaEquipos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmReporteVentaEquipos_Resize(object sender, EventArgs e)
        {
            FijarAnchoColumnasGridReporteVentasEquipos();
        }

        private void cmdCargarReporteVentasEquipo_Click(object sender, EventArgs e)
        {
            CargargridReporteVentasEquipos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
