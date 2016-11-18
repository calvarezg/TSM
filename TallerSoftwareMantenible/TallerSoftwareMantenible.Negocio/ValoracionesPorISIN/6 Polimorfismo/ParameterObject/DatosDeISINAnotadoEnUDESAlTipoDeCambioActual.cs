namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class DatosDeISINAnotadoEnUDESAlTipoDeCambioActual : DatosDeISINAnotadoEnUDES
    {
        public decimal TipoDeCambioUDESDeHoy;

        public override decimal SaldoColonizado
        {
            get
            {
                return MontoNominalDelSaldo * TipoDeCambioUDESDeHoy;
            }
        }        
    }
}
