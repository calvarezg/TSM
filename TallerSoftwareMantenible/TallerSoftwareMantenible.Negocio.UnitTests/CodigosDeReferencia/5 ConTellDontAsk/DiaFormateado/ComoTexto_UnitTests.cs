using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk.DiaFormateado_UnitTests
{
    [TestClass]
    public class ComoTexto_UnitTests
    {
        private DatosDeReferencia losDatos;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_FechaConDiaMenorA10_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new DiaFormateado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_FechaConDiaMayorA10_NoPrecedeConCero()
        {
            elResultadoEsperado = "23";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 23);
            elResultadoObtenido = new DiaFormateado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
