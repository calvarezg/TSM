using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConPolimorfismo.Residuo_Tests
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
