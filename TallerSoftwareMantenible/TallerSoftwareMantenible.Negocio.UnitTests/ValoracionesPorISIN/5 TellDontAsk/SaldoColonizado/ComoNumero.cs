using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.TellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.TellDontAsk.SaldoColonizado_Tests
{
    [TestClass]
    public class ComoNumero
    {
        private DatosDeValoracion losDatos;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_TipoDeCambioDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 750000;

            losDatos = new DatosDeValoracion();
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = losDatos.SaldoColonizado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_TipoDeCambioNoDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 745000;

            losDatos = new DatosDeValoracion();
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 0;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = losDatos.SaldoColonizado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
