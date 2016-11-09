using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConPolimorfismo.DigitoVerificador_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;
        
        [TestMethod]
        public void ComoNumero_ResiduoEs10_Uno()
        {
            elResultadoEsperado = 1;

            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new DigitoVerificador(elRequerimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_ResiduoNoEs10_Residuo()
        {
            elResultadoEsperado = 5;

            elRequerimiento = "2000111103322888888888888";
            elResultadoObtenido = new DigitoVerificador(elRequerimiento).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
