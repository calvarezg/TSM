using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConObjetos.ImpuestoRedondeado_Tests
{
    [TestClass]
    public class ConCuatroDecimales_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private double elValorFacial;
        private double elValorTransadoNeto;
        private DateTime laFechaActual;
        private DateTime laFechaDeVencimiento;
        private double laTasaDeImpuesto;

        [TestMethod]
        public void ConCuatroDecimales_ValoresDeEntrada_ImpuestoRedondeadoA4Decimales()
        {
            elResultadoEsperado = 1621.6216;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new ImpuestoRedondeado(
                elValorFacial, 
                elValorTransadoNeto, 
                laTasaDeImpuesto, 
                laFechaDeVencimiento, 
                laFechaActual).ConCuatroDecimales();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
