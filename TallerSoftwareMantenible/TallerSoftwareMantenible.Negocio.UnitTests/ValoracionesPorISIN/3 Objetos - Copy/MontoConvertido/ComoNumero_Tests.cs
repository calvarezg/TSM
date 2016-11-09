using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.ParameterObject.MontoConvertido_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private DatosDeValoracion losDatos;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_SaldoEnColonesAnotadoEnCuenta_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            losDatos = new DatosDeValoracion();
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnColonesNoAnotado_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            losDatos = new DatosDeValoracion();
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.SaldoEstaAnotadoEnCuenta = false;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 750000;

            losDatos = new DatosDeValoracion();
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYNoAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 1000;

            losDatos = new DatosDeValoracion();
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.SaldoEstaAnotadoEnCuenta = false;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new MontoConvertido(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
