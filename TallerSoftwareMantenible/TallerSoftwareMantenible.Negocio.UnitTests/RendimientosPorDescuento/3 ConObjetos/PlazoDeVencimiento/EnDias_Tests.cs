using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConObjetos.PlazoDeVencimiento_Tests
{
    [TestClass]
    public class EnDias_Tests
    {
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private int elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void EnDias_DosFechas_DiferenciaEnDias()
        {
            elResultadoEsperado = 221;

            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new PlazoDeVencimiento(laFechaDeVencimiento, laFechaActual).EnDias();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
