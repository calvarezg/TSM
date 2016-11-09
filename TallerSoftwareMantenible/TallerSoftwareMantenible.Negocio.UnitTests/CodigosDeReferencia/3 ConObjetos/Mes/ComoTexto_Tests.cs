using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.Mes_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DateTime laFecha;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        
        [TestMethod]
        public void ComoTexto_Fecha_MesComoTexto()
        {
            elResultadoEsperado = "1";

            laFecha = new DateTime(2016, 1, 20);
            elResultadoObtenido = new Mes(laFecha).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
