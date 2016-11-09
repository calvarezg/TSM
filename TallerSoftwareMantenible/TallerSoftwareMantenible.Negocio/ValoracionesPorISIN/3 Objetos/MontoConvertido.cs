namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos
{
    public class MontoConvertido
    {
        private decimal elMontoNominalDelSaldo;
        private bool elSaldoSeDebeColonizar;
        private decimal elTipoDeCambioDeUDESDeAyer;
        private decimal elTipoDeCambioDeUDESDeHoy;

        public MontoConvertido(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta, decimal elMontoNominalDelSaldo, decimal elTipoDeCambioDeUDESDeHoy, decimal elTipoDeCambioDeUDESDeAyer)
        {
            elSaldoSeDebeColonizar = ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(elTipoDeMoneda, elSaldoEstaAnotadoEnCuenta);
            this.elMontoNominalDelSaldo = elMontoNominalDelSaldo;
            this.elTipoDeCambioDeUDESDeHoy = elTipoDeCambioDeUDESDeHoy;
            this.elTipoDeCambioDeUDESDeAyer = elTipoDeCambioDeUDESDeAyer;
        }

        private static bool ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(Monedas elTipoDeMoneda, bool elSaldoEstaAnotadoEnCuenta)
        {
            return elTipoDeMoneda == Monedas.UDES & elSaldoEstaAnotadoEnCuenta;
        }

        public decimal ComoNumero()
        {
            if (elSaldoSeDebeColonizar)
                return new SaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioDeUDESDeHoy, elTipoDeCambioDeUDESDeAyer).ComoNumero();
            else
                return elMontoNominalDelSaldo;
        }
    }
}
