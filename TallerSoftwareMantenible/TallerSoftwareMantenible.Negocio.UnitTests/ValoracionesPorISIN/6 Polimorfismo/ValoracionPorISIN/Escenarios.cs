using TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo;
using System;

namespace TallerSoftwareMantenible.Negocio.UnitTests.ValoracionesPorISIN.Polimorfismo.ValoracionPorISIN_Tests
{
    public class Escenarios
    {
        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            var losDatos = new DatosDeISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            var losDatos = new DatosDeISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoNoEstaAnotadoEnCuenta()
        {
            var losDatos = new DatosDeISINNoAnotadoEnUDES();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuenta()
        {
            var losDatos = new DatosDeISINAnotadoEnUDESAlTipoDeCambioActual();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeHoy = 750;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN UnaValoracionEnUDESYElSaldoEstaAnotadoEnCuentaYNoHayTipoDeCambioDeHoy()
        {
            var losDatos = new DatosDeISINAnotadoEnUDESAlTipoDeCambioDeAyer();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6);
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 1000;
            losDatos.TipoDeCambioUDESDeAyer = 745;
            return new ValoracionPorISIN(losDatos);
        }
    }
}
