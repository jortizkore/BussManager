using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Settings;

namespace BussManager.Settings.proveedores
{

    class ServicioProveedores
    {
        ConnectionSettings db = new ConnectionSettings();

        public List<Proveedor> TraerProveedores()
        {
            var proveedores = new List<Proveedor>();
            var query = "select * from proveedores";
            var result = db.bringJsonData(query);
            
            if (result != string.Empty)
            {
                var JsonResult = JArray.Parse(result);

                foreach (var prov in JsonResult)
                {
                    var p = new Proveedor{
                            id = int.Parse(prov["id_proveedor"].ToString()),
                            descripcion = prov["descripcion"].ToString()
                    };
                    proveedores.Add(p);
                }
            }

            return proveedores;
        }

        // TODO: crear insert update de  proveedores

        public Proveedor TraerProveedor(int id)
        {
            try
            {
                var result = TraerProveedores().Where(prov => prov.id == id).First();
                return result;
            }
            catch (Exception)
            {
                return new Proveedor();
            }
        }

    }

    class Proveedor
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }
}
