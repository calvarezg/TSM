using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConObjetos.ValorTransadoBrutoConTratamiento_Tests
{
    [TestClass]
    public class ComoUnNumero_Tests
    {
        private double elValorFacial;
        private double elValorTransadoBrutoConTratamientoEsperado;
        private double elValorTransadoBrutoConTratamientoObtenido;
        private double elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;

        [TestMethod]
        public void ComoUnNumero_CalculaValorTransadoBrutoConTratamiento()
        {
            elValorTransadoBrutoConTratamientoEsperado = 298378.378378378;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            elValorTransadoBrutoConTratamientoObtenido = new ValorTransadoBruto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual).ComoNumero();

            Assert.AreEqual(elValorTransadoBrutoConTratamientoEsperado, elValorTransadoBrutoConTratamientoObtenido, 9);
        }
    }
}
