using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos
{
    public class ValoracionPorISIN
    {
        private decimal elPorcentajeDeCoberturaRevisado;
        private decimal elValorDeMercado;

        public ValoracionPorISIN(
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
            ISIN = elISIN;

            elPorcentajeDeCoberturaRevisado = ObtengaElProcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura);
            PorcentajeDeCobertura = elPorcentajeDeCoberturaRevisado;

            elValorDeMercado = ObtengaElValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer);
            ValorDeMercado = elValorDeMercado;

            AporteDeGarantia = CalculeElAporteDeGarantia(elPorcentajeDeCoberturaRevisado, elValorDeMercado);
        }

        public string ISIN { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeDeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }

        private static decimal ObtengaElProcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            return new PorcentajeDeCoberturaRevisado(laFechaActual, laFechaDeVencimientoDelValorOficial, losDiasMinimosAlVencimientoDelEmisor, elPorcentajeCobertura).ComoNumero();
        }

        private decimal ObtengaElValorDeMercado(decimal elPrecioLimpioDelVectorDePrecios, Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioUDESDeHoy, decimal elTipoDeCambioUDESDeAyer)
        {
            return new ValorDeMercado(elPrecioLimpioDelVectorDePrecios, elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta, elMontoNominalDelSaldo, elTipoDeCambioUDESDeHoy, elTipoDeCambioUDESDeAyer).ComoNumero();
        }

        private static decimal CalculeElAporteDeGarantia(decimal elPorcentajeDeCoberturaRevisado, decimal elValorDeMercado)
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }

    }
}