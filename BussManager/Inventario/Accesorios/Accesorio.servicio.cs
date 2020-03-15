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
                        ID = int.Parse(item["id_accesorio"].ToString()),
                        Descripcion = item["descripcion"].ToString(),
                        Costo = decimal.Parse(item["costo"].ToString()),
                        Precio = decimal.Parse(item["precio"].ToString())
                    });
                }
            }

            return returnList;
        }
        public List<Accesorio> TraerAccesoriosParaCombo()
        {
            var returnList = new List<Accesorio>();
            var query = "select distinct(descripcion) from accesorios";
            var result = db.bringJsonData(query);

            if (result != string.Empty)
            {
                var JsonResult = JArray.Parse(result);

                foreach (var item in JsonResult)
                {
                    returnList.Add(new Accesorio
                    {
                        Descripcion = item["descripcion"].ToString(),
                     });
                }
            }

            return returnList;
        }

        public Accesorio TraerAccesorio(string descripcion)
        {
            try
            {
                var Result = TraerAccesorios()
                                .Where(ac => ac.Descripcion == descripcion)
                                .FirstOrDefault();
                    
                return Result;
            }
            catch (Exception)
            {
            }

            return new Accesorio();
        }

        public Accesorio TraerAccesorio(int id)
        {
            try
            {
                var Result = TraerAccesorios()
                                .Where(ac => ac.ID == id)
                                .FirstOrDefault();

                return Result;
            }
            catch (Exception)
            {
            }

            return new Accesorio();
        }

        public List<Accesorio> FiltroAccesorios(string descripcion)
        {
            var returnList = new List<Accesorio>();
            var query = $"Select * from accesorios where descripcion like '%{ descripcion }%'";
            var result = db.bringJsonData(query);

            if (result != string.Empty)
            {
                var JsonResult = JArray.Parse(result);

                foreach (var item in JsonResult)
                {
                    returnList.Add(new Accesorio
                    {
                        ID = int.Parse(item["id_accesorio"].ToString()),
                        Descripcion = item["descripcion"].ToString(),
                        Costo = decimal.Parse(item["costo"].ToString()),
                        Precio = decimal.Parse(item["precio"].ToString())
                    });
                }
            }

            return returnList;
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

        public bool InsertarAccesorio(Accesorio acc, int cantidad,  DateTime fecha_venta)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_compra_accesorio";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@accesorio",
                tipo = System.Data.SqlDbType.VarChar,
                valor = acc.Descripcion
            });
            parametros.Add(new parametro
            {
                nombre = "@cantidad",
                tipo = System.Data.SqlDbType.Int,
                valor = cantidad.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@costo_unidad",
                tipo = System.Data.SqlDbType.Decimal,
                valor = acc.Costo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio_venta",
                tipo = System.Data.SqlDbType.Decimal,
                valor = acc.Precio.ToString()

            });
            parametros.Add(new parametro
            {
                nombre = "@fecha_compra",
                tipo = System.Data.SqlDbType.Date,
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

        public int TraerCantidadAccesorio(string acc)
        {
            return FiltroAccesorios(acc).Count;            
        }

    }

    public class Accesorio
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
    }
}
