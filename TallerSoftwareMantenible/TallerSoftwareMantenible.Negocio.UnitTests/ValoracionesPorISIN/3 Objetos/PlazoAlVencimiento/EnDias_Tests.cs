using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Objetos.PlazoAlVencimiento_Tests
{
    [TestClass]
    public class EnDias_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimientoDelValorOficial;

        [TestMethod()]
        public void EnDias_DosFechas_DiferenciaEnDias()
        {
            elResultadoEsperado = 157;

            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            elResultadoObtenido = new PlazoAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial).EnDias();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
