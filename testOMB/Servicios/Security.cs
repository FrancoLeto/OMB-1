using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Servicios;

namespace testOMB.Servicios
{
    [TestClass]
    public class Security
    {
        [TestMethod]
        public void ProbarLoginConDatosIncorrectos()
        {
            SecurityServices serv = new SecurityServices();
            bool result;
            result = serv.Login("ethedy","12345sadsa78");
            Assert.IsFalse(result, " Hay un usuario pi???") ;
        }
        [TestMethod]
        public void ProbarLoginConDatosCorrectos()
        {
            SecurityServices serv = new SecurityServices();
            bool result;
            result = serv.Login("ethedy", "12345678");
            Assert.IsTrue(result, " Hay un usuario pi???");
        }
    }
}
