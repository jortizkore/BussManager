using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.Login;
using BussManager.recursos_humanos;

namespace BussManager.Settings
{
    public static class UsuarioLogueado
    {
        static RecursoHumano usuarioLogueado = new RecursoHumano();
        public static frmLogin frm { get; set; }
        public static int Nivel { get; set; }

        public static bool Loguear(RecursoHumano usuario)
        {
            usuarioLogueado = usuario;
            Nivel = usuario.Nivel;
            return true;
        }

        public static int TraerNivelUsuarioLogueado()
        {
            return usuarioLogueado.Nivel;
        }

        public static string TraerNombreUsuarioLogueado()
        {
            return usuarioLogueado.Nombre;
        }

        public static void CerrarSession()
        {
            usuarioLogueado = new RecursoHumano();
        }
    }
}
