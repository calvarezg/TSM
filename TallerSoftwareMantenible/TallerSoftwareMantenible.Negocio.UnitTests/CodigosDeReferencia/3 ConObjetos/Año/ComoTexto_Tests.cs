using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.Año_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        
        [TestMethod]
        public void ComoTexto_Fecha_AñoComoTexto()
        {
            elResultadoEsperado = "2016";

            laFecha = new DateTime(2016, 1, 20);
            elResultadoObtenido = new Año(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
