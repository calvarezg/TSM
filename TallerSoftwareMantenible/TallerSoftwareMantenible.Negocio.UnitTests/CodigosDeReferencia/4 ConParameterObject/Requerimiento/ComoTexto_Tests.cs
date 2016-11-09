using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.Requerimiento_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {  
        private string elResultadoEsperado;
        private string elResultadoObtenido;
        private DatosDeReferencia losDatos;

        [TestMethod]
        public void ComoTexto_Requerimiento_ValorCorrecto()
        {
            elResultadoEsperado = "2000111133322888888888888";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "888888888888";
            elResultadoObtenido = new Requerimiento(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
