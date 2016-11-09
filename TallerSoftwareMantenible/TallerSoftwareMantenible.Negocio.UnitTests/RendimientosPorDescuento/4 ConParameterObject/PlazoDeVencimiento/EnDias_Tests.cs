using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConParameterObject.PlazoDeVencimiento_Tests
{
    [TestClass]
    public class EnDias_Tests
    {
        private DatosDeRendimiento losDatos;
        private int elResultadoEsperado;
        private double elResultadoObtenido;

        [TestMethod]
        public void EnDias_DosFechas_DiferenciaEnDias()
        {
            elResultadoEsperado = 221;

            losDatos = new DatosDeRendimiento
            {
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new PlazoDeVencimiento(losDatos).EnDias();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
