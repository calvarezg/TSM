using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.ParameterObject
{
    [TestClass]
    public class ComoNumero
    {
        private DatosDeValoracion losDatos;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Valores_ValoracionCalculada()
        {
            elResultadoEsperado = 2862400.0M;

            losDatos = new DatosDeValoracion();
            losDatos.PrecioLimpioDelVectorDePrecios =80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
