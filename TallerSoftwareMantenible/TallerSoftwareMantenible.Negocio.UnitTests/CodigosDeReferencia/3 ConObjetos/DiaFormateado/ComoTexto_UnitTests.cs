using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.DiaFormateado_UnitTests
{
    [TestClass]
    public class ComoTexto_UnitTests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_FechaConDiaMenorA10_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            laFecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new DiaFormateado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_FechaConDiaMayorA10_NoPrecedeConCero()
        {
            elResultadoEsperado = "23";

            laFecha = new DateTime(2016, 1, 23);
            elResultadoObtenido = new DiaFormateado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
