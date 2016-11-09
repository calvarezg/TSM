using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Objetos.SaldoColonizado_Tests
{
    [TestClass]
    public class ComoNumero
    {
        private decimal elMontoNominalDelSaldo;
        private decimal elTipoDeCambioUDESDeHoy;
        private decimal elTipoDeCambioUDESDeAyer;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_TipoDeCambioDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 750000;

            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioUDESDeHoy = 750;
            elTipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new SaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioUDESDeHoy, elTipoDeCambioUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_TipoDeCambioNoDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 745000;

            elMontoNominalDelSaldo = 1000;
            elTipoDeCambioUDESDeHoy = 0;
            elTipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new SaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioUDESDeHoy, elTipoDeCambioUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
