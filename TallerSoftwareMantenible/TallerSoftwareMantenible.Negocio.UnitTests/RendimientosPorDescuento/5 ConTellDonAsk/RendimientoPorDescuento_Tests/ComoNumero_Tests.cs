using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConTellDonAsk.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeRendimiento losDatos;

        [TestMethod]
        public void ComoNumero_ConTratamientoFiscal_TransadoBrutoConTratamiento()
        {
            elResultadoEsperado = 21621.621621621656;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000.0,
                ValorTransadoNeto = 300000.0,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = true
            };
            elResultadoObtenido = new RendimientoPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_RendimientoPorDescuentoCorrecto()
        {
            elResultadoEsperado = 19999.999899999995;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000.0,
                ValorTransadoNeto = 300000.0001,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = false
            };
            elResultadoObtenido = new RendimientoPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
