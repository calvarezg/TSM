namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class DatosDeISINEnColones : DatosDeISIN
    {
        public override Monedas TipoDeMoneda
        {
            get
            {
                return Monedas.Colon;
            }
        }

        public override decimal MontoConvertido
        {
            get
            {
                return MontoNominalDelSaldo;
            }
        }
    }
}
