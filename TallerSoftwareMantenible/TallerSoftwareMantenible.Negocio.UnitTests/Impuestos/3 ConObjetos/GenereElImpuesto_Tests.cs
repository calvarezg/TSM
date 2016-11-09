using TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConObjetos
{
    [TestClass]
    public class GenereElImpuesto_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private int elValorFacial;
        private int elValorTransadoNeto;
        private double laTasaDeImpuesto;
        private DateTime laFechaDeVencimiento;
        private DateTime laFechaActual;
        private bool tieneTratamientoFiscal;

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscal_RedondeoHaciaAbajo()
        {
            elResultadoEsperado = 1621.6216;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elResultadoObtenido = Calculos.GenereElImpuesto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_TieneTratamientoFiscalYSeRedondea_RedondeoHaciaArriba()
        {
            elResultadoEsperado = 1659.3592;

            elValorFacial = 320500;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = true;
            elResultadoObtenido = Calculos.GenereElImpuesto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void GenereElImpuesto_NoTieneTratamientoFiscal_EsCero()
        {
            elResultadoEsperado = 0;

            elValorFacial = 320500;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            tieneTratamientoFiscal = false;
            elResultadoObtenido = Calculos.GenereElImpuesto(
                elValorFacial,
                elValorTransadoNeto,
                laTasaDeImpuesto,
                laFechaDeVencimiento,
                laFechaActual,
                tieneTratamientoFiscal);

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
