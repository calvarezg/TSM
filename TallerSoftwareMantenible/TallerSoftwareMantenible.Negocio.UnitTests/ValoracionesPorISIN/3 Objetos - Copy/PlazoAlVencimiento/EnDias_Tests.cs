using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.ParameterObject.PlazoAlVencimiento_Tests
{
    [TestClass]
    public class EnDias_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeValoracion losDatos;

        [TestMethod()]
        public void EnDias_DosFechas_DiferenciaEnDias()
        {
            elResultadoEsperado = 157;

            losDatos = new DatosDeValoracion();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            elResultadoObtenido = new PlazoAlVencimiento(losDatos).EnDias();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
