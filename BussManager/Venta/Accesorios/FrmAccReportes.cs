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
using BussManager.Inventario;

namespace BussManager.Venta.Accesorios
{
    public partial class FrmAccReportes : Form
    {

        Inventario.Accesorios.ServicioAccesorio servAcc = new Inventario.Accesorios.ServicioAccesorio();
        ConnectionSettings db = new ConnectionSettings();

        public FrmAccReportes()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        void FijarRangoDeMes(int month)
        {
            var esteMes = month;
            var esteAnio = DateTime.Now.Year;
            var diasDelMes = DateTime.DaysInMonth(esteAnio, esteMes);
            var primerDia = Convert.ToDateTime($"{esteAnio}-{esteMes.ToString()}-01");
            var ultimoDia = Convert.ToDateTime($"{esteAnio}-{esteMes}-{diasDelMes}");

            dtFechaInicio.Value = primerDia;
            dtFechaFin.Value = ultimoDia;
        }

        private void FrmAccReportes_Load(object sender, EventArgs e)
        {
            FijarRangoDeMes(DateTime.Now.Month);
        }

        void CargarDataReporteVentas()
        {
            var query = ConstruirQuery();
            var table = db.BringData(query);
            var grdItems = ConvertirTablaALista(table);

            grdReporteDeVentasAcc.DataSource = grdItems;
            fijarAnchoColumnasGridVentaAcc();

            refrescarTotales(grdItems);

        }

        void refrescarTotales(List<ItemReporteVenta> listaVentas)
        {
            if (listaVentas.Count > 0)
            {
                var totalVentas = listaVentas.Sum(x => x.Cantidad * x.PrecioUnidad);
                var totalCostoVentas = listaVentas.Sum(x => x.CostoUnidad * x.Cantidad);
                lblTotalVentas.Text = totalVentas.ToString("c");
                lblTotalAccVendios.Text = listaVentas.Sum(x => x.Cantidad).ToString();
                lblTotalGanancias.Text = listaVentas.Sum(x => x.TotalGanancia).ToString("c");
                lblPorcentajeGanancias.Text = ((totalCostoVentas / totalVentas) * 100).ToString("n") + "%";
            }
        }

        List<ItemReporteVenta> ConvertirTablaALista(DataTable data)
        {
            List<ItemReporteVenta> result = new List<ItemReporteVenta>();

            if (data.Rows.Count < 1)
                return result;

            foreach (DataRow row in data.Rows)
            {
                ItemReporteVenta item = new ItemReporteVenta()
                {
                    Accesorio = row["Accesorio"].ToString(),
                    Cantidad = Convert.ToInt32(row["Cantidad"].ToString()),
                    PrecioUnidad = Convert.ToDecimal(row["Precio unidad"].ToString()),
                    CostoUnidad = Convert.ToDecimal(row["Costo unidad"].ToString()),
                    TotalVenta = Convert.ToDecimal(row["Total venta"].ToString()),
                    TotalGanancia = Convert.ToDecimal(row["Total ganancia"].ToString()),
                    FechaVenta = Convert.ToDateTime(row["Fecha venta"].ToString())
                };
                result.Add(item);
            }


            return result;
        }

        void RefrescarGridReporteVentas(DataTable data)
        {
            grdReporteDeVentasAcc.DataSource = data;
            grdReporteDeVentasAcc.Refresh();
            fijarAnchoColumnasGridVentaAcc();
        }

        string ConstruirQuery()
        {
            var fechaInicio = dtFechaInicio.Value;
            var fechaFin = dtFechaFin.Value;

            var resultQuery = "select accesorio as 'Accesorio',"
                            + " cantidad as 'Cantidad', "
                            + " precio_unidad as 'Precio unidad',"
                            + " costo_venta as 'Costo unidad',"
                            + " (precio_unidad * cantidad) as 'Total venta',"
                            + " (precio_unidad - costo_venta) * cantidad as 'Total ganancia',"
                            + " fecha_venta as 'Fecha venta'"
                            + " from ventas_accesorios"
                            + $" where fecha_venta between '{fechaInicio.Date}' and '{fechaFin.Date}'";
            if (chUsarFiltro.Checked)
            {
                resultQuery += $" and accesorio like '%{txtFiltroReporteAccesorio.Text}%'";
            }

            return resultQuery;
        }

        void fijarAnchoColumnasGridVentaAcc()
        {
            try
            {
                if (grdReporteDeVentasAcc.Columns.Count > 0)
                {
                    foreach (DataGridViewColumn col in grdReporteDeVentasAcc.Columns)
                    {
                        col.Width = (grdReporteDeVentasAcc.Width / grdReporteDeVentasAcc.Columns.Count);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmdCargarReporteVentasAcc_Click(object sender, EventArgs e)
        {
            CargarDataReporteVentas();
        }

        private void grdReporteDeVentasAcc_Resize(object sender, EventArgs e)
        {
            fijarAnchoColumnasGridVentaAcc();
        }
    }

    public class ItemReporteVenta
    {
        public string Accesorio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal CostoUnidad { get; set; }
        public decimal TotalVenta { get; set; }
        public decimal TotalGanancia { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
