﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject;

namespace TallerSoftwareMantenible.Negocio.UnitTests.CodigosDeReferencia.ConParameterObject.Dia_Tests
{
    [TestClass]
    public class ComoTexto_Tests
    {
        private DatosDeReferencia losDatos;
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod]
        public void ComoTexto_Fecha_DiaComoTexto()
        {
            elResultadoEsperado = "1";

            losDatos = new DatosDeReferencia();
            losDatos.Fecha = new DateTime(2016, 1, 1);
            elResultadoObtenido = new Dia(losDatos).ComoTexto();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}
