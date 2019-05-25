using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;
using Newtonsoft.Json.Linq;

namespace BussManager.Inventario.Accesorios
{

    class ServicioAccesorio
    {
        ConnectionSettings db = new ConnectionSettings();

        public List<Accesorio> TraerAccesorios()
        {
            var returnList = new List<Accesorio>();
            var query = "Select * from accesorios";
            var result = db.bringJsonData(query);

            if (result != string.Empty)
            {
                var JsonResult = JArray.Parse(result);

                foreach (var item in JsonResult)
                {
                    returnList.Add(new Accesorio
                    {
                        Descripcion = item["descripcion"].ToString(),
                        Costo = decimal.Parse(item["costo"].ToString()),
                        Precio = decimal.Parse(item["precio"].ToString())
                    });
                }
            }

            return returnList;
        }


        Accesorio TraerAccesorio(string descripcion)
        {
            try
            {
                var Result = TraerAccesorios().Where(ac => ac.Descripcion == descripcion).FirstOrDefault();
                return Result;
            }
            catch (Exception)
            {
            }

            return new Accesorio();
        }

        public bool InsertarAccesorio(string descripcion, decimal costo, decimal precio)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_accesorio";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@articulo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = descripcion
            });
            parametros.Add(new parametro
            {
                nombre = "@costo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = costo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio",
                tipo = System.Data.SqlDbType.Decimal,
                valor = precio.ToString()

            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
            
        }

        public bool InsertarAccesorio(string descripcion, int cantidad, decimal costo_venta, decimal precio_venta, DateTime fecha_venta)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_venta_accesorio";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@articulo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = descripcion
            });
            parametros.Add(new parametro
            {
                nombre = "@cantidad",
                tipo = System.Data.SqlDbType.Int,
                valor = cantidad.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@costo_venta",
                tipo = System.Data.SqlDbType.Decimal,
                valor = costo_venta.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio_venta",
                tipo = System.Data.SqlDbType.Decimal,
                valor = precio_venta.ToString()

            });
            parametros.Add(new parametro
            {
                nombre = "@fecha_venta",
                tipo = System.Data.SqlDbType.Decimal,
                valor = fecha_venta.ToString()

            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);

        }

    }

    public class Accesorio
    {
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
