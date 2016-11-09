using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.MesFormateado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_MesDeUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            laFecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new MesFormateado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_MesDeDosDigitos_NoPrecedeConCero()
        {
            elResultadoEsperado = "11";

            laFecha = new DateTime(2016, 11, 1);
            elResultadoObtenido = new MesFormateado(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
