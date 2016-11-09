using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.DigitoDeRequerimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private int laPosicionActual;
        private string elRequerimiento;
        private short elResultadoEsperado;
        private short elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_PrimeraPosicion_CaracterComoNumero()
        {
            elResultadoEsperado = 2;

            laPosicionActual = 0;
            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new DigitoDeRequerimiento(elRequerimiento, laPosicionActual).ComoNumero();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
