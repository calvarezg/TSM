using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.CaracterDePeso_Tests
{
    [TestClass]
    public class ComoCaracter_Tests
    {
        private string elRequerimiento;
        private int laPosicionActual;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoCaracter_PrimerCaracter_CaracterComoString()
        {
            elResultadoEsperado = "1";

            laPosicionActual = 0;
            elRequerimiento = "2000111133322888888888888";
            elResultadoObtenido = new CaracterDePeso(elRequerimiento, laPosicionActual).ComoCaracter();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);                
        }        
    }
}
