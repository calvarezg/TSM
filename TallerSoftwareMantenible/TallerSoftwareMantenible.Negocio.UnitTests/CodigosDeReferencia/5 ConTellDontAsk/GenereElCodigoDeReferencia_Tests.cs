using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConTellDontAsk
{
    [TestClass]
    public class GenereElCodigoDeReferencia_Tests
    {
        private string elCodigoEsperado;
        private string elCodigoObtenido;
        private DatosDeReferencia losDatos = new DatosDeReferencia();

        [TestMethod]
        public void GenereElCodigoDeReferencia_GeneraDosVerificadores_TruncaAUnDigito()
        {
            elCodigoEsperado = "20001111333228888888888881";

            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_ClienteTieneMenosDigitos_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111033228888888888885";

            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.CodigoDeCliente = "33";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_SistemaTieneSoloUnDigito_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111333028888888888884";

            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "2";
            losDatos.Consecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }


        [TestMethod]
        public void GenereElCodigoDeReferencia_MesTieneSoloUnDigito_PrecedeConCero()
        {
            elCodigoEsperado = "20000111333228888888888885";

            losDatos.Fecha = new DateTime(2000, 1, 11);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_DiaTieneSoloUnDigito_PrecedeConCero()
        {
            elCodigoEsperado = "20001101333228888888888883";

            losDatos.Fecha = new DateTime(2000, 11, 1);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_ConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111333220000000000047";

            losDatos.Fecha = new DateTime(2000, 11, 11);
            losDatos.CodigoDeCliente = "333";
            losDatos.CodigoDeSistema = "22";
            losDatos.Consecutivo = "4";
            elCodigoObtenido = new CodigoDeReferencia(losDatos).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }
    }
}
