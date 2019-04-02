using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Settings.Tipo_reparaciones
{
    class TipoReparacionesEquipos
    {
        ConnectionSettings db;

        public List<TipoReparaciones> TraerTiposReparacion()
        {
            db = new ConnectionSettings();
            var list = new List<TipoReparaciones>();
            var query = "select * from tipo_reparaciones";
            var result = db.bringJsonData(query);
            if (result != string.Empty)
            {
                var resultArray = JArray.Parse(result);
                foreach (var item in resultArray)
                {
                    list.Add(new TipoReparaciones
                    {
                        id = int.Parse(item["id_tipo_reparacion"].ToString()),
                        descripcion = item["descripcion"].ToString()
                    });
                }
            }
            return list;
        }

        public bool GuardarTipoReparacion(string tipoReparacion)
        {
            db = new ConnectionSettings();
            var sp = "sp_insertar_tipo_reparaciones";
            var parametros = new List<parametro>();
            parametros.Add(new parametro
            {
                nombre = "@descripcion",
                tipo = SqlDbType.VarChar,
                valor = tipoReparacion
            });

            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public bool ModificarTipoReparacion(int id, string tipoReparacion)
        {
            db = new ConnectionSettings();
            var sp = "sp_modificar_tipo_reparaciones";
            var parametros = new List<parametro>();
            parametros.Add(new parametro
            {
                nombre = "@descripcion",
                tipo = SqlDbType.VarChar,
                valor = tipoReparacion
            });

            parametros.Add(new parametro
            {
                nombre = "@id_tipo_reparacion",
                tipo = SqlDbType.Int,
                valor = id.ToString()
            });


            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

    }

    public class TipoReparaciones
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }
}
