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

        public List<EquipoVendido> TraerEquiposVendidos()
        {
            db = new ConnectionSettings();
            var list = new List<EquipoVendido>();
            var query = "select cv.id_celular, mc.descripcion as 'marca'"
                + ", c.clase as 'clase', cv.IMEI, cv.costo, cv.precio_venta"
                + ", cv.fecha_venta, pr.descripcion as 'proveedor', cv.codigo_modelo"
                + " from celulares_vendidos cv"
                + " join modelo_celulares mc on cv.marca = mc.id_marca"
                + " join clase c on c.id_clase = cv.clase"
                + " join proveedores pr on pr.id_proveedor = cv.proveedor";

            var jsonResult = db.bringJsonData(query);

            if (jsonResult != string.Empty)
            {
                var result = JArray.Parse(jsonResult);
                foreach (var item in result)
                {
                    var cel = convertFromJson_EquipoVendido(item);
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
                codigoModelo = json["codigo_modelo"].ToString()
            };
        }

        private EquipoVendido convertFromJson_EquipoVendido(JToken json)
        {
            try
            {

                var result = new EquipoVendido
                {
                    id_equipo = int.Parse(json["id_celular"].ToString()),
                    modelo = json["marca"].ToString(),
                    clase = json["clase"].ToString(),
                    IMEI = json["IMEI"].ToString(),
                    costo = decimal.Parse(json["costo"].ToString()),
                    precio = decimal.Parse(json["precio_venta"].ToString()),
                    FechaVenta = DateTime.Parse(json["fecha_venta"].ToString()),
                    proveedor = json["proveedor"].ToString(),
                    codigoModelo = json["codigo_modelo"].ToString()
                };

                return result;

            }
            catch (Exception ex)
            {
                MessageManager.AlerMessage(ex.Message);
            }
            return new EquipoVendido();

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
            db = new ConnectionSettings();

            try
            {
                foreach (var cel in listaEquipos)
                {
                    var vendido = venderEquipo(cel);
                    if (!vendido)
                    {
                        result = false;
                    }
                }
                
                return result;
            }
            catch (Exception)
            {
                result = false;
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
    public class EquipoVendido
    {
        public int id_equipo { get; set; }
        public string modelo { get; set; }
        public string clase { get; set; }
        public string IMEI { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }
        public DateTime FechaVenta { get; set; }
        public string proveedor { get; set; }
        public string codigoModelo { get; set; }
    }
}
