using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConTellDonAsk.ValorTransadoBrutoConTratamiento_Tests
{
    [TestClass]
    public class ComoUnNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeRendimiento losDatos;

        [TestMethod]
        public void ComoUnNumero_CalculaValorTransadoBrutoConTratamiento()
        {
            elResultadoEsperado = 298378.378378378;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new ValorTransadoBruto(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 9);
        }
    }
}
