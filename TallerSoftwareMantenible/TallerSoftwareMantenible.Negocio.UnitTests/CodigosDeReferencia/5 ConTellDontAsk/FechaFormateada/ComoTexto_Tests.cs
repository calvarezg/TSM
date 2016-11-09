using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk.FechaFormateada_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DatosDeReferencia losDatos;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_Fecha_FechaComoTexto()
        {
            elResultadoEsperado = "20160101";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new FechaFormateada(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
