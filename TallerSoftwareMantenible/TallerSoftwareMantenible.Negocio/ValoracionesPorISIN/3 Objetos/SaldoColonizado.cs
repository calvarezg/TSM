namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos
{
    public class SaldoColonizado
    {
        private bool hayTipoDeCambioParaHoy;
        private decimal elSaldoColinizadoConTipoDeCambioDeHoy;
        private decimal elSaldoColinizadoConTipoDeCambioDeAyer;

        public SaldoColonizado(decimal elMontoNominalDelSaldo, decimal elTipoDeCambioUDESDeHoy, decimal elTipoDeCambioUDESDeAyer)
        {
            hayTipoDeCambioParaHoy = HayTipoDeCambioParaHoy(elTipoDeCambioUDESDeHoy);
            elSaldoColinizadoConTipoDeCambioDeHoy = CalculeElSaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioUDESDeHoy);
            elSaldoColinizadoConTipoDeCambioDeAyer = CalculeElSaldoColonizado(elMontoNominalDelSaldo, elTipoDeCambioUDESDeAyer);
        }

        private bool HayTipoDeCambioParaHoy(decimal elTipoDeCambioUDESDeHoy)
        {
            return elTipoDeCambioUDESDeHoy > 0;
        }

        private decimal CalculeElSaldoColonizado(decimal elMontoNominalDelSaldo, decimal elTipoDeCambio)
        {
            return elMontoNominalDelSaldo * elTipoDeCambio;
        }        

        public decimal ComoNumero()
        {
            if (hayTipoDeCambioParaHoy)
                return elSaldoColinizadoConTipoDeCambioDeHoy;
            else

                return elSaldoColinizadoConTipoDeCambioDeAyer;
        }
    }
}
