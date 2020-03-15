using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussManager.Settings;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BussManager.Inventario.Accesorios
{
    public class PerdiadAcceorio
    {
        public int ID { get; set; }
        public string Accesorio { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPerdida { get; set; }
        public int Responsable { get; set; }

        private ConnectionSettings db = new ConnectionSettings();


        public bool Guardar()
        {
            db = new ConnectionSettings();
            if (Validar())
            {
                var query = "sp_insertar_perdida_accesorio";
                try
                {
                    return db.CorrerSP(query, Parametros());
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                return false;
            }
        }

        List<parametro> Parametros()
        {
            List<parametro> lista = new List<parametro>();
            lista.Add(new parametro
            {
                nombre = "@accesorio",
                tipo = System.Data.SqlDbType.VarChar,
                valor = Accesorio
            });

            lista.Add(new parametro
            {
                nombre = "@cantidad",
                tipo = System.Data.SqlDbType.Int,
                valor = Cantidad.ToString()
            });
            lista.Add(new parametro
            {
                nombre = "@costo",
                tipo = System.Data.SqlDbType.Decimal,
                valor = Costo.ToString()
            });
            lista.Add(new parametro
            { 
                nombre = "@fecha",
                tipo = System.Data.SqlDbType.Date,
                valor = Fecha.ToString()
            });
            lista.Add(new parametro
            {
                nombre = "@TipoPerdida",
                tipo = System.Data.SqlDbType.VarChar,
                valor = TipoPerdida
            });
            lista.Add(new parametro
            {
                nombre = "@Responsable",
                tipo = System.Data.SqlDbType.Int,
                valor = Responsable.ToString()
            });

            return lista;
        }

        public List<PerdiadAcceorio> TraerPerdidas()
        {
            db = new ConnectionSettings();
            var listaPerdiads = new List<PerdiadAcceorio>();
            var query = "Select * from reporte_perdida_accesorio";
            var result = db.bringJsonData(query);

            var jsonResult = JArray.Parse(result);

            foreach (var item in jsonResult)
            {
                var perdida = DeJsonAObjeto(item);
                listaPerdiads.Add(perdida);
            }

            return listaPerdiads;
        }

        public List<PerdiadAcceorio> TraerPerdidas(string accesorio)
        {
            var listaPerdiads = TraerPerdidas();
            return listaPerdiads.Where(p => p.Accesorio.ToLower()
                                .Contains(accesorio.ToLower())).ToList();
        }

        public List<PerdiadAcceorio> TraerPerdidas(DateTime fechaInicio, DateTime fechaFin)
        {
            var listaPerdiads = TraerPerdidas();
            return listaPerdiads.Where(p => p.Fecha >= fechaInicio && p.Fecha <= fechaFin).ToList();
        }


        private PerdiadAcceorio DeJsonAObjeto(JToken json)
        {
            var res = new PerdiadAcceorio();

            res.ID = Convert.ToInt32(json["id_perdida"].ToString());
            res.Accesorio = json["accesorio"].ToString();
            res.Cantidad = Convert.ToInt32(json["cantidad"].ToString());
            res.Costo = Convert.ToDecimal(json["costo"].ToString());
            res.Fecha = Convert.ToDateTime(json["fecha"].ToString());
            res.TipoPerdida = json["tipo_perdida"].ToString();
            res.Responsable = Convert.ToInt32(json["responsable"].ToString());
            return res;
        }

        private bool Validar()
        {
            var valid = Accesorio != null && Accesorio.Trim() != "" &&
                        Cantidad > 0 &&
                        Costo > 0 &&
                        Fecha != null &&
                        TipoPerdida != null && TipoPerdida.Trim() != "";

            return valid;
        }

    }
}
