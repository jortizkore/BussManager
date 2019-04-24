using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Settings.clase_equipos
{
    class ClaseEquipo
    {
        ConnectionSettings db;

        public List<clase> TraerClases()
        {
            db = new ConnectionSettings();
            var list = new List<clase>();
            var query = "Select * from clase";
            var result = db.bringJsonData(query);

            if (result != string.Empty)
            {
                var clases = JArray.Parse(result);
                foreach (var item in clases)
                {
                    list.Add(new clase
                    {
                        id = int.Parse(item["id_clase"].ToString()),
                        descripcion = item["clase"].ToString(),
                        comentario = item["Comentarios"].ToString()
                    });
                }
            }

            return list;
        }

        public bool GuardarClase(string clase, string comentario)
        {
            var sp = "sp_insertar_clase";
            db = new ConnectionSettings();
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.VarChar,
                valor = clase
            });
            parametros.Add(new parametro
            {
                nombre = "@comentario",
                tipo = System.Data.SqlDbType.VarChar,
                valor = comentario
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);

        }

        public bool ModificarClase(int id, string clase, string comentario)
        {
            var sp = "sp_modificar_clase";
            db = new ConnectionSettings();
            var parametros = new List<parametro>();

            parametros.Add(new parametro
            {
                nombre = "@id_clase",
                tipo = System.Data.SqlDbType.Int,
                valor = id.ToString()
            });
            parametros.Add(new parametro
            {
                nombre = "@clase",
                tipo = System.Data.SqlDbType.VarChar,
                valor = clase
            });
            parametros.Add(new parametro
            {
                nombre = "@comentario",
                tipo = System.Data.SqlDbType.VarChar,
                valor = comentario
            });
            parametros.Add(new parametro
            {
                nombre = "@responseMessage",
                tipo = System.Data.SqlDbType.VarChar,
                valor = ""
            });

            return db.CorrerSP(sp, parametros);
        }

        public string TraerClase(int id)
        {
            return TraerClases().Where(c => c.id == id).First().descripcion;
        }
        public string TraerComentario(int id)
        {
            var result = TraerClases().Where(c => c.id == id).First();
            if (result != null)
            {
                return result.comentario;
            }
            else
            {
                return "";
            }
        }
    }
}

public class clase
{
    public int id { get; set; }
    public string descripcion { get; set; }
    public string comentario { get; set; }
}
