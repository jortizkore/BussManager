using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussManager.recursos_humanos
{
    public class RecursoHumano
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public string Estado { get; set; }
    }
}
