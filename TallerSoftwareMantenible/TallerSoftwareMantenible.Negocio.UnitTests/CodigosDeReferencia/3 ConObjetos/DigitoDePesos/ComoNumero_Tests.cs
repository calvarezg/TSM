using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.DigitoDePeso_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private string elRequerimiento;
        private int laPosicionActual;
        private short elResultadoEsperado;
        private short elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_PrimerCaracter_CaracterComoNumero()
        {
            elResultadoEsperado = 1;

            laPosicionActual = 0;
            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new DigitoDePeso(elRequerimiento, laPosicionActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
