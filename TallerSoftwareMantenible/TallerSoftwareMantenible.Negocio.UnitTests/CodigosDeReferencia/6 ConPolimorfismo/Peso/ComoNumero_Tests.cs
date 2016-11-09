using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConPolimorfismo.Peso_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private int laPosicionActual;
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Posicion_CaracterComoNumero()
        {
            elResultadoEsperado = 5;

            laPosicionActual = 4;
            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new Peso(elRequerimiento, laPosicionActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
