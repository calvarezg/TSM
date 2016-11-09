using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Objetos.MontoConvertido_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private Monedas elTipoDeMoneda;
        private bool elSaldoEstaAnotadoEnCuenta;
        private decimal elMontoNominalDelSaldo;
        private decimal elTipoDeCambioDeUDESDeHoy;
        private decimal elTipoDeCambioDeUDESDeAyer;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_SaldoEnColonesAnotadoEnCuenta_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            elTipoDeMoneda = Monedas.Colon;
            elMontoNominalDelSaldo = 3578000;
            elSaldoEstaAnotadoEnCuenta = true;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido); 
        }

        [TestMethod]
        public void ComoNumero_SaldoEnColonesNoAnotado_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            elTipoDeMoneda = Monedas.Colon;
            elMontoNominalDelSaldo = 3578000;
            elSaldoEstaAnotadoEnCuenta = false;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 750000;

            elTipoDeMoneda = Monedas.UDES;
            elMontoNominalDelSaldo = 1000;
            elSaldoEstaAnotadoEnCuenta = true;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYNoAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 1000;

            elTipoDeMoneda = Monedas.UDES;
            elMontoNominalDelSaldo = 1000;
            elSaldoEstaAnotadoEnCuenta = false;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
