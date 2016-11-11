using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.TellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.TellDontAsk.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeValoracion losDatos;
        private decimal elPorcentajeCobertura;

        [TestMethod]
        public void ComoNumero_PlazoMayorOIgualAlPermitido_ElPorcentaje()
        {
            elResultadoEsperado = 0.8M;

            losDatos = new DatosDeValoracion();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 8);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_PlazoMenorAlPermitido_Cero()
        {
            elResultadoEsperado = 0M;

            losDatos = new DatosDeValoracion();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
