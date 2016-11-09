using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.RendimientosPorDescuento.ConTellDonAsk.TasaBruta_Tests
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

            losDatos = new DatosDeTasaBruta
            {
                ValorFacial = 320000,
                ValorTransadoNeto = 300000,
                TasaDeImpuesto = 0.08,
                DiasAlVencimiento = 221
            };
            elResultadoObtenido = new TasaBruta(losDatos).ComoNumero();
            
            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido, 13);
        }
    }
}
