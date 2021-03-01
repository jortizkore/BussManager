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

namespace BussManager.Reparaciones
{
    public partial class frmReporteReparaciones : Form
    {

        Reparaciones servicioReparaciones = new Reparaciones();
        List<ItemReporte> dataParaTotales = new List<ItemReporte>();

        public frmReporteReparaciones()
        {
            InitializeComponent();
        }

        private void frmReporteReparaciones_Load(object sender, EventArgs e)
        {
            ConfigurarFechaInicioFechaFin();
            RefrescarGrid();
        }

        void RefrescarGrid()
        {
            var data = servicioReparaciones.TraerReporteReparaciones();
            dataParaTotales = CargarDatParaTotales(data);
            CalcularTotales(dataParaTotales);

            grdReporteReparaciones.DataSource = dataParaTotales;
            grdReporteReparaciones.AutoResizeColumns();
        }

        void CalcularTotales(List<ItemReporte> listaReparaciones)
        {
            lblTotalReparaciones.Text = listaReparaciones.Count().ToString();
            lblTotalCosto.Text = listaReparaciones.Sum(x => x.Costo).ToString("c");

            lblTotalGanancias.Text = listaReparaciones
                                        .Where(x => x.Estado == "Completado")
                                        .Sum(x => x.Ganancia).ToString("c");
            lblTotalIngresos.Text = listaReparaciones
                                        .Where(x => x.Estado == "Completado")
                                        .Sum(x => x.Precio).ToString("c");
        }

        void ConfigurarFechaInicioFechaFin()
        {
            Utilidades.FijarRangoDeMes(DateTime.Now.Month, dtFechaInicio, dtFechaFin);
        }

        List<ItemReporte> CargarDatParaTotales(DataTable dt)
        {
            List<ItemReporte> lista = new List<ItemReporte>();

            foreach (DataRow row in dt.Rows)
            {
                ItemReporte item = deTablaAObjeto(row);
                lista.Add(item);
            }

            return lista;
        }

        ItemReporte deTablaAObjeto(DataRow dr)
        {
            ItemReporte item = new ItemReporte
            {
                ID = int.Parse(dr["Cod. Reparacion"].ToString()),
                Equipo = dr["Equipo"].ToString(),
                TrabajoRealizado = dr["Trabajo Realizado"].ToString(),
                Precio = decimal.Parse(dr["Precio"].ToString()),
                Costo = decimal.Parse(dr["Costo"].ToString()),
                Ganancia = decimal.Parse(dr["Ganancia"].ToString()),
                Fecha = DateTime.Parse(dr["fecha_reparacion"].ToString()),
                Tecnico = dr["Tecnico"].ToString(),
                Estado = dr["Estado"].ToString()
            };

            return item;
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltroReparaciones_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var textoDeFiltro = txtFiltroReparaciones.Text;

                if(textoDeFiltro.Trim() != "")
                {
                    var dataFiltrada = FiltrarReparaciones(textoDeFiltro);
                    grdReporteReparaciones.DataSource = dataFiltrada;
                    CalcularTotales(dataFiltrada);
                }
                else
                {
                    grdReporteReparaciones.DataSource = dataParaTotales;
                    CalcularTotales(dataParaTotales);
                }
                
            }
            catch (Exception)
            {
                grdReporteReparaciones.DataSource = dataParaTotales;
            }
        }
        
        List<ItemReporte> FiltrarReparaciones(string filtro)
        {
            List<ItemReporte> lista = new List<ItemReporte>();

            lista = dataParaTotales.Where(x => x.Tecnico.ToLower().Contains(filtro.ToLower())
                                              || x.TrabajoRealizado.ToLower().Contains(filtro.ToLower())
                                              || x.Equipo.ToLower().Contains(filtro.ToLower())).ToList();

            return lista;
        }
                
    }

    public class ItemReporte
    {
        public int ID { get; set; }
        public string Equipo { get; set; }
        public string TrabajoRealizado { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime Fecha { get; set; }
        public string Tecnico { get; set; }
        public string Estado { get; set; }
    }
}
