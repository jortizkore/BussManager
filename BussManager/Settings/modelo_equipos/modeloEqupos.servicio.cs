using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Settings.modelo_equipos
{
    class modeloEqupos
    {
        ConnectionSettings db = new ConnectionSettings();

        public List<modelo> TraerModelos()
        {
            var list = new List<modelo>();
            var query = "select * from modelo_celulares";
            var result = db.bringJsonData(query);
            if (result != string.Empty)
            {
                var stringResult = JArray.Parse(result);

                foreach (var item in stringResult)
                {
                    var modelo = new modelo();
                    modelo.id_modelo = int.Parse(item["id_marca"].ToString());
                    modelo.descripcion = item["descripcion"].ToString();

                    list.Add(modelo);
                }
            }

            return list ;
        }

        public bool GuardarModelo(string modelo)
        {
            var sp = "insertar_modelo_equipo";
            var parametros = new List<parametro>();
            parametros.Add(new parametro
            {
                nombre = "@modelo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = modelo
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = string.Empty
            });

            return db.CorrerSP(sp, parametros);
            
        }

        public bool ModificarModelo(int id,string modelo)
        {
            var sp = "modificar_modelo_equipo";
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@modelo",
                tipo = System.Data.SqlDbType.VarChar,
                valor = modelo
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = string.Empty
            });
            parametros.Add(new parametro
            {
                nombre = "@id_modelo",
                tipo = System.Data.SqlDbType.Int,
                valor = id.ToString()
            });

            return db.CorrerSP(sp, parametros);

        }

        public string TraerModelo(int id)
        {
            try
            {
                var result = TraerModelos().Where(m => m.id_modelo == id).First();
                if (result != null)
                {
                    return result.descripcion;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}

public class modelo
{
    public int id_modelo { get; set; }
    public string descripcion { get; set; }
}