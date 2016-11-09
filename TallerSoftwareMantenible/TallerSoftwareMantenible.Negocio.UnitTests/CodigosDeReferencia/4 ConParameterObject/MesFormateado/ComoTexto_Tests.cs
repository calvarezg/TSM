using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.MesFormateado_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DatosDeReferencia losDatos;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_MesDeUnDigito_PrecedeConCero()
        {
            elResultadoEsperado = "01";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new MesFormateado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoTexto_MesDeDosDigitos_NoPrecedeConCero()
        {
            elResultadoEsperado = "11";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 11, 1);
            elResultadoObtenido = new MesFormateado(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
