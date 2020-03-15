using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussManager.Settings;
using BussManager.recursos_humanos;

namespace BussManager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServicioRecursoHumano srh = new ServicioRecursoHumano();
            Console.Write(srh.TraerRecursosHumanos());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {

                Application.Run(new Dashboard());
            }
            catch (Exception ex)
            {
                MessageManager.InfoMessage(ex.Message + " | " + ex.InnerException + " | " + ex.StackTrace);
            }
        }
    }
}
