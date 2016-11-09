using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConPolimorfismo.SumaDePesos_Tests
{
    [TestClass]
    public class Calcule_Tests
    {
        private int elLargoDelRequerimiento;
        private string elRequerimiento;
        private int elResultadoEsperado;
        private int elResultadoObtenido;

        [TestMethod]
        public void Calcule_Requerimiento_PesosSumados()
        {
            elResultadoEsperado = 582;
            
            elRequerimiento = "2000111133322888888888888";
            elLargoDelRequerimiento = 24;
            elResultadoObtenido = SumadorDePesos.Calcule(elRequerimiento, elLargoDelRequerimiento);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
