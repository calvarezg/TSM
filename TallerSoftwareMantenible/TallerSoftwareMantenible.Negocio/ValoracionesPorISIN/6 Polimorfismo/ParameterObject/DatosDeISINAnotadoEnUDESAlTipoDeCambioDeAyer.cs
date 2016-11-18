namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class DatosDeISINAnotadoEnUDESAlTipoDeCambioDeAyer : DatosDeISINAnotadoEnUDES
    {
        public decimal TipoDeCambioUDESDeAyer;

        public override decimal SaldoColonizado
        {
            get
            {
                return MontoNominalDelSaldo * TipoDeCambioUDESDeAyer;
            }
        }
    }
}
