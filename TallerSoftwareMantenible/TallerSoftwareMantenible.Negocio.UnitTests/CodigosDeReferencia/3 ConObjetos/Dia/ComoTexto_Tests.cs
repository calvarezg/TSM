using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.Dia_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        
        [TestMethod]
        public void ComoTexto_Fecha_DiaComoTexto()
        {
            elResultadoEsperado = "1";

            laFecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new Dia(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
