namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class MontoConvertido
    {
        private bool elSaldoSeDebeColonizar;
        private DatosDeValoracion losDatos;

        public MontoConvertido(DatosDeValoracion losDatos)
        {
            elSaldoSeDebeColonizar = ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(losDatos);
            this.losDatos = losDatos;
        }

        private static bool ElSaldoEstaEnUdesYEstaAnotadoEnCuenta(DatosDeValoracion losDatos)
        {
            // TODO: mas de una operacion
            return losDatos.TipoDeMoneda == Monedas.UDES & losDatos.SaldoEstaAnotadoEnCuenta;
        }

        public decimal ComoNumero()
        {
            if (elSaldoSeDebeColonizar)
                return new SaldoColonizado(losDatos).ComoNumero();
            else
                return losDatos.MontoNominalDelSaldo;
        }
    }
}
