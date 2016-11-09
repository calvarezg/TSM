using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.Requerimiento_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private string elCodigoDeCliente;
        private string elCodigoDeSistema;
        private string elConsecutivo;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DateTime laFecha;

        [TestMethod]
        public void ComoTexto_Requerimiento_ValorCorrecto()
        {
            elResultadoEsperado = "2000111133322888888888888";

            laFecha = new DateTime(2000, 11, 11);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "22";
            elConsecutivo = "888888888888";
            elResultadoObtenido = new Requerimiento(laFecha, elCodigoDeCliente, elCodigoDeSistema, elConsecutivo).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
