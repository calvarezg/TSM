using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk.SumaDePesos_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Requerimiento_SumaDePesos()
        {
            elResultadoEsperado = 582;

            elRequerimiento = "2000111133322888888888888";            
            elResultadoObtenido = new SumaDePesos(elRequerimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
