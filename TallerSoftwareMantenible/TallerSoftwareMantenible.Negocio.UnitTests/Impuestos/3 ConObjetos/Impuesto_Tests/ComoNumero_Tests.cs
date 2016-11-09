using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.Impuestos.ConObjetos.Impuesto_Tests
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

        [TestMethod]
        public void ComoNumero_ValoresDeEntrada_ImpuestoCorrecto()
        {
            elResultadoEsperado = 1621.6216216216562;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            laFechaDeVencimiento = new DateTime(2016, 10, 10);
            laFechaActual = new DateTime(2016, 3, 3);
            elResultadoObtenido = new Impuesto(
                elValorFacial, 
                elValorTransadoNeto, 
                laTasaDeImpuesto, 
                laFechaDeVencimiento, 
                laFechaActual).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
