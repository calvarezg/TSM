using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos.PosicionDeCaracterDePeso_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;
        private string laHileraDePesos ;
        private int laPosicionActual;

        [TestMethod]
        public void ComoNumero_Posicion_CaracterComoNumero()
        {
            elResultadoEsperado = 40;

            laPosicionActual = 40;
            elRequerimiento = "2000111133322888888888888";
            laHileraDePesos = "1234567891234567891234567";
            elResultadoObtenido = new PosicionDeCaracterDePeso(elRequerimiento, laHileraDePesos, laPosicionActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
