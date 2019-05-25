using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;
using Newtonsoft.Json.Linq;

namespace BussManager.Inventario.Equipos
{
    class EquipoMovil
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
                proveedor = int.Parse(json["proveedor"].ToString())
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

        public bool GuardarEquipo(int marca, int clase, string imei, decimal costo, decimal precio, int proveedor)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@marca",
                tipo = System.Data.SqlDbType.Int,
                valor = marca.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.Int,
                valor = clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = imei
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
                nombre = "@proveedor",
                tipo = System.Data.SqlDbType.Int,
                valor = proveedor.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public bool venderEquipo(int marca, int clase, string imei, decimal costo, decimal precio, int proveedor)
        {
            db = new ConnectionSettings();
            var sp = "Insertar_Venta_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@marca",
                tipo = System.Data.SqlDbType.Int,
                valor = marca.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.Int,
                valor = clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = imei
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
                nombre = "@fecha_venta",
                tipo = System.Data.SqlDbType.Date,
                valor = DateTime.Today.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@proveedor",
                tipo = System.Data.SqlDbType.Int,
                valor = proveedor.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public bool ModificarEquipo(int marca, int clase, string imei, decimal costo, decimal precio)
        {
            db = new ConnectionSettings();
            var sp = "sp_modificar_celular";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@marca",
                tipo = System.Data.SqlDbType.Int,
                valor = marca.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.Int,
                valor = clase.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@imei",
                tipo = System.Data.SqlDbType.VarChar,
                valor = imei
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
    }
}
