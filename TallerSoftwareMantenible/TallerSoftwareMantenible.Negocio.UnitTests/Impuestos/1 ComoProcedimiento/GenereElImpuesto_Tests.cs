using TallerSoftwareMantenible.Negocio.Impuestos.ComoProcedimiento;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ComoProcedimiento
{
    [TestClass]
    public class GenereElImpuesto_Tests
    {
        private double elImpuestoEsperado;
        private double elImpuestoObtenido;
        private double elValorFacial;
        private double elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;
        private bool tieneTratamientoFiscal;

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elImpuestoEsperado = 1621.6216;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elImpuestoObtenido = Calculos.GenereElImpuesto(
                elValorFacial, 
                elValorTransadoNeto, 
                laTasaDeImpuesto, 
                laFechaDeVencimiento, 
                laFechaActual, 
                tieneTratamientoFiscal);

            Assert.AreEqual(elImpuestoEsperado, elImpuestoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscalYSeRedondea_RedondeoHaciaArriba()
        {
            elImpuestoEsperado = 1659.3592;

            elValorFacial = 320500;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elImpuestoObtenido = Calculos.GenereElImpuesto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elImpuestoEsperado, elImpuestoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_NoTieneTratamientoFiscal_EsCero()
        {
            elImpuestoEsperado = 0;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000.0001;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = false;
            elImpuestoObtenido = Calculos.GenereElImpuesto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elImpuestoEsperado, elImpuestoObtenido);
        }
    }
}
