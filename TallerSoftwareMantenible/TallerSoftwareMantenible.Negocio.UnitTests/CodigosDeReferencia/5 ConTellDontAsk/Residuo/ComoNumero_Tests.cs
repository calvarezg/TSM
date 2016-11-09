using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk.Residuo_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Requerimiento_ResiduoComoNumero()
        {
            elResultadoEsperado = 10;

            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new Residuo(elRequerimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
