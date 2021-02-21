using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Reportes;
using BussManager.Settings;

namespace BussManager.Reportes

{
    public partial class frmReporteGeneralMensual : Form
    {
        ReporteGeneralMensualServicio servicioReporte = new ReporteGeneralMensualServicio();
        public frmReporteGeneralMensual()
        {
            InitializeComponent();
        }

        private void btnCargarReporteGeneralMensual_Click(object sender, EventArgs e)
        {
            var reporte = new ReporteGeneralMensual();
            reporte = servicioReporte.GenerarReporteGeneralMensual();
            cargarValores(reporte);
        }

        void cargarValores(ReporteGeneralMensual reporte)
        {
            try
            {
                lblGananciasMes.Text = reporte.GranTotalGanancias.ToString("c");
                lblinventarioMes.Text = reporte.GranTotalInventario.ToString("c");
                lblInversionMes.Text = reporte.GranTotalInversion.ToString("c");
                lblPerdidasMes.Text = reporte.GranTotalPerdidas.ToString("c");

                lblBalanceGananciasPerdidas.Text =
                        (reporte.GranTotalGanancias -
                        reporte.GranTotalPerdidas).ToString("c");
            }
            catch (Exception ex)
            {
                MessageManager.ErrorMessage(ex.Message);
            }
        }
    }
}
