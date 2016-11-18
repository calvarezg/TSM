using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Polimorfismo.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDeISINEnColones losDatos;

        [TestMethod]
        public void ComoNumero_PlazoMayorOIgualAlPermitido_ElPorcentaje()
        {
            elResultadoEsperado = 0.8M;

            losDatos = new DatosDeISINEnColones();
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

            losDatos = new DatosDeISINEnColones();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
