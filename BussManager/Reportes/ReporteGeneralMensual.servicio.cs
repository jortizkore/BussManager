using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;
using System.Data;

namespace BussManager.Reportes
{
    class ReporteGeneralMensualServicio
    {
        ConnectionSettings db = new ConnectionSettings();
        DataTable reporteTabla = new DataTable();

        public ReporteGeneralMensual GenerarReporteGeneralMensual()
        {
            reporteTabla = new DataTable();
            try
            {
                var query = "sp_reporte_general_mensual";
                db.CorrerSP(query);

                query = "select * from reporte_general_mensual";
                reporteTabla = db.BringData(query);

                return deTablaAObjeto(reporteTabla);
            }
            catch (Exception ex)
            {
                MessageManager.ErrorMessage(ex.Message);
            }

            return new ReporteGeneralMensual();
            
        }

        ReporteGeneralMensual deTablaAObjeto(DataTable dt)
        {
            var obj = new ReporteGeneralMensual();
            foreach (DataRow row in dt.Rows)
            {
                obj.GranTotalGanancias = decimal.Parse(row["gran_total_ganancias_mes"].ToString());
                obj.GranTotalInversion = decimal.Parse(row["gran_total_inversion"].ToString());
                obj.GranTotalPerdidas = decimal.Parse(row["gran_total_perdidas"].ToString());
                obj.GranTotalInventario = decimal.Parse(row["grand_total_inventario"].ToString());
            }

            return obj;
        }
    }

    public class ReporteGeneralMensual
    {
        public decimal GranTotalGanancias { get; set; }
        public decimal GranTotalInversion { get; set; }
        public decimal GranTotalPerdidas { get; set; }
        public decimal GranTotalInventario { get; set; }
    }
}
