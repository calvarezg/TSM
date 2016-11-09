using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ComoUnProcedimiento;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ComoUnProcedimiento
{
    [TestClass]
    public class GenereElRendimientosPorDescuento_Tests
    {
        private double elRendimientoEsperado;
        private double elRendimientoObtenido;
        private double elValorFacial;
        private double elValorTrasadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscal_RedondeaHaciaAbajo()
        {
            elRendimientoEsperado = 21621.6216;

            elValorFacial = 320000;
            elValorTrasadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elRendimientoObtenido =
                Calculos.GenereElRedimientoPorDescuento(
                    elValorFacial,
                    elValorTrasadoNeto,
                    laTasaDeImpuesto,
                    laFechaDeVencimiento,
                    laFechaActual,
                    tieneTratamientoFiscal);

            Assert.AreEqual(elRendimientoEsperado, elRendimientoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscalYSeDebeRedondear_RedondeaHaciaAbajo()
        {
            elRendimientoEsperado = 22159.3592;

            elValorFacial = 320500;
            elValorTrasadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elRendimientoObtenido =
                Calculos.GenereElRedimientoPorDescuento(
                    elValorFacial,
                    elValorTrasadoNeto,
                    laTasaDeImpuesto,
                    laFechaDeVencimiento,
                    laFechaActual,
                    tieneTratamientoFiscal);

            Assert.AreEqual(elRendimientoEsperado, elRendimientoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elRendimientoEsperado = 19999.9999;

            elValorFacial = 320000;
            elValorTrasadoNeto = 300000.0001;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = false;
            elRendimientoObtenido =
                Calculos.GenereElRedimientoPorDescuento(
                    elValorFacial,
                    elValorTrasadoNeto,
                    laTasaDeImpuesto,
                    laFechaDeVencimiento,
                    laFechaActual,
                    tieneTratamientoFiscal);

            Assert.AreEqual(elRendimientoEsperado, elRendimientoObtenido);
        }

    }
}
