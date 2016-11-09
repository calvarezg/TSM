using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Objetos
{
    [TestClass]
    public class ComoNumero
    {
        private decimal elPrecioLimpioDelVectorDePrecios;
        private Monedas elTipoDeMoneda;
        private bool elSaldoEstaAnotadoEnCuenta;
        private decimal elMontoNominalDelSaldo;
        private decimal elTipoDeCambioDeUDESDeHoy;
        private decimal elTipoDeCambioDeUDESDeAyer;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Valores_ValoracionCalculada()
        {
            elResultadoEsperado = 2862400.0M;

            elPrecioLimpioDelVectorDePrecios=80;
            elTipoDeMoneda = Monedas.Colon;
            elMontoNominalDelSaldo = 3578000;
            elSaldoEstaAnotadoEnCuenta = true;
            elTipoDeCambioDeUDESDeHoy = 750;
            elTipoDeCambioDeUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta,elMontoNominalDelSaldo,elTipoDeCambioDeUDESDeHoy,elTipoDeCambioDeUDESDeAyer).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
