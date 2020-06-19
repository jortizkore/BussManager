using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BussManager.recursos_humanos
{
    public class ServicioRecursoHumano
    {
        Settings.ConnectionSettings db = new Settings.ConnectionSettings();
        string view = "vw_recursos_Humanos";

        public List<RecursoHumano> TraerRecursosHumanos()
        {
            List<RecursoHumano> list = new List<RecursoHumano>();

            var query = $"select * from {view}";
            var resultado = JArray.Parse(db.bringJsonData(query));

            foreach (var item in resultado)
            {
                var rh = DeJsonArh(item);
                list.Add(rh);
            }

            return list;
        }

        private RecursoHumano DeJsonArh(JToken token)
        {
            return new RecursoHumano
            {
                Id = int.Parse(token["id"].ToString()),
                Nombre = token["nombre"].ToString(),
                Apellido = token["apellido"].ToString(),
                Cargo = token["cargo"].ToString(),
                Usuario = token["usuario"].ToString(),
                Contrasenia = token["contrasenia"].ToString(),
                Estado = token["estado"].ToString()
            };
        }

        public RecursoHumano TraerUsuario(string usuario)
        {
            RecursoHumano rh = new RecursoHumano();

            var query = $"select * from {view} where usuario = '{usuario}'";
            var dbAnswer = db.bringJsonData(query);
            var resultado =  dbAnswer != string.Empty? JArray.Parse(dbAnswer).First():null;

            if (resultado != null)
            {
                rh = DeJsonArh(resultado);
            }

            return rh;

        }

        public List<RecursoHumano> TraerTecnicos()
        {
            List<RecursoHumano> rh = new List<RecursoHumano>();

            var query = $"select * from {view} where cargo like '%Reparador%'";
            var dbAnswer = db.bringJsonData(query);
            var resultado = dbAnswer == string.Empty ? null : JArray.Parse(dbAnswer);

            if (resultado != null)
            {
                foreach (var item in resultado)
                {
                    rh.Add(DeJsonArh(item));
                }
                
            }
            return rh;
        }

    }
}

