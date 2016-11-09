using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConPolimorfismo.TasaBruta_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private DatosDeTasaBruta losDatos;

        [TestMethod]
        public void ComoDecimal_Valores_TasaBrutaComoNumero()
        {
            elResultadoEsperado = 11.9679979015017;

            losDatos = new DatosDeTasaBrutaConTratamiento
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                FechaDeVencimiento = new DateTime(2016, 10, 10),
                FechaActual = new DateTime(2016, 3, 3)
            };
            elResultadoObtenido = new TasaBruta(losDatos).ComoNumero();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 13);
        }
    }
}
