using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BussManager.Test.Settings
{
    [TestClass]
    public class ConnectionSettings
    {
        BussManager.Settings.ConnectionSettings db;

        [TestMethod]
        public void DebeEstablecerConexionALaBaseDeDatos()
        {
            db = new BussManager.Settings.ConnectionSettings();
            var isConnected = db.connect();
            Assert.IsTrue(isConnected);
        }

        [TestMethod]
        public void DebeDesconectarExitosamente()
        {
            db = new BussManager.Settings.ConnectionSettings();
            var isConnected = db.connect();
            db.Disconnect();
            isConnected = db.IsConnected();
            Assert.IsFalse(isConnected);
        }
    }
}
