using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConPolimorfismo.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeTasaBruta losDatos;

        [TestMethod]
        public void ComoNumero_ConTratamientoFiscal_TransadoBrutoConTratamiento()
        {
            elResultadoEsperado = 21621.621621621656;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320000.0,
                ValorTransadoNeto = 300000.0,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new RendimientoPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_RendimientoPorDescuentoCorrecto()
        {
            elResultadoEsperado = 19999.999899999995;

            losDatos = new DatosDeTasaBrutaSinTratamiento
            {
                ValorFacial = 320000.0,
                ValorTransadoNeto = 300000.0001,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new RendimientoPorDescuento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
