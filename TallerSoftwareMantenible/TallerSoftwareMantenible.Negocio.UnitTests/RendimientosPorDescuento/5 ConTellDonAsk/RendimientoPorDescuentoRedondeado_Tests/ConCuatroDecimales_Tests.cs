using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConTellDonAsk.RendimientosPorDescuento_Tests
{
    [TestClass]
    public class ConCuatroDecimales_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeRendimiento losDatos;

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscal_RedondeaHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = true
            };
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscalYSeDebeRedondear_RedondeaHaciaAbajo()
        {
            elResultadoEsperado = 22159.3592;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320500,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = true
            };
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000.0001,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = false
            };                  
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
