using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConObjetos.RendimientoPorDescuento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private double elValorFacial;
        private double elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;

        [TestMethod]
        public void ComoNumero_ConTratamientoFiscal_TransadoBrutoConTratamiento()
        {
            elResultadoEsperado = 21621.621621621656;

            elValorFacial = 320000.0;
            elValorTransadoNeto = 300000.0;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elResultadoObtenido = new RendimientoPorDescuento(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SinTratamientoFiscal_RendimientoPorDescuentoCorrecto()
        {
            elResultadoEsperado = 19999.999899999995;
            
            elValorFacial = 320000.0;
            elValorTransadoNeto = 300000.0001;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = false;
            elResultadoObtenido = new RendimientoPorDescuento(
                elValorFacial, 
                elValorTransadoNeto, 
                laTasaDeImpuesto, 
                laFechaDeVencimiento, 
                laFechaActual, 
                tieneTratamientoFiscal).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
