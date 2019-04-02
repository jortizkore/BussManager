using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.recursos_humanos;
namespace BussManager.Login
{
    class Login
    {
        ServicioRecursoHumano rh = new ServicioRecursoHumano();

        public Login()
        {

        }

        public bool DoLogin(Credenciales credenciales) {

            var user = rh.TraerUsuario(credenciales.usuario);
            if (user.Id > 0)
            {
                if(user.Contrasenia == credenciales.contrasenia)
                {
                    // messageService should return a successfull login message
                    return true;
                }
                // messageService should return a missmatch password message
            }
            // not existen user message should be thrown by the messageService
            return false;
        }
    }

    public class Credenciales
    {
        public string usuario { get; set; }
        public string contrasenia { get; set; }
    }
}
