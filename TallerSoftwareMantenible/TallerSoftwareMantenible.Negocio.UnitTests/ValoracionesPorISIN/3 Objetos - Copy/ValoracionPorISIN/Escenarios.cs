using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.ParameterObject.ValoracionPorISIN_Tests
{
    public class Escenarios
    {
        private DatosDeValoracion losDatos;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDeValoracion();
            losDatos = new DatosDeValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.Colon;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 3578000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = false;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            losDatos = new DatosDeValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;
            losDatos.TipoDeCambioUDESDeAyer = 745;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            losDatos = new DatosDeValoracion();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.TipoDeMoneda = Monedas.UDES;
            losDatos.SaldoEstaAnotadoEnCuenta = true;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 0;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            return new
                ValoracionPorISIN(losDatos);
        }
    }
}
