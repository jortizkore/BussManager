using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussManager.recursos_humanos;
using BussManager.Settings;


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
                    UsuarioLogueado.Loguear(user);
                    MessageManager.InfoMessage("Hola " + UsuarioLogueado.TraerNombreUsuarioLogueado());
                    return true;
                }
                MessageManager.AlerMessage("Contraseña inválida, por favor, intente de nuevo");
            }
            MessageManager.AlerMessage("Usuario no encontrado!");
            return false;
        }
    }

    public class Credenciales
    {
        public string usuario { get; set; }
        public string contrasenia { get; set; }
    }
}
