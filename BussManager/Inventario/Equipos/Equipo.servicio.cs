using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;
using Newtonsoft.Json.Linq;

namespace BussManager.Inventario.Equipos
{
    public class EquipoMovil
    {
        ConnectionSettings db;

        public List<Equipo> TraerTodos()
        {
            db = new ConnectionSettings();
            var list = new List<Equipo>();
            var query = "select * from celulares";
            var jsonResult = db.bringJsonData(query);

            if (jsonResult != string.Empty)
            {
                var result = JArray.Parse(jsonResult);
                foreach (var item in result)
                {
                    var cel = convertFromJson(item);
                    list.Add(cel);
                }
            }

            return list;
        }

        public DataTable TraerTodosParaCombo()
        {
            db = new ConnectionSettings();
            var list = new List<Equipo>();
            var query = "select mc.descripcion,c.IMEI from celulares c" +
                        " join modelo_celulares mc" +
                        " on c.marca = mc.id_marca";
            return db.BringData(query);
            
        }

        private Equipo convertFromJson(JToken json)
        {
            return new Equipo
            {
                id_equipo = int.Parse(json["id_celular"].ToString()),
                modelo = int.Parse(json["marca"].ToString()),
                clase = int.Parse(json["clase"].ToString()),
                IMEI = json["IMEI"].ToString(),
                costo = decimal.Parse(json["costo"].ToString()),
                precio = decimal.Parse(json["precio"].ToString()),
                proveedor = int.Parse(json["proveedor"].ToString()),
                codigoModelo = json["Codigo_modelo"].ToString()
            };
        }

        public Equipo TraerEquipo(string imei)
        {
            var equipo = TraerTodos().Where(e => e.IMEI == imei).FirstOrDefault();
            if (equipo != null)
            {
                return equipo;
            }
            return new Equipo();
        }

        public bool GuardarEquipo(Equipo cel)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@marca",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.modelo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = cel.IMEI
            });
            parametros.Add(new parametro
            {
                nombre = "@costo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.costo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.precio.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@proveedor",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.proveedor.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@codigoModelo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = cel.codigoModelo
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public bool venderEquipo(Equipo cel)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_venta_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@id_celular",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.id_equipo.ToString()
            });

            parametros.Add(new parametro
            {
                nombre = "@id_modelo",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.modelo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@id_clase",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = cel.IMEI
            });
            parametros.Add(new parametro
            {
                nombre = "@costo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.costo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio_venta",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.precio.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@fecha_venta",
                tipo = System.Data.SqlDbType.Date,
                valor = DateTime.Today.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@proveedor",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.proveedor.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@codigoModelo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = cel.codigoModelo
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public bool venderListaEquipos(List<Equipo> listaEquipos)
        {
            var result = true;
            var trans = db.BeginTrans("VentaListaEquipos");

            try
            {
                foreach (var cel in listaEquipos)
                {
                   var vendido = venderEquipo(cel);
                    if (!vendido)
                    {
                        result = false;
                        trans.Rollback();
                    }
                }
                if(result)
                trans.Commit();

                return result;
            }
            catch (Exception)
            {
                result = false;
                trans.Rollback();
                return result;
            }
        }

        public bool ModificarEquipo(Equipo cel)
        {
            db = new ConnectionSettings();
            var sp = "sp_modificar_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@marca",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.modelo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.Int,
                valor = cel.clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = cel.IMEI
            });
            parametros.Add(new parametro
            {
                nombre = "@costo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.costo.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@precio",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.precio.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@codigoModelo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = cel.codigoModelo
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.Decimal,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }
    }

    public class Equipo
    {
        public int id_equipo { get; set; }
        public int modelo { get; set; }
        public int clase { get; set; }
        public string IMEI { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }
        public int proveedor { get; set; }
        public string codigoModelo { get; set; }
    }
}
