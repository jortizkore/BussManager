using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BussManager.recursos_humanos;

namespace BussManager.Test.Recursos_humanos
{
    [TestClass]
    public class RecursosHumanos
    {
        recursos_humanos.ServicioRecursoHumano rh;
        
        [TestMethod]
        public void DebeTraerTodosLosRecursos()
        {
            rh = new recursos_humanos.ServicioRecursoHumano();
            var resultado = rh.TraerRecursosHumanos();

            Assert.IsTrue(resultado.Count > 0);
        }

        [TestMethod]
        public void DebeTraerSoloElRecursoRequerido()
        {
            rh = new ServicioRecursoHumano();
            var nombreEsperado = "Joyner";
            var result = rh.TraerUsuario("jortiz");

            Assert.AreEqual(nombreEsperado, result.Nombre);
        }

    }
}
