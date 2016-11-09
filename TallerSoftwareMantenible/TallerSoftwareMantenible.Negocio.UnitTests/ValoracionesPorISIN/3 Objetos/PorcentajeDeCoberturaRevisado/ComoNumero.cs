using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Objetos.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimientoDelValorOficial;
        private int losDiasMinimosAlVencimientoDelEmiso;
        private decimal elPorcentajeCobertura;

        [TestMethod]
        public void ComoNumero_PlazoMayorOIgualAlPermitido_ElPorcentaje()
        {
            elResultadoEsperado = 0.8M;

            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 8);
            losDiasMinimosAlVencimientoDelEmiso = 7;
            elPorcentajeCobertura = 0.8M;
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmiso, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_PlazoMenorAlPermitido_Cero()
        {
            elResultadoEsperado = 0M;

            laFechaActual = new DateTime(2016, 1, 1);
            laFechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            losDiasMinimosAlVencimientoDelEmiso = 7;
            elPorcentajeCobertura = 0.8M;
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmiso, elPorcentajeCobertura).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
