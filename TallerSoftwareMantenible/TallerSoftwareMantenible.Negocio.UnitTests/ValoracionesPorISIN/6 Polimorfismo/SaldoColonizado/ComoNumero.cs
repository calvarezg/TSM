using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Polimorfismo.SaldoColonizado_Tests
{
    [TestClass]
    public class ComoNumero
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_TipoDeCambioDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeHoy()
        {
            elResultadoEsperado = 750000;

            var losDatos = new DatosDeISINAnotadoEnUDESAlTipoDeCambioActual();
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            elResultadoObtenido = losDatos.SaldoColonizado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_TipoDeCambioNoDefinidoParaHoy_MontoColonizadoConTipoDeCambioDeAyer()
        {
            elResultadoEsperado = 745000;

            var losDatos = new DatosDeISINAnotadoEnUDESAlTipoDeCambioDeAyer();
            losDatos.MontoNominalDelSaldo = 1000;            
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = losDatos.SaldoColonizado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
