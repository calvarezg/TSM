using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.FechaFormateada_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_Fecha_FechaComoTexto()
        {
            elResultadoEsperado = "20160101";

            laFecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new FechaFormateada(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
