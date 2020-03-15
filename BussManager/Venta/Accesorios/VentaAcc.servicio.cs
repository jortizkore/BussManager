using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BussManager.Settings;
using System.Threading.Tasks;

namespace BussManager.Venta.Accesorios
{
    public class VentaAcc
    {

        private ConnectionSettings db = new ConnectionSettings();


        public bool Guardar(VentaAccesorio vacc)
        {
            List<parametro> parametros = new List<parametro>();
            db = new ConnectionSettings();
            
            try
            {
                var sp = "sp_insertar_venta_accesorio";

                parametro acc = new parametro()
                {
                    nombre = "@accesorio",
                    tipo = SqlDbType.VarChar,
                    valor = vacc.Accesorio
                };
                parametros.Add(acc);
                parametro cant = new parametro()
                {
                    nombre = "@cantidad",
                    tipo = SqlDbType.Int,
                    valor = vacc.Cantidad.ToString()
                };
                parametros.Add(cant);
                parametro prec = new parametro()
                {
                    nombre = "@precio_venta",
                    tipo = SqlDbType.Decimal,
                    valor = vacc.Preciounidad.ToString()
                };
                parametros.Add(prec);
                parametro cost = new parametro()
                {
                    nombre = "@costo_venta",
                    tipo = SqlDbType.Decimal,
                    valor = vacc.Costo.ToString()
                };
                parametros.Add(cost);
                parametro fecha = new parametro()
                {
                    nombre = "@fecha_venta",
                    tipo = SqlDbType.Date,
                    valor = vacc.FechaVenta.ToString()
                };
                parametros.Add(fecha);

                db.CorrerSP(sp, parametros);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        public DataTable TraerVentas()
        {
            DataTable tbl = new DataTable();

            return tbl;
        }

    }

    public class VentaAccesorio
    {
        public int id_venta { get; set; }
        public string Accesorio { get; set; }
        public int Cantidad { get; set; }
        public decimal Preciounidad { get; set; }
        public decimal Costo { get; set; }
        public DateTime FechaVenta { get; set; }
    }
}
