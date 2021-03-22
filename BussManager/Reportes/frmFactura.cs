using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Settings;

namespace BussManager.Reportes
{
    public partial class frmFactura : Form
    {
        decimal total = 0;
        decimal efectivo = 0;
        decimal devolver = 0;
        List<Venta.Accesorios.VentaAccesorio> lista;

        public frmFactura(List<Venta.Accesorios.VentaAccesorio> datasource, 
                decimal totalAPagar, decimal pagaCon, decimal devuelta)
        {
            InitializeComponent();
            total = totalAPagar;
            efectivo = pagaCon;
            devolver = devuelta;
            lista = datasource;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            Settings.InformacionDeEmpresa.CargarInformacion();

            Microsoft.Reporting.WinForms.ReportParameter[] parametros = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("TotalaPagar", total.ToString("0")),
                new Microsoft.Reporting.WinForms.ReportParameter("PagaCon", efectivo.ToString("0")),
                new Microsoft.Reporting.WinForms.ReportParameter("Devuelta", devolver.ToString("0")),
                new Microsoft.Reporting.WinForms.ReportParameter("DireccionCompania", InformacionDeEmpresa.Direccion),
                new Microsoft.Reporting.WinForms.ReportParameter("NombreCompania", InformacionDeEmpresa.Nombre),
                new Microsoft.Reporting.WinForms.ReportParameter("TelefonoCompania", InformacionDeEmpresa.Telefono),
                new Microsoft.Reporting.WinForms.ReportParameter("Fecha", DateTime.Now.ToString("dd/MM/yyyy hh:mm")),
            };
            this.reportViewer.LocalReport.SetParameters(parametros);
            var binding = new BindingSource();
            binding.DataSource = lista;
            var bs = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetVentaAcc", binding);
            this.reportViewer.LocalReport.DataSources.Add(bs);
            this.reportViewer.RefreshReport();
        }
    }
}
    