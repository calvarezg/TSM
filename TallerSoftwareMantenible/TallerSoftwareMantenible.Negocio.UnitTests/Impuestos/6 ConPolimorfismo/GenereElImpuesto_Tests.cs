using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConPolimorfismo
{
    [TestClass]
    public class GenereElImpuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeTasaBruta losDatos;

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscalYSeRedondea_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320500,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_NoTieneTratamientoFiscal_EsCero()
        {
            elResultadoEsperado = 0;

            losDatos = new DatosDeTasaBrutaSinTratamiento
            {
                ValorFacial = 320500,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = losDatos.Impuesto;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
