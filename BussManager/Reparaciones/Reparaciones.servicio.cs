using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;

namespace BussManager.Reparaciones
{
    public class Reparaciones
    {
        string insertStoreProcedure = "sp_insertar_reparacion";

        public Reparaciones()
        {

        }

        public List<Reparacion> TraerReparaciones()
        {
            var db = new Settings.ConnectionSettings();
            var query = "Select * from reparaciones";
            List<Reparacion> reparaciones = new List<Reparacion>();
            var dbAnswer = db.bringJsonData(query);

            var JsonList = dbAnswer == string.Empty ? null : Newtonsoft.Json.Linq.JArray.Parse(dbAnswer);

            if (JsonList != null)
            {
                foreach (var item in JsonList)
                {
                    reparaciones.Add(deJsonAobjeto(item));
                }
            }
            return reparaciones;
        }

        public List<ReparacionGrid> TraerReparacionesParaGrid()
        {
            var db = new Settings.ConnectionSettings();
            var query = "Select * from vw_Traer_Reparaciones_Grid";
            List<ReparacionGrid> reparaciones = new List<ReparacionGrid>();
            var dbAnswer = db.bringJsonData(query);

            var JsonList = dbAnswer == string.Empty ? null : Newtonsoft.Json.Linq.JArray.Parse(dbAnswer);

            if (JsonList != null)
            {
                foreach (var item in JsonList)
                {
                    reparaciones.Add(deJsonAobjetoGrid(item));
                }
            }
            return reparaciones;
        }

        Reparacion deJsonAobjeto(Newtonsoft.Json.Linq.JToken item)
        {
            Reparacion result = new Reparacion();
            result.id = int.Parse(item["id_reparacion"].ToString());
            result.Marca = int.Parse(item["marca"].ToString());
            result.Tipo = int.Parse(item["tipo"].ToString());
            result.Tecnico = int.Parse(item["tecnico"].ToString());
            result.Compra = int.Parse(item["compra"].ToString());
            result.Costo = decimal.Parse(item["costo"].ToString());
            result.Precio = decimal.Parse(item["precio"].ToString());
            result.IMEI = item["IMEI"].ToString();
            result.Comentario = item["comentario"].ToString();
            result.Fecha = DateTime.Parse(item["fecha_reparacion"].ToString());

            return result;

        }

        ReparacionGrid deJsonAobjetoGrid(Newtonsoft.Json.Linq.JToken item)
        {
            ReparacionGrid result = new ReparacionGrid();
            result.id = int.Parse(item["id_reparacion"].ToString());
            result.Marca = item["marca"].ToString();
            result.Tipo = item["tipo"].ToString();
            result.Tecnico = item["tecnico"].ToString();
            result.Compra = item["compra"].ToString();
            result.Costo = decimal.Parse(item["costo"].ToString());
            result.Precio = decimal.Parse(item["precio"].ToString());
            result.IMEI = item["IMEI"].ToString();
            result.Comentario = item["comentario"].ToString();
            result.Fecha = DateTime.Parse(item["fecha_reparacion"].ToString());

            return result;

        }

        public bool GuardarReparacion(Reparacion reparacion)
        {
            try
            {
                #region Crear parametros
                List<parametro> parametros = new List<parametro>();
                parametros.Add(new parametro
                {
                    nombre = "@idMarca",
                    tipo = System.Data.SqlDbType.Int,
                    valor = reparacion.Marca.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@idTipo",
                    tipo = System.Data.SqlDbType.Int,
                    valor = reparacion.Tipo.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@costo",
                    tipo = System.Data.SqlDbType.Decimal,
                    valor = reparacion.Costo.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@precio",
                    tipo = System.Data.SqlDbType.Decimal,
                    valor = reparacion.Precio.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@idCompra",
                    tipo = System.Data.SqlDbType.Int,
                    valor = reparacion.Compra.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@IMEI",
                    tipo = System.Data.SqlDbType.VarChar,
                    valor = reparacion.IMEI.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@fecha_reparacion",
                    tipo = System.Data.SqlDbType.Date,
                    valor = reparacion.Fecha.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@idTecnico",
                    tipo = System.Data.SqlDbType.Int,
                    valor = reparacion.Tecnico.ToString()
                });
                parametros.Add(new parametro
                {
                    nombre = "@comentario",
                    tipo = System.Data.SqlDbType.VarChar,
                    valor = reparacion.Comentario.ToString()
                });
                #endregion

                var db = new Settings.ConnectionSettings();
                return db.CorrerSP(insertStoreProcedure, parametros);

            }
            catch (Exception)
            {

                throw;
            }
        }


    }

    public class Reparacion
    {
        public int id { get; set; }
        public int Marca { get; set; }
        public int Tipo { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Compra { get; set; }
        public DateTime Fecha { get; set; }
        public int Tecnico { get; set; }
        public string IMEI { get; set; }
        public string Comentario { get; set; }

    }
    public class ReparacionGrid
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public string Compra { get; set; }
        public DateTime Fecha { get; set; }
        public string Tecnico { get; set; }
        public string IMEI { get; set; }
        public string Comentario { get; set; }

    }
}
