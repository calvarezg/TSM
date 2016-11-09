using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.Impuestos.ConPolimorfismo;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConPolimorfismo.ImpuestoRedondeado_Tests
{
    [TestClass]
    public class ConCuatroDecimales_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeTasaBruta losDatos;

        [TestMethod]
        public void ConCuatroDecimales_ValoresDeEntrada_ImpuestoRedondeadoA4Decimales()
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
            elResultadoObtenido = new ImpuestoRedondeado(losDatos).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
