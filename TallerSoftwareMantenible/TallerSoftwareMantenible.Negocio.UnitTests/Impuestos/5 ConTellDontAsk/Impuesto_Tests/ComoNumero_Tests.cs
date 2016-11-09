using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.Impuestos.ConTellDontAsk;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConTellDontAsk.Impuesto_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeRendimiento losDatos;

        [TestMethod]
        public void ComoNumero_ValoresDeEntrada_ImpuestoCorrecto()
        {
            elResultadoEsperado = 1621.6216216216562;

            losDatos = new DatosDeRendimiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3),
                TieneTratamientoFiscal = true
            };
            elResultadoObtenido = new Impuesto(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
