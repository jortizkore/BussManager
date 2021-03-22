using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.Settings
{
    public static class InformacionDeEmpresa
    {
        public static string Nombre { get; set; }
        public static string Direccion { get; set; }
        public static string Telefono { get; set; }
        public static string RNC { get; set; }

        public static void CargarInformacion()
        {
            Nombre = "FRANK Super Fria";
            Direccion = "Calle 1ra, No 1, Edificio 1, Villa Blanca 2da, Sabana Perdida";
            Telefono = "809-901-9132";
            RNC = "NA";
        }
    }
}
