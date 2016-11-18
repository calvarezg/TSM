using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Polimorfismo
{
    [TestClass]
    public class ComoNumero
    {
        private DatosDeISIN losDatos;
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_Valores_ValoracionCalculada()
        {
            elResultadoEsperado = 2862400.0M;

            var losDatos = new DatosDeISINEnColones();
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;
            elResultadoObtenido = new ValorDeMercado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
