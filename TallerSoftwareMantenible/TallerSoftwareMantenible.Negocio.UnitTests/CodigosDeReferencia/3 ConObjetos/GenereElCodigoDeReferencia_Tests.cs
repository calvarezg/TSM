using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConObjetos
{
    [TestClass]
    public class GenereElCodigoDeReferencia_Tests
    {
        private string elCodigoDeCliente;
        private string elCodigoDeSistema;
        private string elCodigoEsperado;
        private string elCodigoObtenido;
        private string elConsecutivo;
        private DateTime laFecha;

        [TestMethod]
        public void GenereElCodigoDeReferencia_GeneraDosVerificadores_TruncaAUnDigito()
        {
            elCodigoEsperado = "20001111333228888888888881";

            laFecha = new DateTime(2000, 11, 11);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "22";
            elConsecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente, 
                elCodigoDeSistema, 
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_ClienteTieneMenosDigitos_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111033228888888888885";

            laFecha = new DateTime(2000, 11, 11);
            elCodigoDeCliente = "33";
            elCodigoDeSistema = "22";
            elConsecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente,
                elCodigoDeSistema,
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_SistemaTieneSoloUnDigito_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111333028888888888884";

            laFecha = new DateTime(2000, 11, 11);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "2";
            elConsecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente,
                elCodigoDeSistema,
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }


        [TestMethod]
        public void GenereElCodigoDeReferencia_MesTieneSoloUnDigito_PrecedeConCero()
        {
            elCodigoEsperado = "20000111333228888888888885";

            laFecha = new DateTime(2000, 1, 11);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "22";
            elConsecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente,
                elCodigoDeSistema,
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_DiaTieneSoloUnDigito_PrecedeConCero()
        {
            elCodigoEsperado = "20001101333228888888888883";

            laFecha = new DateTime(2000, 11, 1);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "22";
            elConsecutivo = "888888888888";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente,
                elCodigoDeSistema,
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }

        [TestMethod]
        public void GenereElCodigoDeReferencia_ConsecutivoTieneMenosDigitos_PrecedeConCeros()
        {
            elCodigoEsperado = "20001111333220000000000047";

            laFecha = new DateTime(2000, 11, 11);
            elCodigoDeCliente = "333";
            elCodigoDeSistema = "22";
            elConsecutivo = "4";
            elCodigoObtenido = new CodigoDeReferencia(
                laFecha,
                elCodigoDeCliente,
                elCodigoDeSistema,
                elConsecutivo).ComoTexto();

            Assert.AreEqual(elCodigoEsperado, elCodigoObtenido);
        }
    }
}
