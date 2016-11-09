using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Funciones
{
    public class Calculos
    {
        public static ValoracionPorISIN GenereLaValoracionPorISIN(
            string elISIN,
            DateTime laFechaActual,
            DateTime laFechaDeVencimientoDelValorOficial,
            int losDiasMinimosAlVencimientoDelEmisor,
            decimal elPorcentajeCobertura,
            decimal elPrecioLimpioDelVectorDePrecios,
            Monedas elTipoDeMoneda,
            bool elSaldoEstaAnotadoEnCuenta,
            decimal elMontoNominalDelSaldo,
            decimal elTipoDeCambioDeUDESDeHoy,
            decimal elTipoDeCambioDeUDESDeAyer)
        {
            ValoracionPorISIN laValoracion = new ValoracionPorISIN();

            laValoracion.ISIN = elISIN;

            decimal elPorcentajeDeCoberturaRevisado = ObtengaElPorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura);
            laValoracion.PorcentajeCobertura = elPorcentajeDeCoberturaRevisado;

            decimal elValorDeMercado = ObtengaElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            laValoracion.ValorDeMercado = elValorDeMercado;

            laValoracion.AporteDeGarantia = CalculeElAporteDeGarantia(elPorcentajeDeCoberturaRevisado, elValorDeMercado);

            return laValoracion;
        }

        private static decimal ObtengaElPorcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            double losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial);
            return CalculeElProcentajeDeCoberturaRevisado(losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura, losDiasAlVencimiento);
        }

        private static double ObtengaLosDiasAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            TimeSpan elPlazoAlVencimiento = CalculeElPlazoDeVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial);
            return ExtraigaLaDiferenciaEnDias(elPlazoAlVencimiento);
        }

        private static TimeSpan CalculeElPlazoDeVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            return laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
        }

        private static double ExtraigaLaDiferenciaEnDias(TimeSpan elPlazoAlVencimiento)
        {
            return elPlazoAlVencimiento.TotalDays;
        }

        private static decimal CalculeElProcentajeDeCoberturaRevisado(int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura, double losDiasAlVencimiento)
        {
            if (LosDiasAlVencimientoSonMenosQueLosPermitidos(losDiasMinimosAlVencimientoDelEmisor, losDiasAlVencimiento))
                return 0;
            else
                return elPorcentajeCobertura;
        }

        private static bool LosDiasAlVencimientoSonMenosQueLosPermitidos(int losDiasMinimosAlVencimientoDelEmisor, double losDiasAlVencimiento)
        {
            return losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor;
        }

        private static decimal ObtengaElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            decimal elMontoConvertido = ObtengaElMontoConvertido(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            return CalculeElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elMontoConvertido);
        }

        private static decimal ObtengaElMontoConvertido(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            if (ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta))
                return ObtengaElSaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            else
                return elMontoNominalDelSaldo;
        }

        private static bool ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta)
        {
            return elTipoDeMoneda == Monedas.UDES & elSaldoEstaAnotadoEnCuenta;
        }

        private static decimal ObtengaElSaldoColonizado(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            if (HayTipoDeCambioParaHoy(elTipoDeCambioDeUDESDeHoy))
                return CalculeElSaldoColonizadoConElTipoDeCambioDeHoy(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy);
            else
            {
                return CalculeElSaldoColonizadoConTipoDeCambioDeAyer(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeAyer);
            }
        }

        private static bool HayTipoDeCambioParaHoy(decimal elTipoDeCambioDeUDESDeHoy)
        {
            return elTipoDeCambioDeUDESDeHoy > 0;
        }

        private static decimal CalculeElSaldoColonizadoConElTipoDeCambioDeHoy(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy)
        {
            return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeHoy;
        }

        private static decimal CalculeElSaldoColonizadoConTipoDeCambioDeAyer(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeAyer)
        {
            return elMontoNominalDelSaldo * elTipoDeCambioDeUDESDeAyer;
        }

        private static decimal CalculeElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, decimal elMontoConvertido)
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }

        private static decimal CalculeElAporteDeGarantia(decimal elPorcentajeDeCoberturaRevisado, decimal elValorDeMercado)
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }
    }
}
