using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConPolimorfismo.RendimientosPorDescuento_Tests
{
    [TestClass]
    public class ConCuatroDecimales_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeTasaBruta losDatos;

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscal_RedondeaHaciaAbajo()
        {
            elResultadoEsperado = 21621.6216;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_TieneTratamientoFiscalYSeDebeRedondear_RedondeaHaciaAbajo()
        {
            elResultadoEsperado = 22159.3592;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320500,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElRendimientosPorDescuento_NoTieneTratamientoFiscal_SinRedondeo()
        {
            elResultadoEsperado = 19999.9999;

            losDatos = new DatosDeTasaBrutaSinTratamiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000.0001,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };                  
            elResultadoObtenido = new RendimientoPorDescuentoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
