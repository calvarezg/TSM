using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Polimorfismo.MontoConvertido_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_SaldoEnColonesAnotadoEnCuenta_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            var losDatos = new DatosDeISINEnColones();
            losDatos.MontoNominalDelSaldo = 3578000;
            elResultadoObtenido = losDatos.MontoConvertido;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnColonesNoAnotado_MontoNominalDelSaldoSinColonizar()
        {
            elResultadoEsperado = 3578000;

            var losDatos = new DatosDeISINEnColones();
            losDatos.MontoNominalDelSaldo = 3578000;
            elResultadoObtenido = losDatos.MontoConvertido;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 750000;

            var losDatos = new DatosDeISINAnotadoEnUDESAlTipoDeCambioActual();
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            elResultadoObtenido = losDatos.MontoConvertido;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void ComoNumero_SaldoEnUdesYNoAnotadoEnCuenta_MontoNominalColonizado()
        {
            elResultadoEsperado = 1000;

            var losDatos = new DatosDeISINNoAnotadoEnUDES();
            losDatos.MontoNominalDelSaldo = 1000;
            elResultadoObtenido = losDatos.MontoConvertido;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
