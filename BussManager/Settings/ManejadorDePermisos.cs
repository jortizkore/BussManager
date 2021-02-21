using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussManager.Settings
{
    public static class ManejadorDePermisos
    {
        public static void ComprobarPermisos(Control mainControl)
        {
            var controls = mainControl.Controls.Cast<Control>().ToList();
            for (int i = 0; i < controls.Count; i++)
            {
                try
                {
                    ComprobarPermisos(controls[i]);
                    var nivelControl = int.Parse(controls[i].Tag.ToString());
                    if (controls[i].Name.Contains("lbl"))
                    {
                        controls[i].Visible = nivelControl <= UsuarioLogueado.Nivel;
                    }
                    else
                    {
                        controls[i].Enabled = nivelControl <= UsuarioLogueado.Nivel;
                    }
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
