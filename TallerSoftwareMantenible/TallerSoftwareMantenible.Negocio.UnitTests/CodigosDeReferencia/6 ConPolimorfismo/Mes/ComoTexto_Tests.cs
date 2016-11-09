using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConPolimorfismo.Mes_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DatosDeReferencia losDatos;
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        
        [TestMethod]
        public void ComoTexto_Fecha_MesComoTexto()
        {
            elResultadoEsperado = "1";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 20);
            elResultadoObtenido = new Mes(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
