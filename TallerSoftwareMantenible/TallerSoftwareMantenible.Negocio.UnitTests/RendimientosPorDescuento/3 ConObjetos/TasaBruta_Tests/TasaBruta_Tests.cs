using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConObjetos.TasaBruta_Tests
{
    [TestClass]
    public class TasaBruta_Tests
    {
        private double elResultadoEsperado;
        private double elResultadoObtenido;
        private double elValorFacial;
        private double elValorTransadoNeto;
        private double laTasaDeImpuesto;
        private double losDiasAlVencimiento;

        [TestMethod]
        public void ComoDecimal_Valores_TasaBrutaComoNumero()
        {
            elResultadoEsperado = 11.9679979015017;

            elValorFacial = 320000;
            elValorTransadoNeto = 300000;
            laTasaDeImpuesto = 0.08;
            losDiasAlVencimiento = 221;
            elResultadoObtenido = new TasaBruta(
                elValorFacial, 
                elValorTransadoNeto, 
                laTasaDeImpuesto, 
                losDiasAlVencimiento).ComoNumero();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 13);
        }
    }
}
